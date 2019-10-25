using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class CharacterTest
    {
        [Test]
        public void TestCharacterCreationWithMagicDefensePowerIncreases()
        {
            Character character = new Troll("Character");
            int expectedBefore = 15;
            Assert.AreEqual(expectedBefore, character.DefensePower);
            Magic magic = new Magic();
            character.AddItem(magic);
            int expectedAfter = 45;
            Assert.AreEqual(expectedAfter, character.DefensePower);
        }

    }
}