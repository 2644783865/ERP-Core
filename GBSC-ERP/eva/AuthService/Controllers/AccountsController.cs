﻿using AuthService.Helpers;
using AuthService.ViewModels;
using ErpInfrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpCore.Entities;
using ErpCore.Filters;
using Microsoft.AspNetCore.Cors;
using System.IO;
using Newtonsoft.Json.Linq;
using SystemAdministrationService.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace AuthService.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AccountsController : Controller
    {
        private readonly RoleManager<IdentityRole> role_Manager;
        private readonly UserManager<AppUser> user_Manager;
        private ApplicationDbContext app_context;

        public AccountsController(RoleManager<IdentityRole> role_id, UserManager<AppUser> appUser, ApplicationDbContext context)
        {
            role_Manager = role_id;
            user_Manager = appUser;
            app_context = context;
        }

        [HttpPost]
        [ValidateModelAttribute]
        public async Task<IActionResult> CreateAccount([FromBody]RegistrationViewModel model)
        {
            var userIdentity = new AppUser { UserName = model.UserName, Email = model.Email, PhoneNumber = model.Phone };
            var userManager = await user_Manager.CreateAsync(userIdentity, model.Password);

            if (!userManager.Succeeded)
            {
                return new BadRequestObjectResult(Errors.AddErrorsToModelState(userManager, ModelState));
            }

            var lockout = await user_Manager.SetLockoutEnabledAsync(userIdentity, false);

            User user = new User();

            if (model.UserExists)
            {
                user = app_context.Users.Find(model.UserId);
                user.IdentityId = userIdentity.Id;
            }
            else
            {
                user = new User
                {
                    FirstName = model.FirstName,
                    IdentityId = userIdentity.Id,
                    LastName = model.LastName,
                    FullName = model.FirstName+" "+model.LastName,
                    UserType = model.UserType,
                    CompanyId = model.CompanyId,
                    CityId = model.CityId,
                    RoleId = model.RoleId,
                    Phone = model.Phone,
                    DOB = model.DOB,
                    Gender = model.Gender,
                    CNIC = model.CNIC,
                    DateCreated = DateTime.Now,
                    Email = model.Email
                };
            }

            if (model.IsSystemAdmin)
            {
                user.UserLevel = "Admin";
                user.Role = CreateRoleWithAssignedModules(model.CompanyId);
            }

            app_context.Users.Add(user);
            app_context.SaveChanges();

            return new OkObjectResult(new { UserId = user.UserId });
        }

        [HttpPut("UpdateProfile")]
        public IActionResult UpdateProfile([FromBody]User user)
        {
            app_context.Users.Update(user);
            app_context.SaveChanges();

            return new OkObjectResult(new { userId = user.UserId });
        }

        public Role CreateRoleWithAssignedModules(long? CompanyId)
        {
            if (CompanyId > 0)
            {

                List<RoleModule> roleModules = new List<RoleModule>();

                List<RoleFeature> roleFeatures = new List<RoleFeature>();

                List<Permission> permissions = new List<Permission>();

                var AllFeatures = ReadJson();

                var modules = app_context.Modules.Include(f => f.Features)
                    .Where(c => c.CompanyId == CompanyId)
                    .ToList();

                var permissionAttributes = new string[] { "Read", "Write", "Update", "Delete" };

                foreach (var module in modules)
                {

                    var roleModule = new RoleModule
                    {
                        ModuleId = module.ModuleId,

                    };

                    roleModules.Add(roleModule);

                    foreach (var feature in module.Features)
                    {
                        roleFeatures.Add(new RoleFeature
                        {
                            FeatureId = feature.FeatureId
                        });

                        foreach (var att in permissionAttributes)
                        {
                            permissions.Add(new Permission
                            {
                                Attribute = att,
                                FeatureId = feature.FeatureId,
                                CompanyId = CompanyId
                            });
                        }
                    }
                }

                var role = new Role
                {
                    Name = "SystemAdmin",
                    RoleModules = roleModules,
                    RoleFeatures = roleFeatures,
                    CompanyId = CompanyId
                };

                app_context.Modules.UpdateRange(modules);
                app_context.Roles.Add(role);
                app_context.SaveChanges();

                for (int i = 0; i < permissions.Count; i++)
                {
                    permissions[i].RoleId = role.RoleId;
                }

                app_context.Permissions.AddRange(permissions);
                app_context.SaveChanges();

                return role;

            }

            return null;
        }

        internal FeaturesViewModel ReadJson()
        {
            var rootPath = System.IO.Directory.GetCurrentDirectory();

            DirectoryInfo d = new DirectoryInfo(Path.Combine(rootPath, "JsonFiles"));

            FileInfo[] Files = d.GetFiles("Features.json"); //Getting JSON files

            foreach (var file in Files)
            {
                using (StreamReader r = new StreamReader(file.FullName))
                {
                    var json = r.ReadToEnd();
                    var jobj = JObject.Parse(json);
                    var result = jobj.ToString();

                    var featurs = Newtonsoft.Json.JsonConvert.DeserializeObject<FeaturesViewModel>(result);

                    return featurs;
                }
            }

            return null;
        }

        [HttpPost("ChangePassword")]
        public async Task<IActionResult> ChangePassword([FromBody]ChangePasswordViewModel usermodel)
        {
            var user = await user_Manager.FindByNameAsync(usermodel.Username);
            var result = await user_Manager.ChangePasswordAsync(user, usermodel.OldPassword, usermodel.NewPassword);
            if (!result.Succeeded)
            {
                return new BadRequestObjectResult("Password could not be changed");
            }
            return new OkObjectResult("Password successfully changed");
        }
    }
}
