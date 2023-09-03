using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DotNetBasic;

internal class PropertyBinding
{
    private int _age;

    public int speed;


    public int GetAge()
    {
        return _age;
    }

    private void SetAge(int age)
    {
        _age = age;
    }

    public int Speed
    {
        get { return speed; }
        set
        {
            speed = value;
        }
    }
}
