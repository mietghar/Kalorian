namespace Kalorian.Meal.View
{
    partial class Frm_Meal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frintName = new System.Windows.Forms.ComboBox();
            this.bsProducts = new System.Windows.Forms.BindingSource(this.components);
            this.frdatDate = new System.Windows.Forms.DateTimePicker();
            this.frintGramm = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblGramm = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnSave = new Kalorian.Helper.Themes.Buttons.Cl_AddButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Anuluj";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(0, 172);
            this.panel1.Controls.SetChildIndex(this.btnSave, 0);
            this.panel1.Controls.SetChildIndex(this.btnClose, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frintName);
            this.groupBox1.Controls.Add(this.frdatDate);
            this.groupBox1.Controls.Add(this.frintGramm);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblGramm);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj posiłek";
            // 
            // frintName
            // 
            this.frintName.DataSource = this.bsProducts;
            this.frintName.DisplayMember = "ProductName";
            this.frintName.FormattingEnabled = true;
            this.frintName.Location = new System.Drawing.Point(69, 27);
            this.frintName.Name = "frintName";
            this.frintName.Size = new System.Drawing.Size(165, 21);
            this.frintName.TabIndex = 7;
            this.frintName.ValueMember = "Id";
            // 
            // bsProducts
            // 
            this.bsProducts.DataSource = typeof(Kalorian.DAL.Entity.ProductDO);
            // 
            // frdatDate
            // 
            this.frdatDate.Location = new System.Drawing.Point(69, 90);
            this.frdatDate.Name = "frdatDate";
            this.frdatDate.Size = new System.Drawing.Size(165, 20);
            this.frdatDate.TabIndex = 6;
            // 
            // frintGramm
            // 
            this.frintGramm.Location = new System.Drawing.Point(69, 60);
            this.frintGramm.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.frintGramm.Name = "frintGramm";
            this.frintGramm.Size = new System.Drawing.Size(165, 20);
            this.frintGramm.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 96);
            this.lblDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Data:";
            // 
            // lblGramm
            // 
            this.lblGramm.AutoSize = true;
            this.lblGramm.Location = new System.Drawing.Point(20, 63);
            this.lblGramm.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblGramm.Name = "lblGramm";
            this.lblGramm.Size = new System.Drawing.Size(30, 13);
            this.lblGramm.TabIndex = 1;
            this.lblGramm.Text = "Ile g:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(20, 30);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(43, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Nazwa:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(242)))), ((int)(((byte)(135)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(20, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Dodaj";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Frm_Meal
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(300, 212);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 212);
            this.Name = "Frm_Meal";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Nowy produkt";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblGramm;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox frintGramm;
        private Helper.Themes.Buttons.Cl_AddButton btnSave;
        private System.Windows.Forms.DateTimePicker frdatDate;
        private System.Windows.Forms.ComboBox frintName;
        private System.Windows.Forms.BindingSource bsProducts;
    }
}