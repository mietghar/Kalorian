using Kalorian.DAL.Entity;
using Kalorian.Helper.Themes;
using Kalorian.Main.Interface;
using Kalorian.Main.Presenter;
using System.Windows.Forms;
using System;
using Kalorian.DAL.Enum;
using System.Data.SqlClient;

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
            InitializeTheme();
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
            lbltxtDayTime.Text = DateTime.Now.Date.ToString();
            lbltxtUserName.Text = vrcUser.Name;
        }

        public int Age
        {
            get { return (int)frintAge.Value; }
            set { frintAge.Value = value; }
        }
        public E_Sex Sex { get; set; }
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
