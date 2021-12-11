namespace P6_3_1204053
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lbNPM = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.lbTGL = new System.Windows.Forms.Label();
            this.lbJK = new System.Windows.Forms.Label();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.lbAlamat = new System.Windows.Forms.Label();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.lbNo = new System.Windows.Forms.Label();
            this.lbPS = new System.Windows.Forms.Label();
            this.cbPS = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtTGL = new System.Windows.Forms.DateTimePicker();
            this.tbNo = new P6_3_1204053.NumericTextBox();
            this.ntbNPM = new P6_3_1204053.NumericTextBox();
            this.epcorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epwarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epwrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbNama = new P6_3_1204053.CharTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epcorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epwarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epwrong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(204, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM INPUT DATA MAHASISWA";
            // 
            // lbNPM
            // 
            this.lbNPM.AutoSize = true;
            this.lbNPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNPM.Location = new System.Drawing.Point(81, 124);
            this.lbNPM.Name = "lbNPM";
            this.lbNPM.Size = new System.Drawing.Size(169, 22);
            this.lbNPM.TabIndex = 1;
            this.lbNPM.Text = "NPM                       :";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNama.Location = new System.Drawing.Point(81, 170);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(167, 22);
            this.lbNama.TabIndex = 3;
            this.lbNama.Text = "Nama                     :";
            // 
            // lbTGL
            // 
            this.lbTGL.AutoSize = true;
            this.lbTGL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTGL.Location = new System.Drawing.Point(81, 218);
            this.lbTGL.Name = "lbTGL";
            this.lbTGL.Size = new System.Drawing.Size(166, 22);
            this.lbTGL.TabIndex = 5;
            this.lbTGL.Text = "Tanggal Lahir        :";
            // 
            // lbJK
            // 
            this.lbJK.AutoSize = true;
            this.lbJK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJK.Location = new System.Drawing.Point(81, 265);
            this.lbJK.Name = "lbJK";
            this.lbJK.Size = new System.Drawing.Size(166, 22);
            this.lbJK.TabIndex = 7;
            this.lbJK.Text = "Jenis Kelamin        :";
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLaki.Location = new System.Drawing.Point(263, 265);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(107, 26);
            this.rbLaki.TabIndex = 8;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki-Laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerempuan.Location = new System.Drawing.Point(400, 265);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(127, 26);
            this.rbPerempuan.TabIndex = 9;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // lbAlamat
            // 
            this.lbAlamat.AutoSize = true;
            this.lbAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlamat.Location = new System.Drawing.Point(80, 316);
            this.lbAlamat.Name = "lbAlamat";
            this.lbAlamat.Size = new System.Drawing.Size(170, 22);
            this.lbAlamat.TabIndex = 10;
            this.lbAlamat.Text = "Alamat                    :";
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(256, 315);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(420, 102);
            this.tbAlamat.TabIndex = 11;
            this.tbAlamat.Leave += new System.EventHandler(this.tbAlamat_Leave);
            // 
            // lbNo
            // 
            this.lbNo.AutoSize = true;
            this.lbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNo.Location = new System.Drawing.Point(81, 458);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(169, 22);
            this.lbNo.TabIndex = 12;
            this.lbNo.Text = "No Telepon            :";
            // 
            // lbPS
            // 
            this.lbPS.AutoSize = true;
            this.lbPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPS.Location = new System.Drawing.Point(81, 535);
            this.lbPS.Name = "lbPS";
            this.lbPS.Size = new System.Drawing.Size(169, 22);
            this.lbPS.TabIndex = 14;
            this.lbPS.Text = "Program Studi        :";
            // 
            // cbPS
            // 
            this.cbPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPS.FormattingEnabled = true;
            this.cbPS.Items.AddRange(new object[] {
            "D4TI",
            "D3TI",
            "D4LB",
            "D3LB",
            "D4MB",
            "D3MB",
            "D3AK"});
            this.cbPS.Location = new System.Drawing.Point(259, 527);
            this.cbPS.Name = "cbPS";
            this.cbPS.Size = new System.Drawing.Size(278, 30);
            this.cbPS.TabIndex = 15;
            this.cbPS.Text = "--Pilih Program Studi--";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(194, 629);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 39);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(386, 629);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 42);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtTGL
            // 
            this.dtTGL.Location = new System.Drawing.Point(256, 215);
            this.dtTGL.Name = "dtTGL";
            this.dtTGL.Size = new System.Drawing.Size(337, 26);
            this.dtTGL.TabIndex = 18;
            // 
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(259, 458);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(278, 26);
            this.tbNo.TabIndex = 20;
            this.tbNo.Leave += new System.EventHandler(this.tbNo_Leave);
            // 
            // ntbNPM
            // 
            this.ntbNPM.Location = new System.Drawing.Point(256, 119);
            this.ntbNPM.Name = "ntbNPM";
            this.ntbNPM.Size = new System.Drawing.Size(181, 26);
            this.ntbNPM.TabIndex = 19;
            this.ntbNPM.Leave += new System.EventHandler(this.ntbNPM_Leave);
            // 
            // epcorrect
            // 
            this.epcorrect.ContainerControl = this;
            this.epcorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epcorrect.Icon")));
            // 
            // epwarning
            // 
            this.epwarning.ContainerControl = this;
            this.epwarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epwarning.Icon")));
            // 
            // epwrong
            // 
            this.epwrong.ContainerControl = this;
            this.epwrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epwrong.Icon")));
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(255, 170);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(289, 26);
            this.tbNama.TabIndex = 21;
            this.tbNama.Leave += new System.EventHandler(this.tbNama_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 685);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.ntbNPM);
            this.Controls.Add(this.dtTGL);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbPS);
            this.Controls.Add(this.lbPS);
            this.Controls.Add(this.lbNo);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.lbAlamat);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.rbLaki);
            this.Controls.Add(this.lbJK);
            this.Controls.Add(this.lbTGL);
            this.Controls.Add(this.lbNama);
            this.Controls.Add(this.lbNPM);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Master Mahasiswa";
            ((System.ComponentModel.ISupportInitialize)(this.epcorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epwarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epwrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNPM;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbTGL;
        private System.Windows.Forms.Label lbJK;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.Label lbAlamat;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.Label lbNo;
        private System.Windows.Forms.Label lbPS;
        private System.Windows.Forms.ComboBox cbPS;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtTGL;
        private NumericTextBox ntbNPM;
        private NumericTextBox tbNo;
        private System.Windows.Forms.ErrorProvider epcorrect;
        private System.Windows.Forms.ErrorProvider epwarning;
        private System.Windows.Forms.ErrorProvider epwrong;
        private CharTextBox tbNama;
    }
}

