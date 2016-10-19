using System;
using System.Configuration;
using System.Data.SqlClient;

namespace RegionSearch.Managers
{
    public class Authorization
    {
        public string ConnectString { get; private set; }

        public bool IsConnected(string login, string password)
        {
            bool res = true;
            ConnectString = ConfigurationManager.ConnectionStrings["RegionContext"].ConnectionString;

            var stringBuilder = new SqlConnectionStringBuilder(ConnectString) {
                UserID = login,
                Password = password
            };

            var connection = new SqlConnection(stringBuilder.ToString());
            try {
                connection.Open();
            }
            catch (Exception ex) {
                res = false;
            }

            return res;
        }
    }
}