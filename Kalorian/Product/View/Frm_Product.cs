﻿using Kalorian.Helper.Themes;
using Kalorian.Helper.Themes.Forms;
using Kalorian.Product.Interface;
using Kalorian.Product.Presenter;
using System;
using System.Windows.Forms;

namespace Kalorian.Product.View
{
    public partial class Frm_Product : Frm_BaseSimpleForm, I_ProductView
    {
        private readonly new ClP_Product vrcPresenter;

        public Frm_Product()
        {
            InitializeComponent();
            InitializeTheme();
            vrcPresenter = new ClP_Product(this);
        }

        private void InitializeTheme()
        {
            this.BackColor = Cl_BaseColor.StandardBackGround;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if(vrcPresenter.SaveNewProduct())
            {
                MessageBox.Show("Produkt dodany prawidłowo");
                this.Close();
            }
            else
                MessageBox.Show("Nie udało się dodać produktu");
        }

        new public string ProductName => frtxtProductName.Text;
        public decimal KcalPerGramm => Convert.ToDecimal(frdecKcal.Text);
        public decimal Fat => Convert.ToDecimal(frdecFat.Text);
        public decimal Carbo => Convert.ToDecimal(frdecCarbo.Text);
        public decimal Whey => Convert.ToDecimal(frdecWhey.Text);
        public decimal Salt => Convert.ToDecimal(frdecSalt.Text);
    }
}
