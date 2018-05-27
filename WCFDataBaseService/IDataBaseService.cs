using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFDataBaseService.DataBaseInterfaces;
using WCFDataBaseService.Exceptions;

namespace WCFDataBaseService
{
   
    [ServiceContract]
    public interface IDataBaseService
    {
        [OperationContract]
        [   WebInvoke(Method = "GET", 
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped, 
            UriTemplate = Routing.GetNameRouting)
        ]
        Person GetName(string id);

        [OperationContract]
        [   WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = Routing.GetTableRouting )
        ]
        List<Person> GetTable();

        [OperationContract]
        [   WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = Routing.PostNameRouting )
        ]
        void AddName(string name);

        [OperationContract]
        [   WebInvoke(Method = "PUT",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = Routing.ChangeNameRouting)
        ]
        void ChangeName(string id, string name);

        [OperationContract]
        [   WebInvoke(Method = "DELETE",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = Routing.DeleteNameRouting)
        ]
        void DeleteName(string id);


    }

    [DataContract]
    public class Person
    {
        string _id = "";
        string _fullname = "";

        [DataMember]
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        [DataMember]
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                if (value.Count() < 3 || value.Count() > 20)
                    throw new InvalidNameException("The entered name needs 3 to 20 characters");
                _fullname = value;
            }
        }
    }


}
