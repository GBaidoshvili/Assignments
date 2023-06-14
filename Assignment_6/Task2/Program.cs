
using System.Timers;
using Task2;

var list = new ElementList();

list.AddElement(new Element("1", "1"));
list.AddElement(new Element("2", "2"));
list.AddElement(new Element("3", "3"));
list.AddElement(new Element("4", "4"));
list.AddElement(new Element("5", "5"));

list.OutputElements();

list.Insert(2, new Element("new", "new"));

list.OutputElements();

var list2 = new ElementList();

list2.AddElement(new Element("a", "a"));
list2.AddElement(new Element("b", "b"));
list2.AddElement(new Element("c", "c"));

list.AddElementList(list2);

list.OutputElements();

list.InsertList(2, list2);

list.OutputElements();

list.RemoveElement(2);

list.OutputElements();

list.RemoveList(2, 2);

list.OutputElements();

list.GetElement(3, out var element);

Console.WriteLine();

Console.WriteLine("Your selected element is: " + element.Name);

list.GetList(2, 2, out var subList);
subList.OutputElements();

Console.WriteLine();

Console.WriteLine("You found the element: " + list.Find("5").Name);


