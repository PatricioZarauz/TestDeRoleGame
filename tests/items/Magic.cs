using RoleplayGame.Characters;
using NUnit.Framework;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class MagicTest
    {
        [Test]
        public void TestRemoveMagicAndDefensePowerDecreases()
        {
            Character character = new Troll("Troll");
            Magic magic = new Magic();
            character.AddItem(magic);
            int expectedBefore = 45;
            Assert.AreEqual(expectedBefore, character.DefensePower);
            character.RemoveItem(magic);
            int expectedAfter = 15;
            Assert.AreEqual(expectedAfter, character.DefensePower);
        }
    }
}