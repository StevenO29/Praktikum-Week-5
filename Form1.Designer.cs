namespace Praktikum_Week_5
{
    partial class FormMateri
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblData = new System.Windows.Forms.Label();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBoxKoleksi = new System.Windows.Forms.ListBox();
            this.lblKoleksi = new System.Windows.Forms.Label();
            this.lblSetting = new System.Windows.Forms.Label();
            this.checkBoxAktif = new System.Windows.Forms.CheckBox();
            this.radBtnMerah = new System.Windows.Forms.RadioButton();
            this.radBtnBiru = new System.Windows.Forms.RadioButton();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblHasil = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(23, 24);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(58, 25);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data :";
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(87, 24);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(458, 31);
            this.txtBoxInput.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(568, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBoxKoleksi
            // 
            this.listBoxKoleksi.FormattingEnabled = true;
            this.listBoxKoleksi.ItemHeight = 25;
            this.listBoxKoleksi.Location = new System.Drawing.Point(23, 134);
            this.listBoxKoleksi.Name = "listBoxKoleksi";
            this.listBoxKoleksi.Size = new System.Drawing.Size(278, 529);
            this.listBoxKoleksi.TabIndex = 3;
            this.listBoxKoleksi.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblKoleksi
            // 
            this.lblKoleksi.AutoSize = true;
            this.lblKoleksi.Location = new System.Drawing.Point(23, 91);
            this.lblKoleksi.Name = "lblKoleksi";
            this.lblKoleksi.Size = new System.Drawing.Size(76, 25);
            this.lblKoleksi.TabIndex = 4;
            this.lblKoleksi.Text = "Koleksi :";
            // 
            // lblSetting
            // 
            this.lblSetting.AutoSize = true;
            this.lblSetting.Location = new System.Drawing.Point(375, 91);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(77, 25);
            this.lblSetting.TabIndex = 5;
            this.lblSetting.Text = "Setting :";
            // 
            // checkBoxAktif
            // 
            this.checkBoxAktif.AutoSize = true;
            this.checkBoxAktif.Location = new System.Drawing.Point(469, 91);
            this.checkBoxAktif.Name = "checkBoxAktif";
            this.checkBoxAktif.Size = new System.Drawing.Size(75, 29);
            this.checkBoxAktif.TabIndex = 6;
            this.checkBoxAktif.Text = "Aktif";
            this.checkBoxAktif.UseVisualStyleBackColor = true;
            this.checkBoxAktif.CheckedChanged += new System.EventHandler(this.checkBoxAktif_CheckedChanged);
            // 
            // radBtnMerah
            // 
            this.radBtnMerah.AutoSize = true;
            this.radBtnMerah.Location = new System.Drawing.Point(425, 138);
            this.radBtnMerah.Name = "radBtnMerah";
            this.radBtnMerah.Size = new System.Drawing.Size(142, 29);
            this.radBtnMerah.TabIndex = 7;
            this.radBtnMerah.TabStop = true;
            this.radBtnMerah.Text = "Warna Merah";
            this.radBtnMerah.UseVisualStyleBackColor = true;
            this.radBtnMerah.CheckedChanged += new System.EventHandler(this.radBtnMerah_CheckedChanged);
            // 
            // radBtnBiru
            // 
            this.radBtnBiru.AutoSize = true;
            this.radBtnBiru.Location = new System.Drawing.Point(425, 182);
            this.radBtnBiru.Name = "radBtnBiru";
            this.radBtnBiru.Size = new System.Drawing.Size(122, 29);
            this.radBtnBiru.TabIndex = 8;
            this.radBtnBiru.TabStop = true;
            this.radBtnBiru.Text = "Warna Biru";
            this.radBtnBiru.UseVisualStyleBackColor = true;
            this.radBtnBiru.CheckedChanged += new System.EventHandler(this.radBtnBiru_CheckedChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(375, 279);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(78, 25);
            this.lblOutput.TabIndex = 9;
            this.lblOutput.Text = "Output :";
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHasil.Location = new System.Drawing.Point(375, 378);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(0, 74);
            this.lblHasil.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(375, 629);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(340, 34);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormMateri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 696);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.radBtnBiru);
            this.Controls.Add(this.radBtnMerah);
            this.Controls.Add(this.checkBoxAktif);
            this.Controls.Add(this.lblSetting);
            this.Controls.Add(this.lblKoleksi);
            this.Controls.Add(this.listBoxKoleksi);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.lblData);
            this.Name = "FormMateri";
            this.Text = "Form Materi";
            this.Load += new System.EventHandler(this.FormMateri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBoxKoleksi;
        private System.Windows.Forms.Label lblKoleksi;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.CheckBox checkBoxAktif;
        private System.Windows.Forms.RadioButton radBtnMerah;
        private System.Windows.Forms.RadioButton radBtnBiru;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Button btnClear;
    }
}
