using System;
using Xunit;
using Zoo.Classes;

namespace ZooTests
{
    public class ZooTests
    {

        SoftShellTurtle softie = new SoftShellTurtle("Softie");

        // Test that all concrete classes inherit properties Endoskeleton, Brain
        [Fact]
        public void InheritsVertebrataProperty1()
        {
            Assert.IsType<string>(softie.Endoskeleton);
        }

        [Fact]
        public void InheritsVertebrataProperty2()
        {
            Assert.IsType<string>(softie.Brain);
        }
    }
}
