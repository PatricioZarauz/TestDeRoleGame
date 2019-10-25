using NUnit.Framework;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class MagicStickTest
    {
        [Test]
        public void TestMagicStickDefensePower()
        {
            MagicStick magicStick = new MagicStick();
            int expected = 30;
            Assert.AreEqual(expected, magicStick.DefensePower);
        }
    }
}