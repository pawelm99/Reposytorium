using System;
using System.Linq;

namespace ConsoleApp12
{
    public class Person : ICloneable, IComparable<Person>, IPrintable
    {
        public int _id;
        public string _name;
        public int[] LiczbyCałkowite;


        public override string ToString()
        {
            return $"{nameof(_id)}: {_id}, {nameof(_name)}: {_name}, {nameof(LiczbyCałkowite)}: {LiczbyCałkowite}";
        }

        public Person(int id, string name, int[] liczbyCałkowite)
        {
            _id = id;
            _name = name;
            LiczbyCałkowite = liczbyCałkowite;
        }

        
        public object Clone()
        {
            int[] tab = new int[LiczbyCałkowite.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = this.LiczbyCałkowite[i];
            }
            Person other = new Person(_id, _name, tab);
           return other;
        }

        public Person DeepCopy()
        {
            Person other = (Person) MemberwiseClone();
            other.LiczbyCałkowite = LiczbyCałkowite;
            other._name = String.Copy(_name);
            return other;
        }

        /*public int CompareTo(Person other)
        {
            if (other == null)
                return 1;

            else
                return this._name.CompareTo(other._name);
            


            /*if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var idComparison = _id.CompareTo(other._id);
            if (idComparison != 0) return idComparison;
            return string.Compare(_name, other._name, StringComparison.Ordinal);#1#
        }*/
        public int CompareTo(Person comparePart)
        {
            // A null value means that this object is greater.
            if (comparePart == null)
                return 1;

            else

              return this._name.CompareTo(comparePart._name);
        }
       

        public void Print()
        {
            Console.WriteLine($"{nameof(_id)}: {_id}, {nameof(_name)}: {_name}");
            Console.WriteLine("Liczby całkowite: ");
            for (int i = 0; i < LiczbyCałkowite.Length; i++)
            {
                Console.Write("{0} ", LiczbyCałkowite[i]);
            }

            Console.WriteLine();
        }
    }
}