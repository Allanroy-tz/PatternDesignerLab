using MySql.Data.MySqlClient;
using System.Data;

namespace The_Calculator
{
    public class Tz20200440718_DataBaseOp
    {
        private static string stringCon = "server = 127.0.0.1; port=3302;user=root;password=777700;database=calculatorlog ";
        private static MySqlConnection conn = new MySqlConnection(stringCon);
        private static MySqlDataAdapter mda;
        DataSet dataSet = new DataSet();
        public void OpenConnection()
        {
            conn.Open();

        }

        public void CloseConnection()
        {
            conn.Close();
        }
        public int GetId()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            MySqlDataReader mySqlDataReader;
            MySqlCommand cmd = new MySqlCommand("select id from logtable order by id desc limit 0,1;", conn);
            mySqlDataReader = cmd.ExecuteReader();
            int str = 1;
            mySqlDataReader.Read();
            str = mySqlDataReader.GetInt32(0);
            mySqlDataReader.Close();
            return str;
        }
        public DataTable ReadData(int table)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            mda = new MySqlDataAdapter("select * from logtable", conn);
            mda.Fill(dataSet);
            return dataSet.Tables[table];
        }

        public void WriteData(int id, string log)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO `calculatorlog`.`logtable` (`Id`, `Log`) VALUES ('" + id + "', '" + log + "');";
            cmd.ExecuteScalar();
            conn.Close();
            return;
        }
    }
}