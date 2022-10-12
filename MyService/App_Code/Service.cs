using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public bool CheckPrime(int val)
    {
        // gets rid of negaives 0, 1 and 2
        // (2 only put here because 2 / 2 + 1 runs into the rule of cant be div by itself unlike larger numbers where adding 1 doesnt reach itself)
        if (val < 3) return false;
        for (int i = 3; i < (val / 2) + 1; i++)
        {
            if (val % i == 0) return false;
        }
        return true;
    }

    public int SumOfDigits(int val1)
    {
        int sum = 0;
        foreach (char c in val1.ToString())
        {
            sum += int.Parse(c.ToString());
        }

        return sum;
    }

    public string ReverseString(string val)
    {
        string reverse = "";
        foreach (char c in val.ToString())
        {
            reverse = c + reverse;
        }
        return reverse;
    }

    public string PrintHtml(string tag, string content)
    {
        return "<" + tag + ">" + content + "</" + tag + ">";
    }

    public List<int> SortNumbers(List<int> numbers, bool ascending)
    {
        numbers.Sort();

        if (!ascending)
        {
            numbers.Reverse();
        }
        return numbers;
    }
}
