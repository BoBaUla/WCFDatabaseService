using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFDataBaseService.DataBaseInterfaces;

namespace WCFDataBaseService.DataBaseClasses
{
    /// <summary>
    /// Zentrale Ablage für alle relevanten Datenbankenabfragen
    /// </summary>
    public class Commands : ICommands
    {
        public string Create(string name)
        {
            return "INSERT INTO `client`.`person` (`Name`) VALUES ('" + name + "');";
        }

        public string Delete(string id)
        {
            return "DELETE FROM `client`.`person` WHERE `ID`= '" + id + "';";
        }

        public string GetAll()
        {
            return "select * from client.person;";
        }

        public string Read(string id)
        {
            return "select * from client.person p where p.ID = '" + id + "';";
        }

        public string Update(Person person)
        {

            return "UPDATE `client`.`person` SET `Name`='" + person.Fullname + "' WHERE `ID`='" + person.ID + "';";

        }
    }
}
