using Kalorian.Helper.Themes;
using Kalorian.Helper.Themes.Forms;
using Kalorian.Meal.Interface;
using Kalorian.Meal.Presenter;
using System;
using System.Windows.Forms;

namespace Kalorian.Meal.View
{
    public partial class Frm_Meal : Frm_BaseSimpleForm, I_MealView
    {
        private readonly new ClP_Meal Presenter;

        public Frm_Meal()
        {
            Presenter = new ClP_Meal(this);
            InitializeComponent();
            InitializeTheme();
            InitializeControls();
        }

        private void InitializeControls()
        {
            frdatDate.Value = DateTime.Now;
            frintGramm.Text = "0";
            LoadProductList();
        }

        private void LoadProductList()
        {
            if (Presenter == null)
                this.Close();
            var ProductList = Presenter.PopulateProductList();
            if (ProductList == null)
                this.Close();
            else
                bsProducts.DataSource = ProductList;
        }

        public DateTime MealTimeStamp => (this.frdatDate.Value != null) ? frdatDate.Value : DateTime.Now;

        public int ProductId => Convert.ToInt32(this.frintName.SelectedValue);

        public decimal Weight => Convert.ToDecimal(this.frintGramm.Text);

        private void InitializeTheme() =>
            this.BackColor = Cl_BaseColor.StandardBackGround;

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (Presenter.SaveNewMeal())
            {
                MessageBox.Show("Produkt dodany prawidłowo");
                this.Close();
            }
            else
                MessageBox.Show("Nie udało się dodać produktu");
        }
    }
}
