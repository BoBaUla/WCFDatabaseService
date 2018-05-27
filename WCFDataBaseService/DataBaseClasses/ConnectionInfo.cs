using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFDataBaseService.DataBaseInterfaces;

namespace WCFDataBaseService.DataBaseClasses
{
    public class ConnectionInfo: AConnectionInfo
    {
       
        public ConnectionInfo(string server, string database, string uid, string password)
        {
            _server = server;
            _database = database;
            _uid = uid;
            _password = password;
        }

        protected ConnectionInfo()
        {

        }

        public override string GetConncetionInfo()
        {
            return "SERVER= "+_server + "; " +
                   "DATABASE= " + _database + "; " +
                   "UID = " + _uid + "; " +
                   "PASSWORD = " + _password +";";
        }
    }
}
