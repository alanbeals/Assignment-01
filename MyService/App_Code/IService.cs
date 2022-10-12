using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

	[OperationContract]
	bool CheckPrime(int val);

    [OperationContract]
    int SumOfDigits(int val1);

    [OperationContract]
    string ReverseString(string val);

    [OperationContract]
    string PrintHtml(string tag, string content);

    [OperationContract]
    List<int> SortNumbers(List<int> numbers, bool ascending);

}