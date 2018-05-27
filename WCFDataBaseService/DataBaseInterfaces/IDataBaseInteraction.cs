using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFDataBaseService.DataBaseInterfaces
{
    /// <summary>
    /// Interface for read- or write transactions
    /// </summary>
    public interface IDataBaseInteraction
    {



        AConnectionInfo ConnectionInformation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <param name="connection">connection information</param>
        /// <returns></returns>
        List<Person> PerfomReadRequest(string command);
        void PerfomWriteRequest(string command);

    }
}
