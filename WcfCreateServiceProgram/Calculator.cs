using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfCreateService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculator" in both code and config file together.
    //Menu to change the classname calculator
    //In both code and config file together
    public class Calculator : ICalculator
    {
        public int Sum(int num1,int num2)
        {
            return num1 + num2;
        }
        public int Sub(int num1, int num2)
        {
            if (num1 > num2)
                return num1 - num2;
            else
                return num2-num1;
        }
        public int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Divide(int num1, int num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
                return 0;
        }
    }
}
