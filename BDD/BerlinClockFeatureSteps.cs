using System;
using TechTalk.SpecFlow;
using NUnit;
using NUnit.Framework;
using System.Linq;
using BerlinClock.Classes;

namespace BerlinClock
{
    [Binding]
    public class TheBerlinClockSteps
    {
        private BerlinClockFeatureTime berlinClock = new BerlinClockFeatureTime();
        private String TheTime;


        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeIs(string Time)
        {
            TheTime = Time;
        }
        
        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string theExpectedBerlinClockOutput)
        {
            Assert.AreEqual(theExpectedBerlinClockOutput, berlinClock.BerlinClockOutput(TheTime));
        }

    }
}
