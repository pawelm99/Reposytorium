using System;

namespace ConsoleApp12
{
    public class Person : ICloneable, IComparable<Person>, IPrintable
    {
        public int _id;
        public string _name;
        private int[] LiczbyCałkowite;


        public Person(int id, string name, int[] liczbyCałkowite)
        {
            _id = id;
            _name = name;
            LiczbyCałkowite = liczbyCałkowite;
        }

        public object Clone()
        {
            Person other = (Person) this.MemberwiseClone();
            return other;
        }

        public Person DeepCopy()
        {
            Person other = (Person) this.MemberwiseClone();
            other.LiczbyCałkowite = LiczbyCałkowite;
            other._name = String.Copy(_name);
            return other;
        }

        public int CompareTo(Person other)
        {
            if (other == null)
                return 1;

            else
                return this._name.CompareTo(other._name);
            


            /*if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var idComparison = _id.CompareTo(other._id);
            if (idComparison != 0) return idComparison;
            return string.Compare(_name, other._name, StringComparison.Ordinal);*/
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