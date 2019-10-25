using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;

namespace RoleplayGame.Library.Test
{
    public class WizardTests
    {
        [Test]
        public void MagicCreationHealth()
        {
            Character wizard = new Wizard("wizardName");
            Magic magiaPotagia = new Magic();
            int before = wizard.AttackPower;
            int expected = magiaPotagia.AttackPower;
            wizard.AddItem(magiaPotagia);
            int after = wizard.AttackPower;
            Assert.AreEqual(expected, after - before);
        }
         [Test]
        [TestCase("Gandalf")]
        public void WizardCreationHealth(string wizardName)
        {
            Character wizard = new Wizard(wizardName);
            int expected1 = 80;
            Assert.AreEqual(expected1, wizard.Health);
        }
        [Test]
        [TestCase("Gandalf")]
        public void WizardCreationTest(string wizardName)
        {
            Character wizard = new Wizard(wizardName);
            Magic expected2 = new Magic();
            Assert.AreEqual(expected2, wizard.Items[0]);
        }
    }
}

