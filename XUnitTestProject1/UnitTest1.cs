using System;
using Xunit;
using Zoo.Classes;

namespace ZooTests
{
    public class ZooTests
    {

        SoftShellTurtle softie = new SoftShellTurtle("Softie");

        /// <summary>
        /// Test that that SoftShelTurtle overrides inherited abstract properties Endoskeleton, Brain from Vertebrata class.
        /// </summary>
        [Fact]
        public void InheritsVertebrataProperty1()
        {
            string checkAgainst = softie.Endoskeleton;
            Assert.IsType<string>(checkAgainst);
        }

        [Fact]
        public void InheritsVertebrataProperty2()
        {
            string checkAgainst = softie.Brain;
            Assert.IsType<string>(checkAgainst);
        }


        MaineCoon mainie = new MaineCoon("Mainie");

        /// <summary>
        /// MaineCoon inherits its GetDemeanor method from base Cat class. GetDemeanor() => "Playful"
        /// </summary>
        [Theory]
        [InlineData("Playful")]
        public void CheckMaineCoonDemeanor(string expected)
        {
            string checkAgainst = mainie.GetDemeanor();
            Assert.Equal(expected, checkAgainst);
        }

        /// <summary>
        /// This method will test that MaineCoon inherits its MakeSound() => "Meow" from its base Cat class as well.
        /// </summary>
        [Theory]
        [InlineData("Meow")]
        public void CheckMaineCoonMakeSound(string expected)
        {
            string checkAgainst = mainie.MakeSound();
            Assert.Equal(expected, checkAgainst);
        }
    }
}
