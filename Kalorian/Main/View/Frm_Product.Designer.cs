namespace Kalorian.Main.View
{
    partial class Frm_Product
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frdecSalt = new System.Windows.Forms.TextBox();
            this.frdecWhey = new System.Windows.Forms.TextBox();
            this.frtxtProductName = new System.Windows.Forms.TextBox();
            this.frdecKcal = new System.Windows.Forms.TextBox();
            this.frdecFat = new System.Windows.Forms.TextBox();
            this.frdecCarbo = new System.Windows.Forms.TextBox();
            this.lblSalt = new System.Windows.Forms.Label();
            this.lblWhey = new System.Windows.Forms.Label();
            this.lblCarbo = new System.Windows.Forms.Label();
            this.lblFat = new System.Windows.Forms.Label();
            this.lblKcalPerGramm = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnSave = new Kalorian.Helper.Themes.Buttons.Cl_AddButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 271);
            this.panel1.Controls.SetChildIndex(this.btnSave, 0);
            this.panel1.Controls.SetChildIndex(this.btnClose, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frdecSalt);
            this.groupBox1.Controls.Add(this.frdecWhey);
            this.groupBox1.Controls.Add(this.frtxtProductName);
            this.groupBox1.Controls.Add(this.frdecKcal);
            this.groupBox1.Controls.Add(this.frdecFat);
            this.groupBox1.Controls.Add(this.frdecCarbo);
            this.groupBox1.Controls.Add(this.lblSalt);
            this.groupBox1.Controls.Add(this.lblWhey);
            this.groupBox1.Controls.Add(this.lblCarbo);
            this.groupBox1.Controls.Add(this.lblFat);
            this.groupBox1.Controls.Add(this.lblKcalPerGramm);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj produkt";
            // 
            // frdecSalt
            // 
            this.frdecSalt.Location = new System.Drawing.Point(104, 192);
            this.frdecSalt.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.frdecSalt.Name = "frdecSalt";
            this.frdecSalt.Size = new System.Drawing.Size(130, 20);
            this.frdecSalt.TabIndex = 5;
            // 
            // frdecWhey
            // 
            this.frdecWhey.Location = new System.Drawing.Point(104, 159);
            this.frdecWhey.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.frdecWhey.Name = "frdecWhey";
            this.frdecWhey.Size = new System.Drawing.Size(130, 20);
            this.frdecWhey.TabIndex = 4;
            // 
            // frdecProductName
            // 
            this.frtxtProductName.Location = new System.Drawing.Point(104, 23);
            this.frtxtProductName.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.frtxtProductName.Name = "frdecProductName";
            this.frtxtProductName.Size = new System.Drawing.Size(130, 20);
            this.frtxtProductName.TabIndex = 0;
            // 
            // frdecKcal
            // 
            this.frdecKcal.Location = new System.Drawing.Point(104, 60);
            this.frdecKcal.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.frdecKcal.Name = "frdecKcal";
            this.frdecKcal.Size = new System.Drawing.Size(130, 20);
            this.frdecKcal.TabIndex = 1;
            // 
            // frdecFat
            // 
            this.frdecFat.Location = new System.Drawing.Point(104, 93);
            this.frdecFat.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.frdecFat.Name = "frdecFat";
            this.frdecFat.Size = new System.Drawing.Size(130, 20);
            this.frdecFat.TabIndex = 2;
            // 
            // frdecCarbo
            // 
            this.frdecCarbo.Location = new System.Drawing.Point(104, 126);
            this.frdecCarbo.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.frdecCarbo.Name = "frdecCarbo";
            this.frdecCarbo.Size = new System.Drawing.Size(130, 20);
            this.frdecCarbo.TabIndex = 3;
            // 
            // lblSalt
            // 
            this.lblSalt.AutoSize = true;
            this.lblSalt.Location = new System.Drawing.Point(20, 195);
            this.lblSalt.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblSalt.Name = "lblSalt";
            this.lblSalt.Size = new System.Drawing.Size(25, 13);
            this.lblSalt.TabIndex = 5;
            this.lblSalt.Text = "Sól:";
            // 
            // lblWhey
            // 
            this.lblWhey.AutoSize = true;
            this.lblWhey.Location = new System.Drawing.Point(20, 162);
            this.lblWhey.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblWhey.Name = "lblWhey";
            this.lblWhey.Size = new System.Drawing.Size(41, 13);
            this.lblWhey.TabIndex = 4;
            this.lblWhey.Text = "Białko:";
            // 
            // lblCarbo
            // 
            this.lblCarbo.AutoSize = true;
            this.lblCarbo.Location = new System.Drawing.Point(20, 129);
            this.lblCarbo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblCarbo.Name = "lblCarbo";
            this.lblCarbo.Size = new System.Drawing.Size(78, 13);
            this.lblCarbo.TabIndex = 3;
            this.lblCarbo.Text = "Węglowodany:";
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Location = new System.Drawing.Point(20, 96);
            this.lblFat.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(48, 13);
            this.lblFat.TabIndex = 2;
            this.lblFat.Text = "Tłuszcz:";
            // 
            // lblKcalPerGramm
            // 
            this.lblKcalPerGramm.AutoSize = true;
            this.lblKcalPerGramm.Location = new System.Drawing.Point(20, 63);
            this.lblKcalPerGramm.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblKcalPerGramm.Name = "lblKcalPerGramm";
            this.lblKcalPerGramm.Size = new System.Drawing.Size(54, 13);
            this.lblKcalPerGramm.TabIndex = 1;
            this.lblKcalPerGramm.Text = "Kcal / 1g:";
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
            // Frm_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 306);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 294);
            this.Name = "Frm_Product";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Nowy produkt";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSalt;
        private System.Windows.Forms.Label lblWhey;
        private System.Windows.Forms.Label lblCarbo;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label lblKcalPerGramm;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox frdecSalt;
        private System.Windows.Forms.TextBox frdecWhey;
        private System.Windows.Forms.TextBox frtxtProductName;
        private System.Windows.Forms.TextBox frdecKcal;
        private System.Windows.Forms.TextBox frdecFat;
        private System.Windows.Forms.TextBox frdecCarbo;
        private Helper.Themes.Buttons.Cl_AddButton btnSave;
    }
}