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
    /// Bietet CRUD-Funktionen, und erlaubt es verschiedene Datenbanken anzubinden
    /// </summary>
    public class DataBaseRequest : IDataBaseRequest
    {
        IDataBaseInteraction _dbInteraction =null;

        IDataBaseInteraction DataBaseInterface
        {
            get
            {
                return _dbInteraction;
            }
            set
            {
                _dbInteraction = value;
            }
        }

        public DataBaseRequest() { }

        public DataBaseRequest(IDataBaseInteraction dbInteraction)
        {
            _dbInteraction = dbInteraction;
        }

        public void AddName(Person person)
        {
            _dbInteraction.PerfomWriteRequest((new Commands()).Create(person.Fullname));
        }

        public void ChangeName(Person person)
        {
            _dbInteraction.PerfomWriteRequest((new Commands()).Update(person));
        }
                
        public void DeleteName(string id)
        {
            _dbInteraction.PerfomWriteRequest((new Commands()).Delete(id));
        }

        public Person GetName(string id)
        {
            return _dbInteraction.PerfomReadRequest((new Commands()).Read(id)).First(); ;
        }

        public List<Person> GetTable()
        {
            return _dbInteraction.PerfomReadRequest((new Commands()).GetAll());
        }

    }
}
