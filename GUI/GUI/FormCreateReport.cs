﻿using System;
using BUS;

namespace GUI
{
    public partial class FormCreateReport : MyForm
    {
        public FormCreateReport(FormMain parent)
        {
            InitializeComponent();
            SetDefaultValue(parent);
            AddEventHandler();
            this.bPrintTotalReport.Click += (s, e) =>
            {
                FormReportDoanhThu form = new FormReportDoanhThu(this.tbMonth.Text, this.tbYear.Text);
                BUS.Event.ShowFormDialog(form);
            };
            this.bPrintMedicalReport.Click += (s, e) =>
            {
                FormReportUsedMedicine form = new FormReportUsedMedicine(this.tbMonth.Text, this.tbYear.Text);
                BUS.Event.ShowFormDialog(form);
            };
        }

        protected override void AddEventHandler()
        {
            base.AddEventHandler();
            this.bCreateRevenueReport.Click += CreateRevenueReport;
            this.bCreateMedicineUseReport.Click += CreateMedicineUseReport;
            this.tbMonth.Leave += CheckMonth;
            this.tbYear.Leave += CheckYear;
            this.tbMonth.KeyPress += LockInputWord;
            this.tbYear.KeyPress += LockInputWord;
            this.bCancel.Click += CloseForm;
        }

        private void CheckYear(object sender, EventArgs e)
        {
            CreateReportHandler.CheckInput(sender, "Năm");
        }

        private void CheckMonth(object sender, EventArgs e)
        {
            try
            {
                CreateReportHandler.IsMonth(int.Parse(this.tbMonth.Text));
            }
            catch (Exception)
            {
                CreateReportHandler.IsMonth(0);
            }
        }

        private void SetDefaultValue(FormMain parent)
        {
            this.parent = parent;
            DateTime now = DateTime.Now;
            this.tbMonth.Text = now.AddMonths(-1).Month.ToString();
            this.tbYear.Text = now.Year.ToString();
        }

        private async void CreateMedicineUseReport(object sender, EventArgs e)
        {
            this.dgvMedicineUseReport =
                await new CreateMedicineUseReportHandler().CreateReport(GetMonth(), GetYear(),
                this.dgvMedicineUseReport);
        }

        private async void CreateRevenueReport(object sender, EventArgs e)
        {
            this.dgvRevenueReport = await new CreateRevenueReportHandler().CreateReport(GetMonth(),
            GetYear(), this.dgvRevenueReport);
        }

        private int GetYear()
        {
            try
            {
                return int.Parse(this.tbYear.Text);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        private int GetMonth()
        {
            try
            {
                return int.Parse(this.tbMonth.Text);
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}