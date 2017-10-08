using Kalorian.DAL.Entity;
using Kalorian.Helper.Themes;
using Kalorian.Main.Interface;
using Kalorian.Main.Presenter;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Kalorian.Common.Collections;
using Kalorian.DAL.ViewModel;
using Kalorian.Product.View;
using Kalorian.Meal.View;

namespace Kalorian.Main.View
{
    public partial class Frm_Main : Form, I_MainView
    {
        private readonly ClE_User vrcUser;
        private readonly ClP_Main vrcPresenter;

        public Frm_Main(ClE_User vrpUser)
        {
            vrcUser = vrpUser;
            vrcPresenter = new ClP_Main(this);
            InitializeComponent();
            InitializeDataSource();
            InitializeTheme();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            this.frintAge.ValueChanged += CalculateBMROnValueChanged;
            this.frintHeight.ValueChanged += CalculateBMROnValueChanged;
            this.frintSex.SelectedValueChanged += CalculateBMROnValueChanged;
            this.frintWeight.ValueChanged += CalculateBMROnValueChanged;
        }        

        private void CalculateBMROnValueChanged(object sender, EventArgs e) =>
            this.BMR = vrcPresenter.CalculateAndSetUserBMR(vrcUserAdditionalData);

        private void InitializeDataSource()
        {
            List<Cl_SexCollection> _sexlist = new List<Cl_SexCollection> { new Cl_SexCollection("Mężczyzna", 1), new Cl_SexCollection("Kobieta", 2) };
            MainBindingSource.DataSource = _sexlist;
            frintSex.DataSource = MainBindingSource.DataSource;
            frintSex.DisplayMember = "SexName";
            frintSex.ValueMember = "Id";
        }

        private void InitializeTheme()
        {
            this.BackColor = Cl_BaseColor.LightBackground;
            this.frMenu.BackColor = Cl_BaseColor.LightBackground;
        }

        private void Frm_Main_Load(object sender, System.EventArgs e)
        {
            LoadBasicUserDataToControls();
            vrcPresenter.LoadUserAdditionalData();
        }

        private void LoadBasicUserDataToControls()
        {
            lbltxtDayTime.Text = DateTime.Now.Date.ToString("yyyy.MM.dd");
            lbltxtUserName.Text = vrcUser.Name;
        }

        public int Age
        {
            get { return (int)frintAge.Value; }
            set { frintAge.Value = value; }
        }
        public decimal Weight
        {
            get { return (int)frintWeight.Value; }
            set { frintWeight.Value = value; }
        }
        public int Sex
        {
            get { return (int)frintSex.SelectedValue; }
            set { frintSex.SelectedValue = value; }
        }
        public decimal HeightInCm
        {
            get { return (int)frintHeight.Value; }
            set { frintHeight.Value = value; }
        }
        public int UserId => vrcUser.Id;
        public bool IsNewUser { get; set; }
        public decimal BMR
        {
            get { return Convert.ToDecimal(lbltxtBMR.Text); }
            set { lbltxtBMR.Text = value.ToString(); }
        }
        private Cl_UserViewModel vrcUserAdditionalData
            => new Cl_UserViewModel
            {
                Age = this.Age,
                HeightInCm = this.HeightInCm,
                Sex = this.Sex,
                Weight = this.Weight
            };

        private void btnSaveConfiguration_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsNewUser)
                {
                    if (vrcPresenter.AddUserAdditionalDataById(vrcUser.Id))
                    {
                        MessageBox.Show("Poprawnie dodano dane użytkownika");
                        IsNewUser = false;
                    }

                }
                else
                {
                    if (vrcPresenter.EditUserAdditionalDataById(vrcUser.Id))
                    {
                        MessageBox.Show("Poprawnie edytowano dane użytkownika");
                    }
                }
            }
            catch (SqlException vrlException)
            {
                MessageBox.Show("Nie można się połączyć z bazą danych.");
            }
            catch (Exception)
            {

            }
        }

        private void frAddMenuProduct_Click(object sender, EventArgs e)
        {
            using(Frm_Product ProductForm = new Frm_Product())
            {
                try
                {
                    ProductForm.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Wystąpił problem podczas dodawania produktu");
                }
            }
        }

        private void frAddMenuMeal_Click(object sender, EventArgs e)
        {
            using (Frm_Meal MealForm = new Frm_Meal())
            {
                try
                {
                    MealForm.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Wystąpił problem podczas dodawania posiłku");
                }
            }
        }
    }
}
