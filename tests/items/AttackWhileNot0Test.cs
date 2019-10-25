using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;
using RoleplayGame.Encounters;

namespace RoleplayGame.Library.Test
{
    public class AttackWhileNot0
    {
        [Test]
        [TestCase(10000)]
        public void AttackWhileNot0Test(int ataque)
        {
            Character wizard = new Wizard("wizardName1");
            wizard.ReceiveAttack(80);
            /// <summary>
            /// wizard queda en 0
            /// </summary>
            wizard.ReceiveAttack(ataque);
            int expected = 0;
            Assert.AreEqual(expected, wizard.Health);
        }

    }
}

