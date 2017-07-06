using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    private string name;
    private int money;
    private int myVar;

    public int MyProperty
    {
        get { return myVar; }
        set { myVar = value; }
    }


    public int Money
    {
        get { return money; }
        set { money = value; }
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }

}
