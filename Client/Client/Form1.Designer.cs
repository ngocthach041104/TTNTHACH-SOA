namespace Client
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label_CountryCode = new System.Windows.Forms.Label();
            this.label_CityName = new System.Windows.Forms.Label();
            this.label_Continent = new System.Windows.Forms.Label();
            this.label_MinPopulation = new System.Windows.Forms.Label();
            this.label_MaxPopulation = new System.Windows.Forms.Label();
            this.txt_CountryCode = new System.Windows.Forms.TextBox();
            this.txt_CityName = new System.Windows.Forms.TextBox();
            this.txt_Continent = new System.Windows.Forms.TextBox();
            this.txt_MinPopulation = new System.Windows.Forms.TextBox();
            this.txt_MaxPopulation = new System.Windows.Forms.TextBox();
            this.btn_getAllCountry = new System.Windows.Forms.Button();
            this.btn_getCountrybyCode = new System.Windows.Forms.Button();
            this.btn_getCityByName = new System.Windows.Forms.Button();
            this.btn_getAllCityFromCountry = new System.Windows.Forms.Button();
            this.btn_getCountriesByContinent = new System.Windows.Forms.Button();
            this.btn_getCitiesByPopulationRange = new System.Windows.Forms.Button();
            this.dbgv_exportdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dbgv_exportdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label_CountryCode
            // 
            this.label_CountryCode.AutoSize = true;
            this.label_CountryCode.Location = new System.Drawing.Point(50, 30);
            this.label_CountryCode.Name = "label_CountryCode";
            this.label_CountryCode.Size = new System.Drawing.Size(88, 16);
            this.label_CountryCode.TabIndex = 0;
            this.label_CountryCode.Text = "Country Code";
            // 
            // label_CityName
            // 
            this.label_CityName.AutoSize = true;
            this.label_CityName.Location = new System.Drawing.Point(50, 80);
            this.label_CityName.Name = "label_CityName";
            this.label_CityName.Size = new System.Drawing.Size(69, 16);
            this.label_CityName.TabIndex = 1;
            this.label_CityName.Text = "City Name";
            // 
            // label_Continent
            // 
            this.label_Continent.AutoSize = true;
            this.label_Continent.Location = new System.Drawing.Point(50, 130);
            this.label_Continent.Name = "label_Continent";
            this.label_Continent.Size = new System.Drawing.Size(62, 16);
            this.label_Continent.TabIndex = 2;
            this.label_Continent.Text = "Continent";
            // 
            // label_MinPopulation
            // 
            this.label_MinPopulation.AutoSize = true;
            this.label_MinPopulation.Location = new System.Drawing.Point(50, 180);
            this.label_MinPopulation.Name = "label_MinPopulation";
            this.label_MinPopulation.Size = new System.Drawing.Size(95, 16);
            this.label_MinPopulation.TabIndex = 3;
            this.label_MinPopulation.Text = "Min Population";
            // 
            // label_MaxPopulation
            // 
            this.label_MaxPopulation.AutoSize = true;
            this.label_MaxPopulation.Location = new System.Drawing.Point(50, 230);
            this.label_MaxPopulation.Name = "label_MaxPopulation";
            this.label_MaxPopulation.Size = new System.Drawing.Size(99, 16);
            this.label_MaxPopulation.TabIndex = 4;
            this.label_MaxPopulation.Text = "Max Population";
            // 
            // txt_CountryCode
            // 
            this.txt_CountryCode.Location = new System.Drawing.Point(200, 30);
            this.txt_CountryCode.Name = "txt_CountryCode";
            this.txt_CountryCode.Size = new System.Drawing.Size(150, 22);
            this.txt_CountryCode.TabIndex = 5;
            // 
            // txt_CityName
            // 
            this.txt_CityName.Location = new System.Drawing.Point(200, 80);
            this.txt_CityName.Name = "txt_CityName";
            this.txt_CityName.Size = new System.Drawing.Size(150, 22);
            this.txt_CityName.TabIndex = 6;
            // 
            // txt_Continent
            // 
            this.txt_Continent.Location = new System.Drawing.Point(200, 130);
            this.txt_Continent.Name = "txt_Continent";
            this.txt_Continent.Size = new System.Drawing.Size(150, 22);
            this.txt_Continent.TabIndex = 7;
            // 
            // txt_MinPopulation
            // 
            this.txt_MinPopulation.Location = new System.Drawing.Point(200, 180);
            this.txt_MinPopulation.Name = "txt_MinPopulation";
            this.txt_MinPopulation.Size = new System.Drawing.Size(150, 22);
            this.txt_MinPopulation.TabIndex = 8;
            // 
            // txt_MaxPopulation
            // 
            this.txt_MaxPopulation.Location = new System.Drawing.Point(200, 230);
            this.txt_MaxPopulation.Name = "txt_MaxPopulation";
            this.txt_MaxPopulation.Size = new System.Drawing.Size(150, 22);
            this.txt_MaxPopulation.TabIndex = 9;
            // 
            // btn_getAllCountry
            // 
            this.btn_getAllCountry.Location = new System.Drawing.Point(400, 30);
            this.btn_getAllCountry.Name = "btn_getAllCountry";
            this.btn_getAllCountry.Size = new System.Drawing.Size(150, 40);
            this.btn_getAllCountry.TabIndex = 10;
            this.btn_getAllCountry.Text = "Get All Country";
            this.btn_getAllCountry.UseVisualStyleBackColor = true;
            // 
            // btn_getCountrybyCode
            // 
            this.btn_getCountrybyCode.Location = new System.Drawing.Point(400, 80);
            this.btn_getCountrybyCode.Name = "btn_getCountrybyCode";
            this.btn_getCountrybyCode.Size = new System.Drawing.Size(150, 54);
            this.btn_getCountrybyCode.TabIndex = 11;
            this.btn_getCountrybyCode.Text = "Get Country by Code";
            this.btn_getCountrybyCode.UseVisualStyleBackColor = true;
            // 
            // btn_getCityByName
            // 
            this.btn_getCityByName.Location = new System.Drawing.Point(400, 140);
            this.btn_getCityByName.Name = "btn_getCityByName";
            this.btn_getCityByName.Size = new System.Drawing.Size(150, 40);
            this.btn_getCityByName.TabIndex = 12;
            this.btn_getCityByName.Text = "Get City by Name";
            this.btn_getCityByName.UseVisualStyleBackColor = true;
            // 
            // btn_getAllCityFromCountry
            // 
            this.btn_getAllCityFromCountry.Location = new System.Drawing.Point(400, 186);
            this.btn_getAllCityFromCountry.Name = "btn_getAllCityFromCountry";
            this.btn_getAllCityFromCountry.Size = new System.Drawing.Size(150, 66);
            this.btn_getAllCityFromCountry.TabIndex = 13;
            this.btn_getAllCityFromCountry.Text = "Get Cities by Country Code";
            this.btn_getAllCityFromCountry.UseVisualStyleBackColor = true;
            // 
            // btn_getCountriesByContinent
            // 
            this.btn_getCountriesByContinent.Location = new System.Drawing.Point(400, 258);
            this.btn_getCountriesByContinent.Name = "btn_getCountriesByContinent";
            this.btn_getCountriesByContinent.Size = new System.Drawing.Size(150, 55);
            this.btn_getCountriesByContinent.TabIndex = 14;
            this.btn_getCountriesByContinent.Text = "Get Countries by Continent";
            this.btn_getCountriesByContinent.UseVisualStyleBackColor = true;
            // 
            // btn_getCitiesByPopulationRange
            // 
            this.btn_getCitiesByPopulationRange.Location = new System.Drawing.Point(400, 319);
            this.btn_getCitiesByPopulationRange.Name = "btn_getCitiesByPopulationRange";
            this.btn_getCitiesByPopulationRange.Size = new System.Drawing.Size(150, 53);
            this.btn_getCitiesByPopulationRange.TabIndex = 15;
            this.btn_getCitiesByPopulationRange.Text = "Get Cities by Population";
            this.btn_getCitiesByPopulationRange.UseVisualStyleBackColor = true;
            // 
            // dbgv_exportdata
            // 
            this.dbgv_exportdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgv_exportdata.Location = new System.Drawing.Point(53, 388);
            this.dbgv_exportdata.Name = "dbgv_exportdata";
            this.dbgv_exportdata.RowHeadersWidth = 51;
            this.dbgv_exportdata.Size = new System.Drawing.Size(700, 200);
            this.dbgv_exportdata.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dbgv_exportdata);
            this.Controls.Add(this.btn_getCitiesByPopulationRange);
            this.Controls.Add(this.btn_getCountriesByContinent);
            this.Controls.Add(this.btn_getAllCityFromCountry);
            this.Controls.Add(this.btn_getCityByName);
            this.Controls.Add(this.btn_getCountrybyCode);
            this.Controls.Add(this.btn_getAllCountry);
            this.Controls.Add(this.txt_MaxPopulation);
            this.Controls.Add(this.txt_MinPopulation);
            this.Controls.Add(this.txt_Continent);
            this.Controls.Add(this.txt_CityName);
            this.Controls.Add(this.txt_CountryCode);
            this.Controls.Add(this.label_MaxPopulation);
            this.Controls.Add(this.label_MinPopulation);
            this.Controls.Add(this.label_Continent);
            this.Controls.Add(this.label_CityName);
            this.Controls.Add(this.label_CountryCode);
            this.Name = "Form1";
            this.Text = "Country & City Service Client";
            ((System.ComponentModel.ISupportInitialize)(this.dbgv_exportdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CountryCode;
        private System.Windows.Forms.Label label_CityName;
        private System.Windows.Forms.Label label_Continent;
        private System.Windows.Forms.Label label_MinPopulation;
        private System.Windows.Forms.Label label_MaxPopulation;
        private System.Windows.Forms.TextBox txt_CountryCode;
        private System.Windows.Forms.TextBox txt_CityName;
        private System.Windows.Forms.TextBox txt_Continent;
        private System.Windows.Forms.TextBox txt_MinPopulation;
        private System.Windows.Forms.TextBox txt_MaxPopulation;
        private System.Windows.Forms.Button btn_getAllCountry;
        private System.Windows.Forms.Button btn_getCountrybyCode;
        private System.Windows.Forms.Button btn_getCityByName;
        private System.Windows.Forms.Button btn_getAllCityFromCountry;
        private System.Windows.Forms.Button btn_getCountriesByContinent;
        private System.Windows.Forms.Button btn_getCitiesByPopulationRange;
        private System.Windows.Forms.DataGridView dbgv_exportdata;
    }
}
