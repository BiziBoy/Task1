using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veem_Lab1
{
  sealed class MyImmutableClass
  {
    private string name { get;  }
    private int id { get; }
    public MyImmutableClass(string _name, int _id)
    {
      name = _name;
      id = _id;
    }

    public MyImmutableClass changeId(ref MyImmutableClass myImmutableClass)
    {
      string nameTemp = myImmutableClass.name;
      Console.Write("Введите новое значение Id: ");
      int idTemp = int.Parse(Console.ReadLine());
      MyImmutableClass temp = new MyImmutableClass(nameTemp, idTemp);
      myImmutableClass = null; 
      return temp;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {

    }
  }
}
