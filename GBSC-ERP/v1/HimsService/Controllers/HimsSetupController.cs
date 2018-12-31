using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpCore.Entities;
using ErpCore.Entities.HimsSetup;
using ErpCore.Filters;
using HimsService.Repos.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HimsService.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class HimsSetupController : Controller
    {
        private IPackageRepository package_repo;
        private ITestRepository test_repo;
        private IConsultantRepository con_repo;
        private IDiagnosisRepository dia_repo;
        private IEmbryologistRepository embryologistRepo;
        private IEmbryologyCodeRepository embryologyCodeRepo;
        private IVisitNatureRepository VisitNature_repo;
        private ITestTypeRepository testType_repo;
        private ITestCategoryRepository testCategory_repo;
        private IPatientPackageRepository Patientpackage_repo;
        private IProcedureRepository Procedure_repo;

    public HimsSetupController(IPackageRepository packagerepo,
            ITestRepository testrepo,
            IConsultantRepository consultantRepository,
            IDiagnosisRepository diarepo,
            IEmbryologistRepository _embryologistRepo,
            IEmbryologyCodeRepository _embryologyCodeRepo,
            IVisitNatureRepository _VisitNature_repo,
            ITestTypeRepository tsttyperepo,
            ITestCategoryRepository tstcatrepo,
            IPatientPackageRepository Patientpackagerepo,
            IProcedureRepository Procedurerepo 
       )
        {
            con_repo = consultantRepository;
            package_repo = packagerepo;
            test_repo = testrepo;
            dia_repo = diarepo;
            embryologistRepo = _embryologistRepo;
            embryologyCodeRepo = _embryologyCodeRepo;
            VisitNature_repo = _VisitNature_repo;
            testType_repo = tsttyperepo;
            testCategory_repo = tstcatrepo;
            Patientpackage_repo = Patientpackagerepo;
            Procedure_repo = Procedurerepo;
         }

        //[HttpGet("GetHimsSetupPermissions/{userid}/{RoleId}/{featureid}", Name = "GetHimsSetupPermissions")]
        //public IEnumerable<Permission> GetHimsSetupPermissions(long userid, long RoleId, long featureid)
        //{
        //    IEnumerable<Permission> per = con_repo.GetFeaturePermissions(userid, RoleId, featureid).Permissions.ToList();
        //    return per;
        //}

        #region Consultant

        [HttpGet("GetConsultants", Name = "GetConsultants")]
        public IEnumerable<Consultant> GetConsultants()
        {
          // return con_repo.GetAll();
          IEnumerable<Consultant> ap = con_repo.GetAll();
          ap = ap.OrderByDescending(a => a.ConsultantId);
          return ap;
    }

        [HttpGet("GetConsultant/{id}", Name = "GetConsultant")]
        public Consultant GetConsultant([FromRoute]long id) => con_repo.GetFirst(a => a.ConsultantId == id);

        [HttpPost("AddConsultant", Name = "AddConsultant")]
        [ValidateModelAttribute]
        public IActionResult AddConsultant([FromBody]Consultant model)
        {
            con_repo.Add(model);
            return new OkObjectResult(new { ConsultantId = model.ConsultantId });
        }

        [HttpPut("UpdateConsultant", Name = "UpdateConsultant")]
        public IActionResult UpdateConsultant([FromBody]Consultant model)
        {
            if (!ModelState.IsValid)
            {
                return new OkObjectResult("Invalid Model");
            }
            con_repo.Update(model);
            return new OkObjectResult(new { ConsultantId = model.ConsultantId });
        }

        [HttpDelete("DeleteConsultant/{id}")]
        public IActionResult DeleteConsultant(long id)
        {
            Consultant a = con_repo.Find(id);
            if (a == null)
            {
                return NotFound();
            }
            con_repo.Delete(a);
            return Ok();
        }

        #endregion

        #region Package

        [HttpGet("GetPackages", Name = "GetPackages")]
        public IEnumerable<Package> GetPackages()
        {
            IEnumerable<Package> pa = package_repo.GetAll();
            pa = pa.OrderByDescending(a => a.PackageId);
            return pa;
        }

        [HttpGet("GetPackagesByCompany/{CompanyId}", Name = "GetPackagesByCompany")]
        public IEnumerable<Package> GetPackagesByCompany(long CompanyId)
        {
            IEnumerable<Package> pa = package_repo.GetList(c => c.CompanyId == CompanyId);
            pa = pa.OrderByDescending(a => a.PackageId);
            return pa;
        }

        [HttpGet("GetPackagesByBranch/{BranchId}", Name = "GetPackagesByBranch")]
        public IEnumerable<Package> GetPackagesByBranch(long BranchId)
        {
            IEnumerable<Package> pa = package_repo.GetList(c => c.BranchId == BranchId);
            pa = pa.OrderByDescending(a => a.PackageId);
            return pa;
        }

        [HttpGet("GetPackage/{id}", Name = "GetPackage")]
        public Package GetPackage(long id) => package_repo.GetFirst(a => a.PackageId == id);

        [HttpPut("UpdatePackage", Name = "UpdatePackage")]
        [ValidateModelAttribute]
        public IActionResult UpdatePackage([FromBody]Package model)
        {
            package_repo.Update(model);
            return new OkObjectResult(new { PackageID = model.PackageId });
        }

        [HttpPost("AddPackage", Name = "AddPackage")]
        [ValidateModelAttribute]
        public IActionResult AddPackage([FromBody]Package model)
        {
            package_repo.Add(model);
            return new OkObjectResult(new { PackageID = model.PackageId });
        }

        [HttpDelete("DeletePackage/{id}")]
        public IActionResult DeletePackage(long id)
        {
            Package package = package_repo.Find(id);
            if (package == null)
            {
                return NotFound();
            }

            package_repo.Delete(package);
            return Ok();
        }

        #endregion

        #region Patient Package

        [HttpGet("GetPatientPackages", Name = "GetPatientPackages")]
        public IEnumerable<PatientPackage> GetPatientPackages()
        {
            return Patientpackage_repo.GetAll().OrderByDescending(a => a.PatientPackageId);
        }

        [HttpGet("GetPatientPackage/{id}", Name = "GetPatientPackage")]
        public PatientPackage GetPatientPackage(long id) => Patientpackage_repo.GetFirst(a => a.PatientPackageId == id);

        [HttpGet("GetPatientPackageByPatientId/{patientid}", Name = "GetPatientPackageByPatientId")]
        public PatientPackage GetPatientPackageByPatientId(long patientid) => Patientpackage_repo.GetFirst(a => a.PatientId == patientid, b => b.Package);

        [HttpPut("UpdatePatientPackage", Name = "UpdatePatientPackage")]
        [ValidateModelAttribute]
        public IActionResult UpdatePatientPackage([FromBody]PatientPackage model)
        {
            Patientpackage_repo.Update(model);
            return new OkObjectResult(new { PatientPackageID = model.PatientPackageId });
        }

        [HttpPost("AddPatientPackage", Name = "AddPatientPackage")]
        [ValidateModelAttribute]
        public IActionResult AddPatientPackage([FromBody]PatientPackage model)
        {
            Patientpackage_repo.Add(model);
            return new OkObjectResult(new { PatientPackageID = model.PatientPackageId });
        }

        [HttpDelete("DeletePatientPackage/{id}")]
        public IActionResult DeletePatientPackage(long id)
        {
            PatientPackage Patientpackage = Patientpackage_repo.Find(id);
            if (Patientpackage == null)
            {
                return NotFound();
            }

            Patientpackage_repo.Delete(Patientpackage);
            return Ok();
        }

        #endregion

        #region Test Type

        [HttpGet("GetTestTypes", Name = "GetTestTypes")]
        public IEnumerable<TestType> GetTestTypes()
        {
            return testType_repo.GetAll().OrderByDescending(a => a.TestTypeId);
        }

        [HttpGet("GetTestType/{id}", Name = "GetTestType")]
        public TestType GetTestType(long id) => testType_repo.GetFirst(a => a.TestTypeId == id);

        [HttpPut("UpdateTestType", Name = "UpdateTestType")]
        [ValidateModelAttribute]
        public IActionResult UpdateTestType([FromBody]TestType model)
        {
            testType_repo.Update(model);
            return new OkObjectResult(new { TestTypeID = model.TestTypeId });
        }

        [HttpPost("AddTestType", Name = "AddTestType")]
        [ValidateModelAttribute]
        public IActionResult AddTestType([FromBody]TestType model)
        {
            testType_repo.Add(model);
            return new OkObjectResult(new { TestTypeID = model.TestTypeId });
        }

        [HttpDelete("DeleteTestType/{id}")]
        public IActionResult DeleteTestType(long id)
        {
            TestType test = testType_repo.Find(id);
            if (test == null)
            {
                return NotFound();
            }

            testType_repo.Delete(test);
            return Ok();
        }

        #endregion

        #region Test Category

        [HttpGet("GetTestCategories", Name = "GetTestCategories")]
        public IEnumerable<TestCategory> GetTestCategories()
        {
            return testCategory_repo.GetAll().OrderByDescending(a => a.TestCategoryId);
        }

        [HttpGet("GetTestCategory/{id}", Name = "GetTestCategory")]
        public TestCategory GetTestCategory(long id) => testCategory_repo.GetFirst(a => a.TestCategoryId == id);

        [HttpPut("UpdateTestCategory", Name = "UpdateTestCategory")]
        [ValidateModelAttribute]
        public IActionResult UpdateTestCategory([FromBody]TestCategory model)
        {
            testCategory_repo.Update(model);
            return new OkObjectResult(new { TestCategoryID = model.TestCategoryId });
        }

        [HttpPost("AddTestCategory", Name = "AddTestCategory")]
        [ValidateModelAttribute]
        public IActionResult AddTestCategory([FromBody]TestCategory model)
        {
            testCategory_repo.Add(model);
            return new OkObjectResult(new { TestCategoryID = model.TestCategoryId });
        }

        [HttpDelete("DeleteTestCategory/{id}")]
        public IActionResult DeleteTestCategory(long id)
        {
            TestCategory test = testCategory_repo.Find(id);
            if (test == null)
            {
                return NotFound();
            }

            testCategory_repo.Delete(test);
            return Ok();
        }

        #endregion

        #region Test

        [HttpGet("GetTests", Name = "GetTests")]
        public IEnumerable<Test> GetTests()
        {
            IEnumerable<Test> ap = test_repo.GetAll(a => a.AppointmentTests);
            ap = ap.OrderByDescending(a => a.TestId);
            return ap;
        }

        [HttpGet("GetTest/{id}", Name = "GetTest")]
        public Test GetTest(long id) => test_repo.GetFirst(a => a.TestId == id);

        [HttpPut("UpdateTest", Name = "UpdateTest")]
        [ValidateModelAttribute]
        public IActionResult UpdateTest([FromBody]Test model)
        {
            test_repo.Update(model);
            return new OkObjectResult(new { TestID = model.TestId });
        }

        [HttpPost("AddTest", Name = "AddTest")]
        [ValidateModelAttribute]
        public IActionResult AddTest([FromBody]Test model)
        {
            test_repo.Add(model);
            return new OkObjectResult(new { TestID = model.TestId });
        }

        [HttpDelete("DeleteTest/{id}")]
        public IActionResult DeleteTest(long id)
        {
            Test test = test_repo.Find(id);
            if (test == null)
            {
                return NotFound();
            }

            test_repo.Delete(test);
            return Ok();
        }

    #endregion

        #region Diagnosis

    [HttpGet("GetDiagnoses", Name = "GetDiagnoses")]
        public IEnumerable<Diagnosis> GetDiagnoses()
        {
            IEnumerable<Diagnosis> d = dia_repo.GetAll();
            d = d.OrderByDescending(a => a.DiagnosisId);
            return d;
        }

        [HttpGet("GetDiagnosis/{id}", Name = "GetDiagnosis")]
        public Diagnosis GetDiagnosis(long id) => dia_repo.GetFirst(a => a.DiagnosisId == id);

        [HttpPut("UpdateDiagnosis", Name = "UpdateDiagnosis")]
        [ValidateModelAttribute]
        public IActionResult UpdateDiagnosis([FromBody]Diagnosis model)
        {
            dia_repo.Update(model);
            return new OkObjectResult(new { DiagnosisID = model.DiagnosisId });
        }

        [HttpPost("AddDiagnosis", Name = "AddDiagnosis")]
        [ValidateModelAttribute]
        public IActionResult AddDiagnosis([FromBody]Diagnosis model)
        {
            dia_repo.Add(model);
            return new OkObjectResult(new { DiagnosisID = model.DiagnosisId });
        }

        [HttpDelete("DeleteDiagnosis/{id}")]
        public IActionResult DeleteDiagnosis(long id)
        {
            Diagnosis dia = dia_repo.Find(id);
            if (dia == null)
            {
                return NotFound();
            }

            dia_repo.Delete(dia);
            return Ok();
        }

        #endregion

        #region Embryologist

        [HttpPost("AddEmbryologist")]
        public IActionResult AddEmbryologist([FromBody]Embryologist model)
        {
            embryologistRepo.Add(model);

            return new OkObjectResult(new { EmbryologistId = model.EmbryologistId });
        }

        [HttpPut("UpdateEmbryologist")]
        public IActionResult UpdateEmbryologist([FromBody]Embryologist model)
        {
            embryologistRepo.Update(model);

            return new OkObjectResult(new { EmbryologistID = model.EmbryologistId });
        }

        [HttpGet("GetEmbryologists")]
        public IEnumerable<Embryologist> GetEmbryologists()
        {
            return embryologistRepo.GetAll();
        }

        [HttpGet("GetEmbryologist/{Id}")]
        public Embryologist GetEmbryologist(long Id)
        {
            return embryologistRepo.Find(Id);
        }

        [HttpDelete("DeleteEmbryologist/{id}", Name = "DeleteEmbryologist")]
        public IActionResult DeleteEmbryologist(long id)
        {
            Embryologist er = embryologistRepo.Find(id);
            if (er == null)
            {
                return NoContent();
            }
            embryologistRepo.Delete(er);
            return Ok();
        }

        #endregion

        #region Embryology Code

        [HttpPost("AddEmbryologyCode")]
        public IActionResult AddEmbryologyCode([FromBody]EmbryologyCode model)
        {
            embryologyCodeRepo.Add(model);

            return new OkObjectResult(new { EmbryologyCodeId = model.EmbryologyCodeId });
        }

        [HttpPut("UpdateEmbryologyCode")]
        public IActionResult UpdateEmbryologyCode([FromBody]EmbryologyCode model)
        {
            embryologyCodeRepo.Update(model);

            return new OkObjectResult(new { EmbryologyCodeId = model.EmbryologyCodeId });
        }

        [HttpGet("GetEmbryologyCodes")]
        public IEnumerable<EmbryologyCode> GetEmbryologyCodes()
        {
            return embryologyCodeRepo.GetAll();
        }

        [HttpGet("GetEmbryologyCode/{Id}")]
        public EmbryologyCode GetEmbryologyCode(long Id)
        {
            return embryologyCodeRepo.Find(Id);
        }

        [HttpDelete("DeleteEmbryologyCode/{id}", Name = "DeleteEmbryologyCode")]
        public IActionResult DeleteEmbryologyCode(long id)
        {
            EmbryologyCode er = embryologyCodeRepo.Find(id);
            if (er == null)
            {
                return NoContent();
            }
            embryologyCodeRepo.Delete(er);
            return Ok();
        }

        #endregion

        #region VisitNature

        [HttpGet("GetVisitNatures", Name = "GetVisitNatures")]
        public IEnumerable<VisitNature> GetVisitNatures()
        {
            IEnumerable<VisitNature> ap = VisitNature_repo.GetAll();
            ap = ap.OrderByDescending(a => a.VisitNatureId);
            return ap;
        }

        [HttpGet("GetVisitNature/{id}", Name = "GetVisitNature")]
        public VisitNature GetVisitNature(long id) => VisitNature_repo.GetFirst(a => a.VisitNatureId == id);

        [HttpPut("UpdateVisitNature", Name = "UpdateVisitNature")]
        [ValidateModelAttribute]
        public IActionResult UpdateVisitNature([FromBody]VisitNature model)
        {
            VisitNature_repo.Update(model);
            return new OkObjectResult(new { VisitNatureID = model.VisitNatureId });
        }

        [HttpPost("AddVisitNature", Name = "AddVisitNature")]
        [ValidateModelAttribute]
        public IActionResult AddVisitNature([FromBody]VisitNature model)
        {
            VisitNature_repo.Add(model);
            return new OkObjectResult(new { VisitNatureID = model.VisitNatureId });
        }

        [HttpDelete("DeleteVisitNature/{id}")]
        public IActionResult DeleteVisitNature(long id)
        {
            VisitNature VisitNature = VisitNature_repo.Find(id);
            if (VisitNature == null)
            {
                return NotFound();
            }

            VisitNature_repo.Delete(VisitNature);
            return Ok();
        }

    #endregion



    #region Procedure

    [HttpGet("GetProcedures", Name = "GetProcedures")]
    public IEnumerable<Procedure> GetProcedures()
    {
      IEnumerable<Procedure> ap = Procedure_repo.GetAll();
      ap = ap.OrderByDescending(a => a.ProcedureId);
      return ap;
    }

    [HttpGet("GetProcedure/{id}", Name = "GetProcedure")]
    public Procedure GetProcedure(long id) => Procedure_repo.GetFirst(a => a.ProcedureId == id);

    [HttpPut("UpdateProcedure", Name = "UpdateProcedure")]
    [ValidateModelAttribute]
    public IActionResult UpdateProcedure([FromBody]Procedure model)
    {
      Procedure_repo.Update(model);
      return new OkObjectResult(new { ProcedureID = model.ProcedureId });
    }

    [HttpPost("AddProcedure", Name = "AddProcedure")]
    [ValidateModelAttribute]
    public IActionResult AddProcedure([FromBody]Procedure model)
    {
      model.CreatedAt = DateTime.Now;
      Procedure_repo.Add(model);
      return new OkObjectResult(new { ProcedureID = model.ProcedureId });
    }

    [HttpDelete("DeleteProcedure/{id}")]
    public IActionResult DeleteProcedure(long id)
    {
    Procedure Procedure = Procedure_repo.Find(id);
      if (Procedure == null)
      {
        return NotFound();
      }

      Procedure_repo.Delete(Procedure);
      return Ok();
    }

    #endregion
  }
}
