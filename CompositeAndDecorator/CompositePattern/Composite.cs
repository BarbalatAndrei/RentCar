using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.CompositeAndDecorator.CompositePattern
{
    public class Composite: ICar
    {
        public List<ICar> _elements = new List<ICar>();
        public double price = 0;
        public string fullElements = "";
        public string retElem = "";
        public int count = 0;
        public double getElementPrice()
        {
            foreach (var elem in _elements)
            {
                price += elem.getElementPrice();
            }

            return price;
        }

        public string showElementDetail(int el)
        {
            foreach (var elem in _elements)
            {
                if(count == el)
                {
                    retElem = elem.showElementDetail(el);
                    count++;
                } 
                else
                {
                    count++;
                }
            }

            count = 0;
            return retElem;
        }

        public void addElement(ICar elem)
        {
            _elements.Add(elem);
        }

        public void removeElement(ICar elem)
        {
            _elements.Remove(elem);
        }

        public string showFullElements()
        {
            foreach (var elem in _elements)
            {
                fullElements += elem.showFullElements();
            }

            return fullElements;
        }

        public List<ICar> getElements()
        {
            return this._elements;
        }
    }
}
