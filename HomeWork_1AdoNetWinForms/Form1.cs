using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HomeWork_1AdoNetWinForms
{
    public partial class Form1 : Form
    {
        string _connectionString;
        DataSet _dataSet;
        const string ALL_INFORMATION = "SELECT * FROM VegAndFr";
        const string ALL_NAME = "SELECT DISTINCT [Name] FROM VegAndFr";
        const string ALL_COLOR = "SELECT DISTINCT Color FROM VegAndFr";
        const string MAX_CALORIES = "SELECT MAX(Calories) AS [Max Calories] FROM VegAndFr";
        const string MIN_CALORIES = "SELECT MIN(Calories) AS [Min Calories] FROM VegAndFr";
        const string AVG_CALORIES = "SELECT AVG(Calories) AS [Avg Calories] FROM VegAndFr";
        const string QUANTITY_VEGETABLES = "SELECT COUNT([Type]) AS [Quntity vegetables]" +
            " FROM VegAndFr WHERE [Type] = 'овощь'";
        const string QUANTITY_FRUITS = "SELECT COUNT([Type]) AS [Quntity fruits]" +
            " FROM VegAndFr WHERE [Type] = 'фрукт'";

        public Form1()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
            _dataSet = new DataSet();
        }

        void SqlQuery(string sqlQuery)
        {
            using var _connection = new SqlConnection(_connectionString);
            var _dataAdapter = new SqlDataAdapter(sqlQuery, _connection);
            _dataSet = new DataSet();
            _dataAdapter.Fill(_dataSet);
            ResetDataGridView();
            mainGrid.DataSource = _dataSet.Tables[0];
        }

        void ResetDataGridView()
        {
            mainGrid.CancelEdit();
            mainGrid.Columns.Clear();
            mainGrid.DataSource = null;
        }

        void BtnAllInformation_Click(object sender, EventArgs e)
        {
            SqlQuery(ALL_INFORMATION);
        }

        void BtnAllName_Click(object sender, EventArgs e)
        {
            SqlQuery(ALL_NAME);
        }

        void BtnAllColor_Click(object sender, EventArgs e)
        {
            SqlQuery(ALL_COLOR);
        }

        void BtnMaxCalories_Click(object sender, EventArgs e)
        {
            SqlQuery(MAX_CALORIES);
        }

        void BtnMinCalories_Click(object sender, EventArgs e)
        {
            SqlQuery(MIN_CALORIES);
        }

        void BtnAvgCalories_Click(object sender, EventArgs e)
        {
            SqlQuery(AVG_CALORIES);
        }

        private void BtnQuantityVegetables_Click(object sender, EventArgs e)
        {
            SqlQuery(QUANTITY_VEGETABLES);
        }

        private void BtnQuantityFruits_Click(object sender, EventArgs e)
        {
            SqlQuery(QUANTITY_FRUITS);
        }
    }
}