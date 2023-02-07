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
        const string QUANTITY_VEGETABLES_AND_FRUITS_EACH_COLOR = "SELECT Color, COUNT(Color) AS [Quantity Vegetable And Fruits Each Color]" +
            " FROM VegAndFr GROUP BY Color";
        const string VEGETABLES_AND_FRUIT_COLOR_RED_OR_YELLOW = "SELECT * FROM VegAndFr" +
            " WHERE Color = 'желтый' OR Color = 'красный'";

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

        void BtnQuantityVegetables_Click(object sender, EventArgs e)
        {
            SqlQuery(QUANTITY_VEGETABLES);
        }

        void BtnQuantityFruits_Click(object sender, EventArgs e)
        {
            SqlQuery(QUANTITY_FRUITS);
        }

        void BtnQuantityVegAndFrGivenColor_Click(object sender, EventArgs e)
        {
            string sqlQueryColor = "SELECT COUNT(Color) AS [Quantity Vegetable And Fruits Given Color]" +
                $" FROM VegAndFr WHERE Color = '{txtColor.Text}'";
            SqlQuery(sqlQueryColor);
        }

        void BtnQuantityVegAndFrEachColor_Click(object sender, EventArgs e)
        {
            SqlQuery(QUANTITY_VEGETABLES_AND_FRUITS_EACH_COLOR);
        }

        void BtnVegAndFrColorRedOrYellow_Click(object sender, EventArgs e)
        {
            SqlQuery(VEGETABLES_AND_FRUIT_COLOR_RED_OR_YELLOW);
        }

        void BtnCalorieContentBelow_Click(object sender, EventArgs e)
        {
            string sqlQueryCalorie = $"SELECT * FROM VegAndFr WHERE Calories < '{txtCalories.Text}'";
            SqlQuery(sqlQueryCalorie);
        }

        void BtnCalorieContentHigher_Click(object sender, EventArgs e)
        {
            string sqlQueryCalorie = $"SELECT * FROM VegAndFr WHERE Calories > '{txtCalories.Text}'";
            SqlQuery(sqlQueryCalorie);
        }

        void BtnCalorieContentDiapason_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(nmrcDiapason1.Value);
            int num2 = Convert.ToInt32(nmrcDiapason2.Value);
            int max = (num1 > num2) ? num1 : num2;
            int min = (num1 < num2) ? num1 : num2;

            string sqlQueryCalorie = $"SELECT * FROM VegAndFr WHERE Calories BETWEEN '{min}' AND '{max}'";
            SqlQuery(sqlQueryCalorie);
        }
    }
}