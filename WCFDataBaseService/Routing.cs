using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFDataBaseService
{
    
    public static class Routing
    {
        public const string GetNameRouting = "/GetName/{id}";
        public const string GetTableRouting = "/GetTable";

        public const string PostNameRouting = "/PostName/{Name}";
        public const string DeleteNameRouting = "/Delete/{id}";
        public const string ChangeNameRouting = "/Update/{id}/{name}";
    }
}
