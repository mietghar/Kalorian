using Kalorian.DAL.Entity;
using Kalorian.Helper.Themes;
using Kalorian.Main.Interface;
using Kalorian.Main.Presenter;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Kalorian.Common.Collections;

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
        }

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
            this.BackColor = Cl_BaseColor.StandardBackground;
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
        public int Sex {
            get { return (int)frintSex.SelectedValue; }
            set { frintSex.SelectedValue = value; }
        }
        public int UserId => vrcUser.Id;
        public bool IsNewUser { get; set; }

        private void btnSaveConfiguration_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsNewUser)
                {
                    vrcPresenter.AddUserAdditionalDataById(vrcUser.Id);
                }
                else
                {
                    vrcPresenter.EditUserAdditionalDataById(vrcUser.Id);
                }
            }
            catch(SqlException vrlException)
            {
                MessageBox.Show("Nie można się połączyć z bazą danych.");
            }
            catch(Exception)
            {

            }
        }
    }
}
