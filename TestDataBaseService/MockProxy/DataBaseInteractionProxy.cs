using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFDataBaseService;
using WCFDataBaseService.DataBaseClasses;
using WCFDataBaseService.DataBaseInterfaces;

namespace TestDataBaseInteraction.MockProxy
{
    /// <summary>
    /// Der Test soll nicht auf reale Datenbank-Verbindung abhängen
    /// </summary>
    public class DataBaseMock : IDataBaseInteraction
    {
        List<Person> _mockDatabase = new List<Person>()
        {
            new Person() { ID = "1", Fullname = "Alf"},
            new Person() { ID = "2", Fullname = "Blf"},
            new Person() { ID = "3", Fullname = "Clf"},
            new Person() { ID = "4", Fullname = "Dlf"},
            new Person() { ID = "5", Fullname = "Elf"},
            new Person() { ID = "6", Fullname = "Flf"},
        };

        public AConnectionInfo ConnectionInformation { get; set; }

        public DataBaseMock(AConnectionInfo conncetion)
        {
            ConnectionInformation = conncetion;
        }

        public List<Person> PerfomReadRequest(string command)
        {
                return _mockDatabase;
        }

        public void PerfomWriteRequest(string command)
        {
            if(command.Contains("INSERT"))
            {
                int id = _mockDatabase.Count()+1;
                string[] seperator = { "VALUES" };
                string value = command.Split(seperator, StringSplitOptions.RemoveEmptyEntries)[1]
                    .Replace("'", "")
                    .Replace("(", "")
                    .Replace(")", "")
                    .Replace(";","")
                    .Trim() ;
                _mockDatabase.Add(new Person() { ID = id.ToString(), Fullname = value });
            }
            if (command.Contains("UPDATE"))
            {
                string[] seperator = { "`Name`='","WHERE" , "`ID`='" };
                string[] value = command.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                int id = int.Parse(value[3].Replace(";", "").Replace("'", "").Trim());
                string newName = value[1].Replace("'", "").Trim();
                _mockDatabase.Insert(id-1, new Person() { ID = id.ToString(), Fullname = newName });
                _mockDatabase.RemoveAt(id);
            }
        }
    }

    public class DataBaseServiceMock: IDataBaseService
    {
        DataBaseService _service = null;
        public DataBaseServiceMock()
        {
            _service = new DataBaseService(new DataBaseRequest(new DataBaseMock(new ConnectionInfo("","","",""))));
        }

        public void AddName(string name)
        {
            _service.AddName(name);
        }

        public void ChangeName(string id, string name)
        {
            _service.ChangeName(id, name);
        }

        public void DeleteName(string id)
        {
            _service.DeleteName(id);
        }


        public Person GetName(string id)
        {
            return _service.GetName(id);
        }

        public List<Person> GetTable()
        {
            return _service.GetTable();
        }
    }
}
