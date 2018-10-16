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
        /// Test that ScottishFold inherits "Playful" from base class Cat when checking its GetDemeanor() method. Since I override the return string to have a lower cased version of the base string, I similary lower case the base string in the test.
        /// </summary>
        [Fact]
        public void CheckScottishFoldInheritsPlayful()
        {
            string playful = mainie.GetDemeanor().ToLower();
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

        SeaTurtle wen = new SeaTurtle("Wen");

        /// <summary>
        /// Test that a SeaTurtle object inherits its MovingSpeed property from Turtle base class.
        /// </summary>
        [Fact]
        public void SeaTurtleInheritsMovingSpeedFromTurtle()
        {
            string movingSpeed = "Slow";
            string checkAgainst = wen.MovingSpeed;
            Assert.Equal(movingSpeed, checkAgainst);
        }

        /// <summary>
        /// Test that SeaTurtle object inherits the property Endoskeleton that was overriden in Reptile class, which is two layers of inheritance above the SeaTurtle class.
        /// </summary>
        [Fact]
        public void SeaTurtleInheritsUnalteredEndoskeleton()
        {
            string hasABackbone = "Has a backbone";
            string checkAgainst = wen.Endoskeleton;
            Assert.Equal(hasABackbone, checkAgainst);
        }

        Rat rat = new Rat("Rat");

        /// <summary>
        /// Test whether concrete Rat object inherits 
        /// </summary>
        [Fact]
        public void CheckVertebrateGrettingInherited()
        {
            string vertebrateGreeting = "I have a spine!";
            string checkAgainst = rat.VertebrateGretting();
            Assert.Equal(vertebrateGreeting, checkAgainst);
        }

        /// <summary>
        /// Test whether instances of the Rat concrete class have a suspected AvgLifeSpanInYears property == 1. This is because I get the property value based on the inherited base.AvgLifeSpanInYears - 4, which should gives me int 1.
        /// </summary>
        [Fact]
        public void CheckAvgLifeSpanOfMouse()
        {
            int lifeSpan = rat.AvgLifeSpanInYears;
            int expected = 1;
            Assert.IsType<int>(lifeSpan);
            Assert.Equal(expected, lifeSpan);
        }
    }
}
