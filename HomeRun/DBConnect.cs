using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeRun
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }


        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "databaseMeccanico";
            uid = "root";
            password = "0";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }


        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        //Insert statement
        public void Insert(string tabella, string[] campi, string[] valori)
        {
            //string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

            string query = "INSERT INTO " + tabella + " (";

            foreach (string i in campi)
                query += i + ", ";

            query = query.Remove(query.Length - 3);

            query += ") VALUES (";

            foreach (string i in valori)
                query += "'" + i + "', ";

            query = query.Remove(query.Length - 3);

            query += ")";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }


        //Update statement
        public void Update(string tabella, string campoIdentificativo, string valoreIdentificativo, string[] campi, string[] valori)
        {
            //string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            string query = "UPDATE " + tabella + " SET ";

            for (int i = 0; i < campi.Length; i++)
                query += campi[i] + "='" + valori[i] + "', ";

            query = query.Remove(query.Length - 3);

            query += " WHERE " + campoIdentificativo + "='" + valoreIdentificativo + "'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }


        //Delete statement
        public void Delete(string tabella, string campoIdentificativo, string valoreIdentificativo)
        {
            //string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            string query = "DELETE FROM " + tabella + " WHERE " + campoIdentificativo + "='" + valoreIdentificativo + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }


        //Select statement
        public List<List<string>> Select(string tabella)
        {
            string querySelect = "SELECT * FROM " + tabella;
            string queryColonne = "SHOW COLUMNS FROM " + tabella;

            List<List<string>> tuple = new List<List<string>>();
            List<string> colonne = new List<string>();

            ////////////////////////// COLONNE ////////////////////////////////
            OpenConnection();
            // Creo
            MySqlCommand cmd = new MySqlCommand(queryColonne, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            // Leggo
            while (dataReader.Read())
                colonne.Add(dataReader[0].ToString());

            tuple.Add(colonne);

            // Chiudo
            dataReader.Close();
            CloseConnection();
            ///////////////////////////////////////////////////////////////////

            //////////////////////////// TUPLE ////////////////////////////////
            OpenConnection();
            // Creo
            cmd = new MySqlCommand(querySelect, connection);
            dataReader = cmd.ExecuteReader();
            int j = 1;

            // Leggo
            while (dataReader.Read())
            {
                tuple.Add(new List<string>());

                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    tuple[j].Add(dataReader[i].ToString());
                }

                j++;
            }

            // Chiudo
            dataReader.Close();
            CloseConnection();
            ///////////////////////////////////////////////////////////////////

            return tuple;
        }


        //Count statement
        public int Count(string tabella)
        {
            string query = "SELECT Count(*) FROM " + tabella;
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
    }
}
