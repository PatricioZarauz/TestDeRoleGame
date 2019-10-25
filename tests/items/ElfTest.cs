using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;

namespace RoleplayGame.Library.Test
{
    public class ElfTest
    {
        [Test]
        [TestCase("Gandalf")]
        public void ElfCreationHealth(string elfName)
        {
            Character elf = new Elf(elfName);
            int expected1 = 120;
            Assert.AreEqual(expected1, elf.Health);
        }
        [Test]
        [TestCase("Gandalf")]
        public void ElfCreationRobe(string elfName)
        {
            Character elf = new Elf(elfName);
            Robes expected2 = new Robes();
            Assert.AreEqual(expected2, elf.Items[0]);
        }
    }
}

