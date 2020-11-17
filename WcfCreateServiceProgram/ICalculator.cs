using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfCreateService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculator" in both code and config file together.
    //Menu to change interface name ICalculator in both code 
    //and config file together
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        //void DoWork();
        int Sum(int num1, int num2);
        [OperationContract]
        int Sub(int num1, int num2);
        [OperationContract]
        int Mul(int num1, int num2);
        [OperationContract]
        int Divide(int num1, int num2);
    }
}
//use a data contract composite type to service operations
[DataContract]//Declare and assign variable
public class CompositeType
{
    bool boolvalue = true;//boolean value assigned true
    string stringval = "Hello World";//string value returned hello world
    [DataMember]//you call are invoke data information
    public bool BoolValue
    {
        get { return boolvalue; }
        set { boolvalue = value; }
    }
    public string StringValue
    {
        get { return stringval; }
        set { stringval = value; }
    }
}
