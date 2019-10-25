using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class TrollTest
    {
        [Test]
        public void TestTrollCreationLife150withArmourAndStick()
        {
            Troll troll = new Troll("Troll");
            int lifeExpected = 150;
            bool hasArmor = false;
            bool hasStick = false;
            foreach(IItem item in troll.Items)
            {
                if(item.ToString().Equals("Stick"))
                {
                    hasStick = true;
                }
                else if (item.ToString().Equals("Armor"))
                {
                    hasArmor = true;
                }
            }
            Assert.AreEqual(true, hasArmor);
            Assert.AreEqual(true, hasStick);
            Assert.AreEqual(lifeExpected, troll.Health);
        }
    }
}