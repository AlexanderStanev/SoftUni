using System;
using System.Collections;

class RandomList : ArrayList
{
    public string RandomString() {
        var rnd = new Random();

        var randomElement = rnd.Next(0, this.Count);

        var removedElement = this[randomElement];
        this.RemoveAt(randomElement);

        return $"Removed element is {removedElement.ToString()}";
    }
}
