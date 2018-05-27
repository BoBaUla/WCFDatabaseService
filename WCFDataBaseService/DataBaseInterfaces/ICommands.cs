using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFDataBaseService.DataBaseInterfaces
{
    public interface ICommands
    {
        string Create(string name);
        string Read(string id);
        string Update(Person person);
        string Delete(string id);
        string GetAll();
    }
}
