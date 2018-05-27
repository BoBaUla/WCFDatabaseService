using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFDataBaseService;
using WCFDataBaseService.DataBaseInterfaces;

namespace DataBaseServiceImplementation.Proxy
{
    public class DataBaseInteractionProxy : ClientBase<IDataBaseService>, IDataBaseService
    {
        public DataBaseInteractionProxy()
        {
            
        }

        public Person GetName(string id)
        {
            return base.Channel.GetName(id);
        }

        public List<Person> GetTable()
        {
            return base.Channel.GetTable();
        }

        public void AddName(string name)
        {
            base.Channel.AddName(name);
        }

        public void ChangeName(string id, string name)
        {
            base.Channel.ChangeName(id, name);
        }

        public void DeleteName(string id)
        {
            base.Channel.DeleteName(id);
        }
    }
}
