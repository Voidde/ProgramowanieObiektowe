using System;
using Xunit;
using lab_01;

namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int Licznik = 1;
            int Mianownik = 2;
            Ulamek x = new Ulamek(Licznik, Mianownik);
            Assert.Equal(1, x.Licznik);
            Assert.Equal(2, x.Mianownik);

        }
        [Fact]
        public void Test2()
        {
            int Licznik = -1;
            int Mianownik = -2;
            Ulamek x = new Ulamek(Licznik, Mianownik);
            Assert.Equal(-1, x.Licznik);
            Assert.Equal(-2, x.Mianownik);
        }
        [Fact]
        public void Test3()
        {
            int Licznik = 1;
            int Mianownik = -2;
            Ulamek x = new Ulamek(Licznik, Mianownik);
            Assert.Equal(1, x.Licznik);
            Assert.Equal(-2, x.Licznik);
        }
        [Fact]
        public void Test4()
        {
            int Licznik = -1;
            int Mianownik = 2;
            Ulamek x = new Ulamek(Licznik, Mianownik);
            Assert.Equal(-1, x.Licznik);
            Assert.Equal(2, x.Licznik);
        }
        [Fact]
        public void Test5()
        {
            Ulamek x = new Ulamek(1, 2);
            Ulamek y = new Ulamek(2, 4);
            Equals(x, y);
            
        }
        [Fact]
        public void Test6()
        {
            Ulamek x = new Ulamek(1, 2);
            Ulamek y = new Ulamek(1, 2);
            Equals(x, y);
            
        }
    }
}
