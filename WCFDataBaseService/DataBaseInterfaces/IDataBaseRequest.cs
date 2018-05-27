using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFDataBaseService.DataBaseInterfaces
{
    /// <summary>
    /// Interface that offers some basic functions for database-interaction.
    /// Use this interface to define some basic calls.
    /// </summary>
    public interface IDataBaseRequest
    {
        Person GetName(string id);
        List<Person> GetTable();
        void AddName(Person person);
        void ChangeName(Person person);
        void DeleteName(string id);
    }
}
