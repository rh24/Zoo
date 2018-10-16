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

        ScottishFold waffles = new ScottishFold("Waffles");

        /// <summary>
        /// Test that ScottishFold inherits "Playful" from base class Cat when checking its GetDemeanor() method.
        /// </summary>
        [Fact]
        public void CheckScottishFoldInheritsPlayful()
        {
            string playful = mainie.GetDemeanor();
            bool isContained = waffles.GetDemeanor().Contains(playful);
            Assert.True(isContained);
        }

        /// <summary>
        /// Test that ScottishFold inherits part of Moves() from base Cat class. Moves() in a non-overriden derivative object would return "Normally, cats are graceful animals. They move like ballerinas." This method will test whether an object of type Scottish fold contains this string. Even though I've overriden the base behvior in my ScottishFold class, I still use the base.Moves() return value within my newly returned string.
        /// </summary>
        [Fact]
        public void CheckScottishFoldMoves()
        {
            string baseString = mainie.Moves();
            bool isContained = waffles.Moves().Contains(baseString);
            Assert.True(isContained);
        }
    }
}
