using System;
using Xunit;

namespace DesignPatterns
{
    public class Strategy
    {
        [Fact]
        public void Mallard_Duck_Test()
        {
            MallardDuck mallard = new MallardDuck();
            Assert.Equal("looks like a Mallard", mallard.Display());
        }

        [Fact]
        public void Redhead_Duck_Test()
        {
            RedheadDuck redhead = new RedheadDuck();
            Assert.Equal("looks like a Redhead", redhead.Display());
        }
    }

    public abstract class Duck
    {
        public string Quack()
        {
            return "Quack";
        }

        public string Swim()
        {
            return "Swim";
        }

        public abstract string Display();
    }

    public class MallardDuck : Duck
    {
        public override string Display()
        {
            return "looks like a Mallard";
        }
    }

    public class RedheadDuck : Duck
    {
        public override string Display()
        {
            return "looks like a Redhead";
        }  
    }
}
