ataTable GetComments()
        {
            DataTable dt = new DataTable();
            MySqlConnectionStringBuilder mysqlCSB;
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";
            mysqlCSB.Database = "web";
            mysqlCSB.UserID = "nomn";
            mysqlCSB.Password = "1111";
 
            string queryString = @"SELECT * FROM sites";
 
            using (MySqlConnection con = new MySqlConnection())
            {
                con.ConnectionString = mysqlCSB.ConnectionString;
 
                MySqlCommand com = new MySqlCommand(queryString, con);
 
                try
                {
                    con.Open();
 
                    using (MySqlDataReader dr = com.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dt.Load(dr);
                        }
                    }
                }
 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return dt;
        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetComments();
        }
