using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContohApp.Model
{
    class FoodModel
    {
        // 1. Connect DBConnection
        private SqlConnection connection;

        public FoodModel()
        {
            connection = DBConnection.GetConnection();
        }

        // 2. Declare var -> field table food
        private int id, price;
        private string name, image;

        public int Id { get { return id; } set { id = value; } }
        public int Price { get { return price; } set { price = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Image { get { return image; } set { image = value; } }

        // 3. Declare  function
        public DataSet SelectFood()
        {
            DataSet data = new DataSet();
            try
            {
                connection.Open();

                string query = "Select * From food";
                SqlCommand command = connection.CreateCommand();
                command.CommandText = query;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(data, "food");

                connection.Close();
            }
            catch (SqlException)
            {
                connection.Close();
            }
            return data;
        }
        //test banget
    }
}
