﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ErpInfrastructure.Migrations
{
    public partial class update152 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hims_ThawAssessment_Hims_PatientClinicalRecord_PatientClinicalRecordId",
                table: "Hims_ThawAssessment");

            migrationBuilder.DropForeignKey(
                name: "FK_Hims_ThawAssessment_Hims_Tvopu_TvopuId",
                table: "Hims_ThawAssessment");

            migrationBuilder.DropIndex(
                name: "IX_Hims_ThawAssessment_PatientClinicalRecordId",
                table: "Hims_ThawAssessment");

            migrationBuilder.DropColumn(
                name: "PatientClinicalRecordId",
                table: "Hims_ThawAssessment");

            migrationBuilder.DropColumn(
                name: "FreeFreeze",
                table: "Hims_EmbryoFreezeUnthawed");

            migrationBuilder.RenameColumn(
                name: "TvopuId",
                table: "Hims_ThawAssessment",
                newName: "PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Hims_ThawAssessment_TvopuId",
                table: "Hims_ThawAssessment",
                newName: "IX_Hims_ThawAssessment_PatientId");

            migrationBuilder.AddColumn<long>(
                name: "CycleNo",
                table: "Hims_EmbryoFreezeUnthawed",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Hims_EmbryoFreezeUnthawed",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CycleNo",
                table: "Hims_EmbryoFreezeThawed",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Hims_EmbryoFreezeThawed",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Hims_ThawAssessment_Hims_Patient_PatientId",
                table: "Hims_ThawAssessment",
                column: "PatientId",
                principalTable: "Hims_Patient",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hims_ThawAssessment_Hims_Patient_PatientId",
                table: "Hims_ThawAssessment");

            migrationBuilder.DropColumn(
                name: "CycleNo",
                table: "Hims_EmbryoFreezeUnthawed");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Hims_EmbryoFreezeUnthawed");

            migrationBuilder.DropColumn(
                name: "CycleNo",
                table: "Hims_EmbryoFreezeThawed");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Hims_EmbryoFreezeThawed");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "Hims_ThawAssessment",
                newName: "TvopuId");

            migrationBuilder.RenameIndex(
                name: "IX_Hims_ThawAssessment_PatientId",
                table: "Hims_ThawAssessment",
                newName: "IX_Hims_ThawAssessment_TvopuId");

            migrationBuilder.AddColumn<long>(
                name: "PatientClinicalRecordId",
                table: "Hims_ThawAssessment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FreeFreeze",
                table: "Hims_EmbryoFreezeUnthawed",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hims_ThawAssessment_PatientClinicalRecordId",
                table: "Hims_ThawAssessment",
                column: "PatientClinicalRecordId",
                unique: true,
                filter: "[PatientClinicalRecordId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Hims_ThawAssessment_Hims_PatientClinicalRecord_PatientClinicalRecordId",
                table: "Hims_ThawAssessment",
                column: "PatientClinicalRecordId",
                principalTable: "Hims_PatientClinicalRecord",
                principalColumn: "PatientClinicalRecordId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hims_ThawAssessment_Hims_Tvopu_TvopuId",
                table: "Hims_ThawAssessment",
                column: "TvopuId",
                principalTable: "Hims_Tvopu",
                principalColumn: "TvopuId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
