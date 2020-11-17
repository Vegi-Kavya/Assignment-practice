using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryCreate
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EvenNumber" in both code and config file together.
    public class EvenNumber : IEvenNumber
    {
        public string Even(int num1)
        {
            if (num1 % 2 == 0)
                return "Even Number";
            else
                return "Odd Number";
        }
    }
}
