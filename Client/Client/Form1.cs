using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
// Namespace cho service reference (thường được tự động tạo sau khi thêm Service Reference)
using Client.ServiceReference1;  // 💡 English: CountryServiceReference

namespace Client
{
    public partial class Form1 : Form
    {
        // 🔌 Khai báo client kết nối với Web Service
        private WebService1SoapClient serviceClient;

        public Form1()
        {
            InitializeComponent();
            // 🏗️ Khởi tạo đối tượng kết nối đến Service
            serviceClient = new WebService1SoapClient();
            // 🎯 Gán sự kiện cho các button (nếu chưa gán trong Designer)
            btn_getAllCountry.Click += Btn_getAllCountry_Click;
            btn_getCountrybyCode.Click += Btn_getCountrybyCode_Click;
            btn_getCityByName.Click += Btn_getCityByName_Click;
            btn_getAllCityFromCountry.Click += Btn_getAllCityFromCountry_Click;
            btn_getCountriesByContinent.Click += Btn_getCountriesByContinent_Click;
            btn_getCitiesByPopulationRange.Click += Btn_getCitiesByPopulationRange_Click;
        }

        // 📊 Helper: Chuyển đổi danh sách Countries thành DataTable
        private DataTable ConvertCountriesToDataTable(Country[] countries)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Code");
            dt.Columns.Add("Name");
            dt.Columns.Add("Continent");
            dt.Columns.Add("Region");
            dt.Columns.Add("Population");

            foreach (var c in countries)
            {
                dt.Rows.Add(c.Code, c.Name, c.Continent, c.Region, c.Population);
            }
            return dt;
        }

        // 📊 Helper: Chuyển đổi danh sách Cities thành DataTable
        private DataTable ConvertCitiesToDataTable(City[] cities)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("CountryCode");
            dt.Columns.Add("District");
            dt.Columns.Add("Population");

            foreach (var c in cities)
            {
                dt.Rows.Add(c.ID, c.Name, c.CountryCode, c.District, c.Population);
            }
            return dt;
        }

        // 🔘 Sự kiện: Get All Country
        private async void Btn_getAllCountry_Click(object sender, EventArgs e)
        {
            try
            {
                // 🎯 Gọi web service
                var response = await serviceClient.GetAllCountriesAsync();
                var countries = response.Body.GetAllCountriesResult; 
                dbgv_exportdata.DataSource = ConvertCountriesToDataTable(countries);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // 🔘 Sự kiện: Get Country by Code
        private async void Btn_getCountrybyCode_Click(object sender, EventArgs e)
        {
            try
            {
                string code = txt_CountryCode.Text.Trim();
                if (string.IsNullOrEmpty(code))
                {
                    MessageBox.Show("Please input Country Code.");
                    return;
                }
                var response = await serviceClient.GetCountryByCodeAsync(code);
                var country = response.Body.GetCountryByCodeResult;  // Truy cập vào thuộc tính chứa đối tượng Country
                if (country != null)
                {
                    DataTable dt = ConvertCountriesToDataTable(new Country[] { country });
                    dbgv_exportdata.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No country found with the provided code.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // 🔘 Sự kiện: Get City by Name
        private async void Btn_getCityByName_Click(object sender, EventArgs e)
        {
            try
            {
                string cityName = txt_CityName.Text.Trim();
                if (string.IsNullOrEmpty(cityName))
                {
                    MessageBox.Show("Please input City Name.");
                    return;
                }

                var response = await serviceClient.GetCityByNameAsync(cityName);
                var city = response.Body.GetCityByNameResult; // Truy cập vào thuộc tính chứa thông tin City
                if (city != null)
                {
                    DataTable dt = ConvertCitiesToDataTable(new City[] { city });
                    dbgv_exportdata.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No city found with the provided name.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // 🔘 Sự kiện: Get All Cities by Country Code
        private async void Btn_getAllCityFromCountry_Click(object sender, EventArgs e)
        {
            try
            {
                string countryCode = txt_CountryCode.Text.Trim();
                if (string.IsNullOrEmpty(countryCode))
                {
                    MessageBox.Show("Please input Country Code.");
                    return;
                }
                var response = await serviceClient.GetAllCitiesByCountryCodeAsync(countryCode);
                var cities = response.Body.GetAllCitiesByCountryCodeResult; // Lấy danh sách City[] từ thuộc tính đúng
                dbgv_exportdata.DataSource = ConvertCitiesToDataTable(cities);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // 🔘 Sự kiện: Get Countries by Continent
        private async void Btn_getCountriesByContinent_Click(object sender, EventArgs e)
        {
            try
            {
                string continent = txt_Continent.Text.Trim();
                if (string.IsNullOrEmpty(continent))
                {
                    MessageBox.Show("Please input Continent.");
                    return;
                }
                var response = await serviceClient.GetCountriesByContinentAsync(continent);
                var countries = response.Body.GetCountriesByContinentResult; // Lấy danh sách Country[] từ thuộc tính đúng
                dbgv_exportdata.DataSource = ConvertCountriesToDataTable(countries);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // 🔘 Sự kiện: Get Cities by Population Range
        private async void Btn_getCitiesByPopulationRange_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txt_MinPopulation.Text.Trim(), out int minPop))
                {
                    MessageBox.Show("Please input a valid Min Population.");
                    return;
                }
                if (!int.TryParse(txt_MaxPopulation.Text.Trim(), out int maxPop))
                {
                    MessageBox.Show("Please input a valid Max Population.");
                    return;
                }
                var response = await serviceClient.GetCitiesByPopulationRangeAsync(minPop, maxPop);
                var cities = response.Body.GetCitiesByPopulationRangeResult; // Lấy danh sách City[] từ thuộc tính đúng
                dbgv_exportdata.DataSource = ConvertCitiesToDataTable(cities);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
