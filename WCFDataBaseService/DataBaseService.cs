using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using WCFDataBaseService.DataBaseClasses;
using WCFDataBaseService.DataBaseInterfaces;
using WCFDataBaseService.Exceptions;

namespace WCFDataBaseService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single, IncludeExceptionDetailInFaults = true)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class DataBaseService : IDataBaseService
    {
         
        IDataBaseRequest _request;
        IDataBaseInteraction _dbInteraction;
        AConnectionInfo _connectionInfo;

        public DataBaseService()
        {
            _connectionInfo = new ConnectionInfo("localhost", "client", "root", "boba"); // hier die Verbindungsinformationen zur Datenbank anlegen
            _dbInteraction = new DataBaseInteraction(_connectionInfo);
            _request = new DataBaseRequest(_dbInteraction);
        }
        public DataBaseService(IDataBaseRequest request)
        {
            _request = request;
        }

        public IDataBaseRequest DBRequest
        {
            get
            {
                return _request;
            }
            set
            {
                _request = value;
            }
        }

        public void AddName(string name)
        {
            try
            {
                _request.AddName(new Person() { ID = "", Fullname = name });
            }
            catch(InvalidNameException ex)
            {
                
            }
        }

        public void ChangeName(string id, string name )
        {   
            _request.ChangeName(new Person() { ID = id, Fullname = name });
        }

        public void DeleteName(string id)
        {
        
            _request.DeleteName(id);
        }

        public Person GetName(string id)
        {
            
            return _request.GetName(id);
        }

        public List<Person> GetTable()
        {
            return _request.GetTable();
        }

    }
}
