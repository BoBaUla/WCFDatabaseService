using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFDataBaseService.DataBaseInterfaces
{
    public abstract class AConnectionInfo
    {
        protected string _server = "localhost";
        protected string _database = "client";
        protected string _uid = "root";
        protected string _password = "boba";

        public abstract string GetConncetionInfo();
    }
}
