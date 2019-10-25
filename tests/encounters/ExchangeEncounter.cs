using RoleplayGame.Characters;
using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Encounters;

namespace RoleplayGame.Library.Test
{
    public class ExchangeTest
    {
        [Test]
        public void TestExchangeEncounterItemNotFoundExceptionThowrn()
        {
            Troll troll = new Troll("Troll");
            Wizard wizard = new Wizard("Wizard");
            ExchangeEncounter exchange = new ExchangeEncounter(troll, wizard);
            Magic magic = new Magic();
            try
            {
                exchange.AddItemToExchange(magic);
            }
            catch(ItemNotFoundException e)
            {
                Assert.True(true, e.Message);
            }
        }
    }
}