using System;

class Dog : Animal
{
    public Dog(string name, string favouiteFood) 
        : base(name, favouiteFood)
    {
    }

    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "DJAAF";
    }
}
