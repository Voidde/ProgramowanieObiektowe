using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01
{
    public class Ulamek : IComparable<Ulamek>, IEquatable<Ulamek>
    {

        public int Licznik { get => Licznik; set { } }
        public int Mianownik { get => Mianownik; set { } }
        public Ulamek()
        {

        }
        public Ulamek(int licznik, int mianownik)
        {
            Licznik = licznik;
            Mianownik = mianownik;
        }
        public Ulamek(Ulamek licznik, Ulamek mianownik)
        {
            Licznik = licznik.Licznik;
            Mianownik = mianownik.Mianownik;
        }
        public override string ToString()
        {
            return this.Licznik+"/"+this.Mianownik.ToString();
        }

        public bool Equals(Ulamek other)
        {
            return this.Licznik / this.Mianownik == other.Licznik / other.Mianownik;
        }


        public void Floor(Ulamek other)

        {
            double value = this.Licznik / this.Mianownik;
            Math.Floor(value);
        }
        public void Ceiling(Ulamek other)
        {
            double value = this.Licznik / this.Mianownik;
            Math.Ceiling(value);
        }

        int IComparable<Ulamek>.CompareTo(Ulamek other)
        {
            if (this.Licznik / this.Mianownik == other.Licznik / other.Mianownik) return 1;
            else return 0;
        }

        public static Ulamek operator +(Ulamek a) => a;
        public static Ulamek operator -(Ulamek a) => new Ulamek(-a.Licznik, a.Mianownik);
        public static Ulamek operator *(Ulamek a, Ulamek b)=> new Ulamek(a.Licznik * b.Mianownik, a.Mianownik * b.Mianownik);
        public static Ulamek operator /(Ulamek a, Ulamek b)
        {
            if (b.Licznik == 0)
            {
                throw new DivideByZeroException();
            }
            return new Ulamek(a.Licznik * b.Mianownik, a.Mianownik * b.Licznik);
        }
    }
    public class Program { 
        public static void Main()
        {

        }
    
    }





}