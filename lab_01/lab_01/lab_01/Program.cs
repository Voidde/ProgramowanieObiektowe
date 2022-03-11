using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01
{
    class Ulamek : IComparable<Ulamek>, IEquatable<Ulamek>
    {

        private int Licznik { get => Licznik; set { } }
        private int Mianownik { get => Mianownik; set { } }
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
            if (b.A == 0)
            {
                throw new DivideByZeroException();
            }
            return new Ulamek(a.Licznik * b.Mianownik, a.Mianownik * b.Licznik);
        }
    }



   
        

  


    public class UlamekTests
    {
        public void TestMethod1()
        {
            int Mianownik = 1;
            int Licznik = 2;
            Ulamek x = new Ulamek(Licznik,Mianownik);
        }
        public void TestMethod2()
        {
            int Licznik = -1;
            int Mianownik = -2;
            Ulamek y = new Ulamek(Licznik, Mianownik);
        }
        public void TestMethod3()
        {
            int Licznik = -1;
            int Mianownik = 2;
            Ulamek z = new Ulamek(Licznik, Mianownik);
        }
        public void TestMethod4()
        {
            int Licznik = 1;
            int Mianownik = -2;
            Ulamek v = new Ulamek(Licznik, Mianownik);
             
        }
    }


 }