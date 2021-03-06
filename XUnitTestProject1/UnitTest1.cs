using System;
using Xunit;
using Zoo.Classes;
using Zoo.Interfaces;
using System.Collections.Generic;

namespace ZooTests
{
    public class ZooTests
    {

        SoftShellTurtle softie = new SoftShellTurtle("Softie");
        Sphynx sphynx = new Sphynx("Cleopatra");
        Mouse mouse = new Mouse("Minnie");
        MaineCoon mainie = new MaineCoon("Mainie");
        ScottishFold waffles = new ScottishFold("Waffles");
        SeaTurtle wen = new SeaTurtle("Wen");
        Rat rat = new Rat("Rat");

        /// <summary>
        /// Test that mammals are vertebrates.
        /// </summary>
        [Fact]
        public void ProveConcreteMammalsAreVertebrata()
        {
            Mammal[] mammalObjs = { sphynx, mouse, mainie, waffles, rat };

            for (int i = 0; i < mammalObjs.Length; i++)
            {
                Assert.IsAssignableFrom<Vertebrata>(mammalObjs[i]);
            }
        }

        /// <summary>
        /// All of my concrete classes exhibit inheritance of the base class's interface implementation. I have implemented both the IEatable and IApproachable interfaces in a base class two levels up from each concrete class: Mammal and Reptile. This method tests for whether a SoftShellTurtle object has inherited the implementation of IEatable properties and methods from the Turtle : Reptile class.
        /// </summary>
        [Fact]
        public void MammalsImplementIEdible()
        {
            Mammal[] mammalObjs = { sphynx, mouse, mainie, waffles, rat };

            for (int i = 0; i < mammalObjs.Length; i++)
            {
                Assert.IsType<int>(mammalObjs[i].DeliciousRating);
                Assert.IsType<bool>(mammalObjs[i].Diseased);
                Assert.IsType<bool>(mammalObjs[i].FattyMeat);
                Assert.IsType<string>(mammalObjs[i].ShouldWeEatThis());
            }
        }

        /// <summary>
        /// Tests whether or not Reptile class implements IEdible and IApproachable if derivative classes have inherited the implementation.
        /// </summary>
        [Fact]
        public void ReptilesImplementIEdible()
        {
            Reptile[] reptiles = { softie, wen };

            for (int i = 0; i < reptiles.Length; i++)
            {
                Assert.IsType<int>(reptiles[i].DeliciousRating);
                Assert.IsType<bool>(reptiles[i].Diseased);
                Assert.IsType<bool>(reptiles[i].FattyMeat);
                Assert.IsType<string>(reptiles[i].ShouldWeEatThis());
                Assert.IsAssignableFrom<IEdible>(reptiles[i]);
                Assert.IsAssignableFrom<IApproachable>(reptiles[i]);
            }
        }

        /// <summary>
        /// Test whether Cat class implements the two interfaces and that derivative concrete objects inherit the implementation. 
        /// </summary>
        [Fact]
        public void CatsImplementInterfaces()
        {
            Cat[] cats = { mainie, waffles, sphynx };

            for (int i = 0; i < cats.Length; i++)
            {
                Assert.IsType<bool>(cats[i].LikesAttention);
                Assert.IsType<bool>(cats[i].ReceivedShots);
                Assert.IsType<string>(cats[i].ShouldTouristApproach());
                Assert.IsType<bool>(cats[i].WillBite);
                Assert.IsAssignableFrom<IEdible>(cats[i]);
                Assert.IsAssignableFrom<IApproachable>(cats[i]);
            }
        }

        /// <summary>
        /// Test that that SoftShellTurtle inherits overriden abstract properties Endoskeleton, Brain from Vertebrata class. The first point of override was in the Reptile class.
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

        /// <summary>
        /// This method checks that the Sphynx and Mouse concrete classes inherit the Endoskeleton and Brain properties that were overriden in both the Mammal and Reptile abstract classes.
        /// </summary>
        [Fact]
        public void CheckThatRemainingObjectsInheritOverridenVertebrataProperties()
        {
            string checkAgainstSphynxEndo = sphynx.Endoskeleton;
            string checkAgainstMouseEndo = mouse.Endoskeleton;
            string checkAgainstSphynxBrain = sphynx.Brain;
            string checkAgainstMouseBrain = mouse.Brain;

            Assert.IsType<string>(checkAgainstSphynxEndo);
            Assert.IsType<string>(checkAgainstSphynxBrain);
            Assert.IsType<string>(checkAgainstMouseBrain);
            Assert.IsType<string>(checkAgainstMouseEndo);
        }

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

        /// <summary>
        /// Test that ScottishFold overrides "Playful" from base class Cat when checking its GetDemeanor() method. Since I override the returned string from the base.GetDemeanor() method, I have to to lower case it to fit into my overriden string. Similary, I lower case the base string in the test to fit my expected outcome.
        /// </summary>
        [Fact]
        public void CheckScottishFoldInheritsPlayful()
        {
            string playful = mainie.GetDemeanor().ToLower();
            bool isContained = waffles.GetDemeanor().Contains(playful);
            Assert.True(isContained);
        }

        /// <summary>
        /// This method tests that ScotishFold overrides base.Moves(). ScottishFold inherits part of Moves() from base Cat class. Moves() in a non-overriden derivative object would return "Normally, cats are graceful animals. They move like ballerinas." This method will test whether an object of type Scottish fold contains this string. Even though I've overriden the base behvior in my ScottishFold class, I still use the base.Moves() return value within my newly returned string.
        /// </summary>
        [Fact]
        public void CheckScottishFoldMoves()
        {
            string baseString = mainie.Moves();
            bool isContained = waffles.Moves().Contains(baseString);
            string newString = waffles.Moves();
            Assert.True(isContained);
            Assert.NotEqual(baseString, newString);
        }

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

        /// <summary>
        /// Test whether concrete Rat object inherits Vertebrata's VertebrateGretting method.
        /// </summary>
        [Fact]
        public void CheckVertebrateGrettingInherited()
        {
            string vertebrateGreeting = "I have a spine!";
            string checkAgainst = rat.VertebrateGretting();
            Assert.Equal(vertebrateGreeting, checkAgainst);
        }

        /// <summary>
        /// Test whether instances of the Rat concrete class have a suspected AvgLifeSpanInYears property == 1. This is because I get the property value based on the base.AvgLifeSpanInYears - 4, which should gives me int 1. This also proves polymorphism.
        /// </summary>
        [Fact]
        public void CheckAvgLifeSpanOfMouse()
        {
            int lifeSpan = rat.AvgLifeSpanInYears;
            int expected = 1;
            Assert.IsType<int>(lifeSpan);
            Assert.Equal(expected, lifeSpan);
        }

        /// <summary>
        /// This method tests for polymorphism. One key aspect of polymorphism is that base classes may define virtual methods that may be overriden by the derivative class. A SeaTurtle object's GetSkinType() returns a different value from Reptile's GetSkinType(). The SeaTurtle class does not override the GetSkinType() method from its base Turtle class. It simply inherits it. So, this test actually proves that the Turtle class has overriden GetSkinType(). I can't instantiate a new Reptile since it's an abstract class, so I hardcode the test value to check against.
        /// </summary>
        [Fact]
        public void TurtleOverridesGetSkinTypeMethodFromReptileBaseClass()
        {
            string reptileGetSkinType = "Has scales";
            string seaTurtleGetSkinType = wen.GetSkinType();

            Assert.NotEqual(reptileGetSkinType, seaTurtleGetSkinType);
        }
    }
}
