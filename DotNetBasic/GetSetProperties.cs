using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasic;

public class GetSetProperties
{
    public int id { get; set; }


    private string _name;
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    private int balance;

    public int GetBalance()
    {
        return balance;
    }
    public void SetBalance(int balance)
    {
        if (balance < 0) 
            balance = 0;
        else
            this.balance = balance;

    }

}
