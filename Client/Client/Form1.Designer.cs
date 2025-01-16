namespace Client
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
            this.label_CountryCode = new System.Windows.Forms.Label();
            this.label_CityName = new System.Windows.Forms.Label();
            this.txt_CountryCode = new System.Windows.Forms.TextBox();
            this.txt_CityName = new System.Windows.Forms.TextBox();
            this.btn_getAllCountry = new System.Windows.Forms.Button();
            this.btn_getCountrybyCode = new System.Windows.Forms.Button();
            this.btn_getCityByName = new System.Windows.Forms.Button();
            this.btn_getAllCityFromCountry = new System.Windows.Forms.Button();
            this.dbgv_exportdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dbgv_exportdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label_CountryCode
            // 
            this.label_CountryCode.AutoSize = true;
            this.label_CountryCode.Location = new System.Drawing.Point(114, 73);
            this.label_CountryCode.Name = "label_CountryCode";
            this.label_CountryCode.Size = new System.Drawing.Size(88, 16);
            this.label_CountryCode.TabIndex = 0;
            this.label_CountryCode.Text = "Country Code";
            this.label_CountryCode.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_CityName
            // 
            this.label_CityName.AutoSize = true;
            this.label_CityName.Location = new System.Drawing.Point(485, 70);
            this.label_CityName.Name = "label_CityName";
            this.label_CityName.Size = new System.Drawing.Size(69, 16);
            this.label_CityName.TabIndex = 1;
            this.label_CityName.Text = "City Name";
            this.label_CityName.Click += new System.EventHandler(this.lb_CityName_Click);
            // 
            // txt_CountryCode
            // 
            this.txt_CountryCode.Location = new System.Drawing.Point(263, 67);
            this.txt_CountryCode.Name = "txt_CountryCode";
            this.txt_CountryCode.Size = new System.Drawing.Size(161, 22);
            this.txt_CountryCode.TabIndex = 2;
            this.txt_CountryCode.TextChanged += new System.EventHandler(this.txb_CountryCode_TextChanged);
            // 
            // txt_CityName
            // 
            this.txt_CityName.Location = new System.Drawing.Point(602, 64);
            this.txt_CityName.Name = "txt_CityName";
            this.txt_CityName.Size = new System.Drawing.Size(142, 22);
            this.txt_CityName.TabIndex = 3;
            this.txt_CityName.TextChanged += new System.EventHandler(this.txb_CityName_TextChanged);
            // 
            // btn_getAllCountry
            // 
            this.btn_getAllCountry.Location = new System.Drawing.Point(73, 154);
            this.btn_getAllCountry.Name = "btn_getAllCountry";
            this.btn_getAllCountry.Size = new System.Drawing.Size(151, 43);
            this.btn_getAllCountry.TabIndex = 5;
            this.btn_getAllCountry.Text = "Get All Country";
            this.btn_getAllCountry.UseVisualStyleBackColor = true;
            this.btn_getAllCountry.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_getCountrybyCode
            // 
            this.btn_getCountrybyCode.Location = new System.Drawing.Point(263, 151);
            this.btn_getCountrybyCode.Name = "btn_getCountrybyCode";
            this.btn_getCountrybyCode.Size = new System.Drawing.Size(161, 43);
            this.btn_getCountrybyCode.TabIndex = 6;
            this.btn_getCountrybyCode.Text = "Get Country by Code";
            this.btn_getCountrybyCode.UseVisualStyleBackColor = true;
            this.btn_getCountrybyCode.Click += new System.EventHandler(this.getCountrybyCode_Click);
            // 
            // btn_getCityByName
            // 
            this.btn_getCityByName.Location = new System.Drawing.Point(614, 151);
            this.btn_getCityByName.Name = "btn_getCityByName";
            this.btn_getCityByName.Size = new System.Drawing.Size(130, 46);
            this.btn_getCityByName.TabIndex = 7;
            this.btn_getCityByName.Text = "Get City By Name";
            this.btn_getCityByName.UseVisualStyleBackColor = true;
            this.btn_getCityByName.Click += new System.EventHandler(this.getCityByName_Click);
            // 
            // btn_getAllCityFromCountry
            // 
            this.btn_getAllCityFromCountry.Location = new System.Drawing.Point(439, 154);
            this.btn_getAllCityFromCountry.Name = "btn_getAllCityFromCountry";
            this.btn_getAllCityFromCountry.Size = new System.Drawing.Size(160, 43);
            this.btn_getAllCityFromCountry.TabIndex = 8;
            this.btn_getAllCityFromCountry.Text = "Get All City From Country";
            this.btn_getAllCityFromCountry.UseVisualStyleBackColor = true;
            this.btn_getAllCityFromCountry.Click += new System.EventHandler(this.getAllCityFromCountry_Click);
            // 
            // dbgv_exportdata
            // 
            this.dbgv_exportdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgv_exportdata.Location = new System.Drawing.Point(73, 224);
            this.dbgv_exportdata.Name = "dbgv_exportdata";
            this.dbgv_exportdata.RowHeadersWidth = 51;
            this.dbgv_exportdata.RowTemplate.Height = 24;
            this.dbgv_exportdata.Size = new System.Drawing.Size(671, 195);
            this.dbgv_exportdata.TabIndex = 10;
            this.dbgv_exportdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dbgv_exportdata);
            this.Controls.Add(this.btn_getAllCityFromCountry);
            this.Controls.Add(this.btn_getCityByName);
            this.Controls.Add(this.btn_getCountrybyCode);
            this.Controls.Add(this.btn_getAllCountry);
            this.Controls.Add(this.txt_CityName);
            this.Controls.Add(this.txt_CountryCode);
            this.Controls.Add(this.label_CityName);
            this.Controls.Add(this.label_CountryCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbgv_exportdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CountryCode;
        private System.Windows.Forms.Label label_CityName;
        private System.Windows.Forms.TextBox txt_CountryCode;
        private System.Windows.Forms.TextBox txt_CityName;
        private System.Windows.Forms.Button btn_getAllCountry;
        private System.Windows.Forms.Button btn_getCountrybyCode;
        private System.Windows.Forms.Button btn_getCityByName;
        private System.Windows.Forms.Button btn_getAllCityFromCountry;
        private System.Windows.Forms.DataGridView dbgv_exportdata;
    }
}

