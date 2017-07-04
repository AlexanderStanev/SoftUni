using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StackOfStrings
{
    private List<string> data = new List<string>();

    public void Push(string item)
    {
        data.Add(item);
    }

    public string Pop()
    {
        if (IsEmpty())
        {
            throw new Exception("The stack is empty");
        }

        var removedElement = data[data.Count - 1];
        var removeElementIndex = data.FindLastIndex(x => x == removedElement);

        data.RemoveAt(removeElementIndex);

        return removedElement;
    }

    public string Peek()
    {
        if (IsEmpty())
        {
            throw new Exception("The stack is empty");
        }

        return data[data.Count - 1];
    }

    public bool IsEmpty()
    {
        if (data.Count > 0)
        {
            return false;
        }

        return true;
    } 
}
