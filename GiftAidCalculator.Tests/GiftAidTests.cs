using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using GiftAidCalculator.TestConsole;
using GiftAid.BAL;
using GiftAid.DAL;
namespace GiftAidCalculator.Tests
{
    [TestFixture]
    public class GiftAidTests
    {
        ITaxCalculator taxCalc;
        private void setup()
        {
            taxCalc = new TaxCalculator(new TaxRepository(), new SupplementRepository());
        }
        [Test]
        public void story1_validate_default_rate()
        {
            setup();
               var expectedOutput = 25;
            var result = taxCalc.GiftAidAmount(100,string.Empty);
            Assert.AreEqual(expectedOutput, result);
        }
                
        [Test]
        public void story3_validate_2_decimal_points_giftaid()
        {
            setup();
            var expectedOutput = 6.38;
            //decimal input = decimal.Round(25.5, 1,MidpointRounding.AwayFromZero);
            var result = taxCalc.GiftAidAmount(25.5m,string.Empty);
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void story4_taxrate_added_5pecent_for_running_event()
        {
            setup();
            var expectedOutput = 33.33;
            var result = taxCalc.GiftAidAmount(100, "running");
            Assert.AreEqual(expectedOutput, result);
        }

        
        [Test]
        public void story4_taxrate_added_3pecent_for_swimming_event()
        {
            setup();
            var expectedOutput = 29.87;
            var result = taxCalc.GiftAidAmount(100, "swimming");
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void story4_taxrate_added_3pecent_for_other_event()
        {
            setup();
            var expectedOutput = 25;
            var result = taxCalc.GiftAidAmount(100, "other");
            Assert.AreEqual(expectedOutput, result);
        }
    }
}
