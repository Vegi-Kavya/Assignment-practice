using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryCreate
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEvenNumber" in both code and config file together.
    [ServiceContract]
    public interface IEvenNumber
    {
        [OperationContract]
        //void DoWork();
        string Even(int num1);
    }
}

