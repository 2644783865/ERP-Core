﻿namespace ReportingService.Reports.Pharmacy
{
    partial class TotalSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalSales));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.vendorLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.vendorLogo2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.vendorTable = new DevExpress.XtraReports.UI.XRTable();
            this.vendorTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.vendorName = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorPhone = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorEmail = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.vendorAddress = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorEmptyCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorWebsite = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table4 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.FromDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.ToDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vendorTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.vendorLogo});
            this.TopMargin.HeightF = 113F;
            this.TopMargin.Name = "TopMargin";
            // 
            // vendorLogo
            // 
            this.vendorLogo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopLeft;
            this.vendorLogo.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("vendorLogo.ImageSource"));
            this.vendorLogo.LocationFloat = new DevExpress.Utils.PointFloat(10F, 10F);
            this.vendorLogo.Name = "vendorLogo";
            this.vendorLogo.SizeF = new System.Drawing.SizeF(195.1282F, 80.1281F);
            this.vendorLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.vendorLogo.StylePriority.UseBorderColor = false;
            this.vendorLogo.StylePriority.UseBorders = false;
            this.vendorLogo.StylePriority.UsePadding = false;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.vendorLogo2,
            this.vendorTable});
            this.BottomMargin.HeightF = 113.5029F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // vendorLogo2
            // 
            this.vendorLogo2.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopLeft;
            this.vendorLogo2.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("vendorLogo2.ImageSource"));
            this.vendorLogo2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 20F);
            this.vendorLogo2.Name = "vendorLogo2";
            this.vendorLogo2.SizeF = new System.Drawing.SizeF(118.3333F, 55.83334F);
            this.vendorLogo2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.vendorLogo2.StylePriority.UseBorderColor = false;
            this.vendorLogo2.StylePriority.UseBorders = false;
            this.vendorLogo2.StylePriority.UsePadding = false;
            // 
            // vendorTable
            // 
            this.vendorTable.BorderColor = System.Drawing.Color.Gray;
            this.vendorTable.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.vendorTable.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.vendorTable.LocationFloat = new DevExpress.Utils.PointFloat(171.4388F, 20F);
            this.vendorTable.Name = "vendorTable";
            this.vendorTable.Padding = new DevExpress.XtraPrinting.PaddingInfo(12, 0, 0, 0, 100F);
            this.vendorTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.vendorTableRow1,
            this.vendorTableRow2});
            this.vendorTable.SizeF = new System.Drawing.SizeF(623.5612F, 80F);
            this.vendorTable.StylePriority.UseBorderColor = false;
            this.vendorTable.StylePriority.UseBorders = false;
            this.vendorTable.StylePriority.UseFont = false;
            this.vendorTable.StylePriority.UsePadding = false;
            // 
            // vendorTableRow1
            // 
            this.vendorTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.vendorName,
            this.vendorPhone,
            this.vendorEmail});
            this.vendorTableRow1.Name = "vendorTableRow1";
            this.vendorTableRow1.Weight = 1.0000282429281655D;
            // 
            // vendorName
            // 
            this.vendorName.CanShrink = true;
            this.vendorName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.vendorName.Name = "vendorName";
            this.vendorName.StylePriority.UseFont = false;
            this.vendorName.StylePriority.UseTextAlignment = false;
            this.vendorName.Text = "Address";
            this.vendorName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.vendorName.Weight = 3.2160869766043354D;
            // 
            // vendorPhone
            // 
            this.vendorPhone.CanShrink = true;
            this.vendorPhone.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.vendorPhone.Name = "vendorPhone";
            this.vendorPhone.StylePriority.UseFont = false;
            this.vendorPhone.StylePriority.UseTextAlignment = false;
            this.vendorPhone.Text = "Phone";
            this.vendorPhone.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.vendorPhone.Weight = 2.3857055240558696D;
            // 
            // vendorEmail
            // 
            this.vendorEmail.CanShrink = true;
            this.vendorEmail.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.vendorEmail.Name = "vendorEmail";
            this.vendorEmail.StylePriority.UseFont = false;
            this.vendorEmail.StylePriority.UseTextAlignment = false;
            this.vendorEmail.Text = "Fax";
            this.vendorEmail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.vendorEmail.Weight = 2.8008962503301023D;
            // 
            // vendorTableRow2
            // 
            this.vendorTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.vendorAddress,
            this.vendorEmptyCell,
            this.vendorWebsite});
            this.vendorTableRow2.Name = "vendorTableRow2";
            this.vendorTableRow2.Weight = 1.57413724941719D;
            // 
            // vendorAddress
            // 
            this.vendorAddress.CanShrink = true;
            this.vendorAddress.Multiline = true;
            this.vendorAddress.Name = "vendorAddress";
            this.vendorAddress.StylePriority.UseBorders = false;
            this.vendorAddress.StylePriority.UseTextAlignment = false;
            this.vendorAddress.Text = "F-6/1, Block-8, KDA Scheme No.5,\r\nClifton, Karachi-75600";
            this.vendorAddress.Weight = 3.2160869766043354D;
            // 
            // vendorEmptyCell
            // 
            this.vendorEmptyCell.CanShrink = true;
            this.vendorEmptyCell.Multiline = true;
            this.vendorEmptyCell.Name = "vendorEmptyCell";
            this.vendorEmptyCell.Text = "92 21 35361846\r\n          35361397 \r\n          35810049";
            this.vendorEmptyCell.Weight = 2.3857055240558696D;
            // 
            // vendorWebsite
            // 
            this.vendorWebsite.CanShrink = true;
            this.vendorWebsite.Name = "vendorWebsite";
            this.vendorWebsite.Text = "021-35361397";
            this.vendorWebsite.Weight = 2.8008962503301023D;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.xrLabel7,
            this.table2,
            this.table4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.xrTable3});
            this.Detail.HeightF = 185.9971F;
            this.Detail.Name = "Detail";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(588.856F, 39.83334F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(85.12818F, 23F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "To Date:";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel7
            // 
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?ToDate")});
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(673.9842F, 39.83334F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "15-08-2018";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel7.TextFormatString = "{0:dd-MMM-yy}";
            // 
            // table2
            // 
            this.table2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.table2.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 75.55214F);
            this.table2.Name = "table2";
            this.table2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(796F, 26.66669F);
            this.table2.StylePriority.UseBackColor = false;
            this.table2.StylePriority.UseFont = false;
            this.table2.StylePriority.UsePadding = false;
            this.table2.StylePriority.UseTextAlignment = false;
            this.table2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // tableRow2
            // 
            this.tableRow2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell6,
            this.tableCell12,
            this.xrTableCell4,
            this.xrTableCell3,
            this.xrTableCell2,
            this.tableCell7,
            this.tableCell1,
            this.tableCell8});
            this.tableRow2.ForeColor = System.Drawing.Color.White;
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.StylePriority.UseBackColor = false;
            this.tableRow2.StylePriority.UseForeColor = false;
            this.tableRow2.Weight = 1D;
            // 
            // tableCell6
            // 
            this.tableCell6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.tableCell6.Multiline = true;
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell6.StylePriority.UseBackColor = false;
            this.tableCell6.StylePriority.UseBorders = false;
            this.tableCell6.StylePriority.UseFont = false;
            this.tableCell6.Text = "Date";
            this.tableCell6.Weight = 1.0334495207889443D;
            // 
            // tableCell12
            // 
            this.tableCell12.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell12.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.tableCell12.Multiline = true;
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell12.StylePriority.UseBackColor = false;
            this.tableCell12.StylePriority.UseBorders = false;
            this.tableCell12.StylePriority.UseFont = false;
            this.tableCell12.StylePriority.UsePadding = false;
            this.tableCell12.StylePriority.UseTextAlignment = false;
            this.tableCell12.Text = "Description";
            this.tableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell12.Weight = 3.1668674890878705D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell4.StylePriority.UseBackColor = false;
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Issue to (File # / Dept. / Pvt.)";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell4.Weight = 2.7606061918200688D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell3.StylePriority.UseBackColor = false;
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "Comp. #";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell3.Weight = 0.96012933929320654D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell2.StylePriority.UseBackColor = false;
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "Slip #";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell2.Weight = 0.74400176204364743D;
            // 
            // tableCell7
            // 
            this.tableCell7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.tableCell7.Multiline = true;
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell7.StylePriority.UseBackColor = false;
            this.tableCell7.StylePriority.UseBorders = false;
            this.tableCell7.StylePriority.UseFont = false;
            this.tableCell7.StylePriority.UsePadding = false;
            this.tableCell7.StylePriority.UseTextAlignment = false;
            this.tableCell7.Text = "Quantity";
            this.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell7.Weight = 0.94301923629865037D;
            // 
            // tableCell1
            // 
            this.tableCell1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.tableCell1.Multiline = true;
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell1.StylePriority.UseBackColor = false;
            this.tableCell1.StylePriority.UseBorders = false;
            this.tableCell1.StylePriority.UseFont = false;
            this.tableCell1.StylePriority.UsePadding = false;
            this.tableCell1.StylePriority.UseTextAlignment = false;
            this.tableCell1.Text = "Per Unit Rate";
            this.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell1.Weight = 1.3370995547104614D;
            // 
            // tableCell8
            // 
            this.tableCell8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.tableCell8.Multiline = true;
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell8.StylePriority.UseBackColor = false;
            this.tableCell8.StylePriority.UseBorders = false;
            this.tableCell8.StylePriority.UseFont = false;
            this.tableCell8.StylePriority.UsePadding = false;
            this.tableCell8.StylePriority.UseTextAlignment = false;
            this.tableCell8.Text = "Amount";
            this.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell8.Weight = 1.1040136537854792D;
            // 
            // table4
            // 
            this.table4.BackColor = System.Drawing.Color.Transparent;
            this.table4.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.table4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 102.2188F);
            this.table4.Name = "table4";
            this.table4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.table4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow4});
            this.table4.SizeF = new System.Drawing.SizeF(796F, 26.95852F);
            this.table4.StylePriority.UseBackColor = false;
            this.table4.StylePriority.UseFont = false;
            this.table4.StylePriority.UsePadding = false;
            this.table4.StylePriority.UseTextAlignment = false;
            this.table4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // tableRow4
            // 
            this.tableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell33,
            this.tableCell34,
            this.tableCell35,
            this.tableCell36,
            this.xrTableCell7,
            this.xrTableCell5,
            this.xrTableCell6,
            this.tableCell16});
            this.tableRow4.Name = "tableRow4";
            this.tableRow4.Weight = 1D;
            // 
            // tableCell33
            // 
            this.tableCell33.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell33.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Date]")});
            this.tableCell33.Multiline = true;
            this.tableCell33.Name = "tableCell33";
            this.tableCell33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell33.StylePriority.UseBorders = false;
            this.tableCell33.Text = "5";
            this.tableCell33.TextFormatString = "{0:dd-MMM-yy}";
            this.tableCell33.Weight = 0.92484819650430672D;
            // 
            // tableCell34
            // 
            this.tableCell34.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell34.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")});
            this.tableCell34.Multiline = true;
            this.tableCell34.Name = "tableCell34";
            this.tableCell34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell34.StylePriority.UseBorders = false;
            this.tableCell34.StylePriority.UseTextAlignment = false;
            this.tableCell34.Text = "News paper";
            this.tableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell34.Weight = 2.83407313993921D;
            // 
            // tableCell35
            // 
            this.tableCell35.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell35.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Issued To]")});
            this.tableCell35.Multiline = true;
            this.tableCell35.Name = "tableCell35";
            this.tableCell35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell35.StylePriority.UseBorders = false;
            this.tableCell35.StylePriority.UsePadding = false;
            this.tableCell35.StylePriority.UseTextAlignment = false;
            this.tableCell35.Text = "NWP";
            this.tableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell35.Weight = 2.4705052788398638D;
            // 
            // tableCell36
            // 
            this.tableCell36.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell36.Multiline = true;
            this.tableCell36.Name = "tableCell36";
            this.tableCell36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell36.StylePriority.UseBorders = false;
            this.tableCell36.StylePriority.UsePadding = false;
            this.tableCell36.StylePriority.UseTextAlignment = false;
            this.tableCell36.Text = "0";
            this.tableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell36.Weight = 0.859232959786705D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Slip Number]")});
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.StylePriority.UsePadding = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "xrTableCell7";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell7.Weight = 0.66581642374075367D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")});
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "xrTableCell5";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell5.Weight = 0.84392163302448342D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Per Unit Rate]")});
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "xrTableCell6";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell6.Weight = 1.1965898854498647D;
            // 
            // tableCell16
            // 
            this.tableCell16.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Amount]")});
            this.tableCell16.Multiline = true;
            this.tableCell16.Name = "tableCell16";
            this.tableCell16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell16.StylePriority.UseBorders = false;
            this.tableCell16.StylePriority.UsePadding = false;
            this.tableCell16.StylePriority.UseTextAlignment = false;
            this.tableCell16.Text = "0";
            this.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell16.Weight = 0.98799696133673365D;
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?FromDate")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(95.1282F, 39.83335F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "15-08-2018";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel3.TextFormatString = "{0:dd-MMM-yy}";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10F, 39.83334F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(85.12818F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "From Date:";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel1
            // 
            this.xrLabel1.AutoWidth = true;
            this.xrLabel1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(176.541F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(411.7578F, 28.76924F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "TOTAL SALES";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTable3
            // 
            this.xrTable3.BackColor = System.Drawing.Color.PapayaWhip;
            this.xrTable3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 145F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.SizeF = new System.Drawing.SizeF(794.9999F, 26.95852F);
            this.xrTable3.StylePriority.UseBackColor = false;
            this.xrTable3.StylePriority.UseFont = false;
            this.xrTable3.StylePriority.UsePadding = false;
            this.xrTable3.StylePriority.UseTextAlignment = false;
            this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell17,
            this.xrTableCell19});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell17.Multiline = true;
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell17.StylePriority.UseBorders = false;
            this.xrTableCell17.StylePriority.UsePadding = false;
            this.xrTableCell17.StylePriority.UseTextAlignment = false;
            this.xrTableCell17.Text = "Grand Total :";
            this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell17.Weight = 4.9263972368789259D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Amount])")});
            this.xrTableCell19.Multiline = true;
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell19.StylePriority.UseBorders = false;
            this.xrTableCell19.StylePriority.UsePadding = false;
            this.xrTableCell19.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell19.Summary = xrSummary1;
            this.xrTableCell19.Text = "3300.00";
            this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell19.Weight = 1.2438834711311257D;
            // 
            // FromDate
            // 
            this.FromDate.Description = "FromDate";
            this.FromDate.Name = "FromDate";
            this.FromDate.Type = typeof(System.DateTime);
            this.FromDate.ValueInfo = "2018-12-01";
            // 
            // ToDate
            // 
            this.ToDate.Description = "ToDate";
            this.ToDate.Name = "ToDate";
            this.ToDate.Type = typeof(System.DateTime);
            this.ToDate.ValueInfo = "2018-12-01";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ERPDB_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "Pharmacy_TotalSales";
            queryParameter1.Name = "@FromDate";
            queryParameter1.Type = typeof(System.DateTime);
            queryParameter1.ValueInfo = "2018-12-01";
            queryParameter2.Name = "@ToDate";
            queryParameter2.Type = typeof(System.DateTime);
            queryParameter2.ValueInfo = "2018-12-31";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.StoredProcName = "Pharmacy_TotalSales";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // TotalSales
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Pharmacy_TotalSales";
            this.DataSource = this.sqlDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(26, 28, 113, 114);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FromDate,
            this.ToDate});
            this.Version = "18.2";
            ((System.ComponentModel.ISupportInitialize)(this.vendorTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRPictureBox vendorLogo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell6;
        private DevExpress.XtraReports.UI.XRTableCell tableCell12;
        private DevExpress.XtraReports.UI.XRTableCell tableCell7;
        private DevExpress.XtraReports.UI.XRTableCell tableCell1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell8;
        private DevExpress.XtraReports.UI.XRTable table4;
        private DevExpress.XtraReports.UI.XRTableRow tableRow4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell33;
        private DevExpress.XtraReports.UI.XRTableCell tableCell34;
        private DevExpress.XtraReports.UI.XRTableCell tableCell35;
        private DevExpress.XtraReports.UI.XRTableCell tableCell36;
        private DevExpress.XtraReports.UI.XRTableCell tableCell16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell17;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell19;
        private DevExpress.XtraReports.UI.XRPictureBox vendorLogo2;
        private DevExpress.XtraReports.UI.XRTable vendorTable;
        private DevExpress.XtraReports.UI.XRTableRow vendorTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell vendorName;
        private DevExpress.XtraReports.UI.XRTableCell vendorPhone;
        private DevExpress.XtraReports.UI.XRTableCell vendorEmail;
        private DevExpress.XtraReports.UI.XRTableRow vendorTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell vendorAddress;
        private DevExpress.XtraReports.UI.XRTableCell vendorEmptyCell;
        private DevExpress.XtraReports.UI.XRTableCell vendorWebsite;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.Parameters.Parameter FromDate;
        private DevExpress.XtraReports.Parameters.Parameter ToDate;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}
