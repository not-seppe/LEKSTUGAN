using System;
using Xunit;

namespace LEKSTUGAN
{
    public class UnitTest1
    {
        [Fact]
        public void Test0()
        {
            Assert.Equal(4, 4);
            Assert.Equal(4,4);
            Assert.True(true);
            Assert.False(false);
        }

        [Fact]

        public void Testvar()

        {
            string name;
            bool lever = false;

            if (lever)
            {
                name = "Mr Smith";
            }
            else
            {
                name = "Bj�rn";
            }
        }

        [Fact]

        public void Test1()
        {
            Assert.Equal(5,2+3);
        }

        [Fact]

        public void Test2()
        {
            Assert.True("Jag har fyllt" + 29 == "Jag har fyllt 29");
        }

        [Fact]

        public void Test3()
        {
            int bigNumber = 2147483647;
            int biggerNumber = bigNumber + 1;
            Assert.True(biggerNumber > bigNumber);
        }

        public void Test4()
        {
            string drink;
            int Age = 20;

            if (Age > 18)
            {
                drink = "Beer";
            }
            else
            {
                drink = "Cola";
            }

        }

    }
}