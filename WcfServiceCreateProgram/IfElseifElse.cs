using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceCreate
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IfElseifElse" in both code and config file together.
    public class IfElseifElse : IIfElseifElse
    {
        public string Equal(int n)
        {
            if (n < 1)
                return "n is less than 1";
            else if (n == 1)
                return "n is equal to 1";
            else
                return "n is greater than 1";
        }
    }
}
