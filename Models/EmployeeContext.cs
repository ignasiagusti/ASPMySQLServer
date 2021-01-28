using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMySQL.Models
{
    public class EmployeeContext
    {
        public string ConnectionString { get; set; }

        public EmployeeContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> list = new List<Employee>();
            
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employees.employeedbo", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Employee()
                        {
                            Id = Convert.ToInt32(reader["idEmployee"]),
                            Name = reader["Name"].ToString(),
                            Surname = reader["Surname"].ToString(),
                            Position = reader["Position"].ToString(),
                            Salary = Convert.ToInt32(reader["Salary"])
                        });
                    }
                }
            }
            return list;
        }
    }
}
