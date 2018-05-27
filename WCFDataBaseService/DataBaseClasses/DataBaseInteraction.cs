using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFDataBaseService.DataBaseInterfaces;

namespace WCFDataBaseService.DataBaseClasses
{
    /// <summary>
    /// Fasst Datenbankenverbindungen zusammen
    /// </summary>
    class DataBaseInteraction : IDataBaseInteraction
    {
        MySqlConnection _mySqlConnection = new MySqlConnection();
        public AConnectionInfo ConnectionInformation { get; set; }

        public DataBaseInteraction(AConnectionInfo conncetion)
        {
            ConnectionInformation = conncetion;
        }

        public List<Person> PerfomReadRequest(string command)
        {
            DataTable data = new DataTable();

            _mySqlConnection = new MySqlConnection(ConnectionInformation.GetConncetionInfo());
            _mySqlConnection.Open();
            MySqlCommand cmd = _mySqlConnection.CreateCommand();
            cmd.CommandText = command;
            MySqlDataAdapter worker = new MySqlDataAdapter();
            worker.SelectCommand = cmd;
            worker.Fill(data);
            _mySqlConnection.Close();
            List<Person> personList = ( from DataRow rows in data.Rows
                                        select new Person()
                                        {
                                            ID = rows[0].ToString(),
                                            Fullname = rows[1].ToString()
                                        }).ToList<Person>();

            return personList;
        }

        public void PerfomWriteRequest(string command)
        {
            _mySqlConnection = new MySqlConnection(ConnectionInformation.GetConncetionInfo());
            
            MySqlCommand statement = new MySqlCommand(command, _mySqlConnection);
            _mySqlConnection.Open();
            statement.ExecuteNonQuery();
            _mySqlConnection.Close();
        }
    }
}
