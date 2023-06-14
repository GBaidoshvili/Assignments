using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task2
{
    internal class ElementList : IEnumerable<Element>
    {
        private Element[] _elements = new Element[0];

        public Element this[int i]
        {
            get { return _elements[i]; }
            set { _elements[i] = value; }
        }

        public int Count
        {
            get { return this._elements.Length; }
        }

        public IEnumerator<Element> GetEnumerator()
        {
            return ((IEnumerable<Element>)_elements).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _elements.GetEnumerator();
        }

        public void OutputElements()
        {
            Console.WriteLine("\n-----------------------------");
            foreach (Element e in this)
            {
                Console.Write(e.Name+"; ");
            }
        }


        public void AddElement(Element element)
        {
            var newList = new Element[Count + 1];
            for(int i = 0; i < Count; i++)
            {
                newList[i] = this[i];
            }
            newList[Count] = element;
            _elements = newList;
        }

        public void Clear()
        {
            _elements = new Element[0];
        }

        public bool Insert(int index, Element element)
        {
            if (index > Count)
                return false;

            var newList = new Element[Count + 1];
            for(int i = 0;i < Count;i++)
            {
                if (i < index)
                    newList[i] = this[i];
                else
                    newList[i+1] = this[i];
            }
            newList[index] = element;
            _elements = newList;
            return true;
        }

        public void AddElementList(ElementList list)
        {
            var newList = new Element[Count + list.Count];
            for (int i = 0; i < Count; i++)
            {
                newList[i] = this[i];
            }
            for (int i = Count; i< Count + list.Count; i++)
            {
                newList[i] = list[i-Count];
            }
            _elements = newList;
        }

        public bool InsertList(int index, ElementList list)
        {

            if (index > Count)
                return false;

            var newList = new Element[Count + list.Count];

            for (int i = 0; i < Count; i++)
            {
                if(i < index)
                    newList[i] = this[i];
                else
                {
                    newList[i+list.Count] = this[i];
                }
            }

            for (int i = index; i < index+list.Count; i++)
            {
                newList[i] = list[i-index];
            }
            _elements = newList;
            
            return true;
        }

        public bool RemoveElement(int index)
        {
            if (index >= Count)
                return false;

            var newList = new Element[Count -1];

            for (int i = 0; i<newList.Length; i++)
            {
                if (i < index)
                    newList[i] = this[i];
                else
                    newList[i] = this[i+1];
            }

            _elements = newList;

            return true;

        }

        public bool RemoveList(int index, int numberOfElements)
        {
            if (index >= Count || index + numberOfElements >= Count)
                return false;

            var newList = new Element[Count - numberOfElements];

            for (int i = 0; i < newList.Length; i++)
            {
                if (i < index)
                    newList[i] = this[i];
                else
                    newList[i] = this[i + numberOfElements];
            }

            _elements = newList;

            return true;
        }


        public bool GetElement(int index, out Element element)
        {
            if (index >= Count)
            {
                element = new Element();
                return false;
            }

            element = _elements[index];

            return true;
        }

        public bool GetList(int index, int numberOfElements, out ElementList list)
        {
            list = new ElementList();

            if (index >= Count || index+numberOfElements>=Count)
            {
                return false;
            };

            for(int i = index; i < index+numberOfElements; i++)
            {
                list.AddElement(this[i]);
            }

            return true;
        }

        public Element Find(string name)
        {
            foreach (var element in _elements)
            {
                if(element.Name == name)
                    return element;
            }

            return new Element();
        }


    }
}
