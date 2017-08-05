namespace Kalorian.Main.View
{
    partial class Frm_Main
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
            this.frintWeight = new System.Windows.Forms.NumericUpDown();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnSaveConfiguration = new Kalorian.Helper.Themes.Buttons.Cl_AddButton();
            this.frintSex = new System.Windows.Forms.ComboBox();
            this.lbltxtCalories = new System.Windows.Forms.Label();
            this.lblCaloriesPerDay = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.frintAge = new System.Windows.Forms.NumericUpDown();
            this.lblAge = new System.Windows.Forms.Label();
            this.lbltxtDayTime = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lbltxtUserName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.MainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frintWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frintAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.frintWeight);
            this.groupBox1.Controls.Add(this.lblWeight);
            this.groupBox1.Controls.Add(this.btnSaveConfiguration);
            this.groupBox1.Controls.Add(this.frintSex);
            this.groupBox1.Controls.Add(this.lbltxtCalories);
            this.groupBox1.Controls.Add(this.lblCaloriesPerDay);
            this.groupBox1.Controls.Add(this.lblSex);
            this.groupBox1.Controls.Add(this.frintAge);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.lbltxtDayTime);
            this.groupBox1.Controls.Add(this.lblDay);
            this.groupBox1.Controls.Add(this.lbltxtUserName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podsumowanie";
            // 
            // frintWeight
            // 
            this.frintWeight.Location = new System.Drawing.Point(400, 88);
            this.frintWeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.frintWeight.Name = "frintWeight";
            this.frintWeight.Size = new System.Drawing.Size(72, 20);
            this.frintWeight.TabIndex = 14;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(329, 90);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(65, 13);
            this.lblWeight.TabIndex = 13;
            this.lblWeight.Text = "Waga w kg:";
            // 
            // btnSaveConfiguration
            // 
            this.btnSaveConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(242)))), ((int)(((byte)(135)))));
            this.btnSaveConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConfiguration.Location = new System.Drawing.Point(689, 25);
            this.btnSaveConfiguration.Name = "btnSaveConfiguration";
            this.btnSaveConfiguration.Size = new System.Drawing.Size(75, 23);
            this.btnSaveConfiguration.TabIndex = 12;
            this.btnSaveConfiguration.Text = "Zapisz";
            this.btnSaveConfiguration.UseVisualStyleBackColor = false;
            this.btnSaveConfiguration.Click += new System.EventHandler(this.btnSaveConfiguration_Click);
            // 
            // frintSex
            // 
            this.frintSex.DisplayMember = "Sex2";
            this.frintSex.FormattingEnabled = true;
            this.frintSex.Location = new System.Drawing.Point(400, 57);
            this.frintSex.Name = "frintSex";
            this.frintSex.Size = new System.Drawing.Size(121, 21);
            this.frintSex.TabIndex = 10;
            this.frintSex.ValueMember = "Sex2";
            // 
            // lbltxtCalories
            // 
            this.lbltxtCalories.AutoSize = true;
            this.lbltxtCalories.Location = new System.Drawing.Point(131, 90);
            this.lbltxtCalories.Name = "lbltxtCalories";
            this.lbltxtCalories.Size = new System.Drawing.Size(82, 13);
            this.lbltxtCalories.TabIndex = 9;
            this.lbltxtCalories.Text = "Kalorie na dzień";
            // 
            // lblCaloriesPerDay
            // 
            this.lblCaloriesPerDay.AutoSize = true;
            this.lblCaloriesPerDay.Location = new System.Drawing.Point(20, 90);
            this.lblCaloriesPerDay.Name = "lblCaloriesPerDay";
            this.lblCaloriesPerDay.Size = new System.Drawing.Size(105, 13);
            this.lblCaloriesPerDay.TabIndex = 8;
            this.lblCaloriesPerDay.Text = "Ilość kalorii na dzień:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(327, 60);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(33, 13);
            this.lblSex.TabIndex = 7;
            this.lblSex.Text = "Płeć:";
            // 
            // frintAge
            // 
            this.frintAge.Location = new System.Drawing.Point(400, 28);
            this.frintAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.frintAge.Name = "frintAge";
            this.frintAge.Size = new System.Drawing.Size(72, 20);
            this.frintAge.TabIndex = 6;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(327, 30);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(35, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Wiek:";
            // 
            // lbltxtDayTime
            // 
            this.lbltxtDayTime.AutoSize = true;
            this.lbltxtDayTime.Location = new System.Drawing.Point(131, 60);
            this.lbltxtDayTime.Name = "lbltxtDayTime";
            this.lbltxtDayTime.Size = new System.Drawing.Size(73, 13);
            this.lbltxtDayTime.TabIndex = 3;
            this.lbltxtDayTime.Text = "Aktualna data";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(20, 60);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(37, 13);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "Dzień:";
            // 
            // lbltxtUserName
            // 
            this.lbltxtUserName.AutoSize = true;
            this.lbltxtUserName.Location = new System.Drawing.Point(131, 30);
            this.lbltxtUserName.Name = "lbltxtUserName";
            this.lbltxtUserName.Size = new System.Drawing.Size(102, 13);
            this.lbltxtUserName.TabIndex = 1;
            this.lbltxtUserName.Text = "Nazwa użytkownika";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Użytkownik:";
            // 
            // MainBindingSource
            // 
            this.MainBindingSource.DataSource = typeof(Kalorian.Common.Collections.Cl_SexCollection);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Frm_Main";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.ShowIcon = false;
            this.Text = "Kalorian";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frintWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frintAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbltxtDayTime;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lbltxtUserName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox frintSex;
        private System.Windows.Forms.Label lbltxtCalories;
        private System.Windows.Forms.Label lblCaloriesPerDay;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.NumericUpDown frintAge;
        private System.Windows.Forms.Label lblAge;
        private Helper.Themes.Buttons.Cl_AddButton btnSaveConfiguration;
        private System.Windows.Forms.NumericUpDown frintWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.BindingSource MainBindingSource;
    }
}