using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;

namespace RoleplayGame.Library.Test
{
    public class RemoveMagicTest
    {
        [Test]
        public void RemoveMagic()
        {
            Character wizard = new Wizard("wizardName");
            Magic magiaPotagia = new Magic();
            int before = wizard.AttackPower;
            wizard.AddItem(magiaPotagia);
            int expected = wizard.AttackPower - magiaPotagia.AttackPower ;
            wizard.RemoveItem(magiaPotagia);
            int after = wizard.AttackPower;
            Assert.AreEqual(expected, after);
        }

    }
}

