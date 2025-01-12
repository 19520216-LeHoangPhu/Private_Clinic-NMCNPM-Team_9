﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormInputMedical : Form
    {
        FormMain parent;
        public FormInputMedical(FormMain parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.FormClosed += onFormClosed;
            this.bAddUnit.Click += (s, e) =>
            {
                FormAddMedicalUnit formAddMedicalUnit = new FormAddMedicalUnit();
                BUS.Event.ShowFormDialog(formAddMedicalUnit);
            };
            this.bEditMedical.Click += (s, e) =>
            {
                FormEditMedical formEditMedical = new FormEditMedical();
                BUS.Event.ShowFormDialog(formEditMedical);
            };
        }

        private void onFormClosed(object s, FormClosedEventArgs e)
        {
            BUS.Event.ShowFormEffect(parent, 1);
        }
    }
}
