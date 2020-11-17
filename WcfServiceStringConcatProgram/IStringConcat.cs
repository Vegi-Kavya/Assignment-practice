using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceStringConcat
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStringConcat" in both code and config file together.
    [ServiceContract]
    public interface IStringConcat
    {
        [OperationContract]
        //void DoWork();
        string Concat(string a, string b);
    }
}
