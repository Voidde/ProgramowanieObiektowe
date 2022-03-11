using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01
{
    class Ulamek : IComparable<Ulamek>, IEquatable<Ulamek>
    {

        private int Licznik { get => Licznik; }
        private int Mianownik { get => Mianownik; }
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
    }



    public readonly struct Fraction
    {
        private readonly int A;
        private readonly int B;

        public Fraction(int a, int b)
        {

            A = a;
            B = b;
        }
        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => new Fraction(-a.A, a.B);
        public static Fraction operator *(Fraction a, Fraction b)
       => new Fraction(a.A * b.B, a.B * b.B);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.A == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.A * b.B, a.B * b.A);
        }

    }


    public class UlamekTests
    {
        public void TestMethod1()
        {
            Ulamek x = new Ulamek (12,2);
        }
        public void TestMethod2()
        {
            Ulamek z = new Ulamek();
        }
        public void TestMethod3()
        {
            Ulamek z = new Ulamek(-1,5);
        }
        public void TestMethod4()
        {
            Ulamek z = new Ulamek(2, 5);
            Ulamek x = new Ulamek(5, 2);
            
             
        }
    }


}