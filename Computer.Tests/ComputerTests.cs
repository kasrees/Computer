using Computer.Components;
using Computer.Components.MotherBoards;
using Computer.Components.PowerUnit;
using Computer.Components.Processors;
using Computer.Components.RandomAccessMemory;
using Computer.Components.VideoCard;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Tests
{
    public class ComputerTests
    {
        [Test]
        public void Computer_GetComponents_ValidComponents_AllComponents()
        {
            List<IComponent> expectedComponents = new List<IComponent>()
            {
                new MsiMotherBoard(),
                new IntelProcessor(),
                new PalitVideoCard(),
                new AeorocoolPowerUnit(),
                new LenovoRandomAccessMemory()
            };

            Computer computer = new Computer(
                new MsiMotherBoard(),
                new IntelProcessor(),
                new PalitVideoCard(),
                new List<RandomAccessMemory> { new LenovoRandomAccessMemory() },
                new AeorocoolPowerUnit(),
                "mATX");

            CollectionAssert.AreEqual(expectedComponents, computer.GetComponents());
        }

        [Test]
        public void Computer_GetComponents_ValidComponents_MoreComponents()
        {
            List<IComponent> expectedComponents = new List<IComponent>()
            {
                new MsiMotherBoard(),
                new IntelProcessor(),
                new PalitVideoCard(),
                new AeorocoolPowerUnit(),
                new LenovoRandomAccessMemory(),
                new LenovoRandomAccessMemory()
            };

            Computer computer = new Computer(
                new MsiMotherBoard(),
                new IntelProcessor(),
                new PalitVideoCard(),
                new List<RandomAccessMemory> { new LenovoRandomAccessMemory() },
                new AeorocoolPowerUnit(),
                "mATX");

            CollectionAssert.AreNotEqual(expectedComponents, computer.GetComponents());
        }

        [Test]
        public void Computer_Constructor_ValidComponent_CreateInstance()
        {
            Computer computer = new Computer(
                new MsiMotherBoard(),
                new IntelProcessor(),
                new PalitVideoCard(),
                new List<RandomAccessMemory> { new LenovoRandomAccessMemory() },
                new AeorocoolPowerUnit(),
                "mATX");

            Assert.That(computer, Is.Not.Null);
        }

        [Test]
        public void Computer_Constructor_InvalidMotherBoard_ThrowArgumentExeption()
        {
            Assert.Throws<ArgumentException>(() => new Computer(
                new CustomMotherBoard("Asus", "SomeModel", "ATX", "LGA1200", "Intel B560", 3200, 2, 64, true),
                new IntelProcessor(),
                new PalitVideoCard(),
                new List<RandomAccessMemory> { new LenovoRandomAccessMemory() },
                new AeorocoolPowerUnit(),
                "mATX"));
        }

        [Test]
        public void Computer_Constructor_InvalidProcessor_ThrowArgumentExeption()
        {
            Assert.Throws<ArgumentException>(() => new Computer(
                new MsiMotherBoard(),
                new CustomProcessor("Intel", "Core i5 10400F", 6, 2900, "LGA 1150"),
                new PalitVideoCard(),
                new List<RandomAccessMemory> { new LenovoRandomAccessMemory() },
                new AeorocoolPowerUnit(),
                "mATX"));
        }

        [Test]
        public void Computer_Constructor_InvalidVideoCard_ThrowArgumentExeption()
        {
            Assert.Throws<ArgumentException>(() => new Computer(
                new MsiMotherBoard(),
                new IntelProcessor(),
                new CustomVideoCard("Palit", "PA-RTX3060 DUAL 12G", "NVIDIA GeForce RTX 3060", 1320, 12, "GDDR6", 15000, 650),
                new List<RandomAccessMemory> { new LenovoRandomAccessMemory() },
                new AeorocoolPowerUnit(),
                "mATX"));
        }

        [Test]
        public void Computer_Constructor_InvalidAmountOfRandomAccessMemory_ThrowArgumentExeption()
        {
            Assert.Throws<ArgumentException>(() => new Computer(
                new MsiMotherBoard(),
                new IntelProcessor(),
                new PalitVideoCard(),
                new List<RandomAccessMemory> { new LenovoRandomAccessMemory(), new LenovoRandomAccessMemory(), new LenovoRandomAccessMemory() },
                new AeorocoolPowerUnit(),
                "mATX"));
        }

        [Test]
        public void Computer_Constructor_InvalidMaxMemorySizeOfRandomAccessMemory_ThrowArgumentExeption()
        {
            Assert.Throws<ArgumentException>(() => new Computer(
                new MsiMotherBoard(),
                new IntelProcessor(),
                new PalitVideoCard(),
                new List<RandomAccessMemory>
                {
                    new CustomRandomAccessMemory("Lenovo", "4ZC7A08708", "DDR4", 2933, 64),
                    new CustomRandomAccessMemory("Lenovo", "4ZC7A08708", "DDR4", 2933, 64)
                },
                new AeorocoolPowerUnit(),
                "mATX"));
        }

        [Test]
        public void Computer_Constructor_InvalidMaxFrequencyOfRandomAccessMemory_ThrowArgumentExeption()
        {
            Assert.Throws<ArgumentException>(() => new Computer(
                new MsiMotherBoard(),
                new IntelProcessor(),
                new PalitVideoCard(),
                new List<RandomAccessMemory>
                {
                    new CustomRandomAccessMemory("Lenovo", "4ZC7A08708", "DDR4", 4800, 16),
                    new CustomRandomAccessMemory("Lenovo", "4ZC7A08708", "DDR4", 4800, 16)
                },
                new AeorocoolPowerUnit(),
                "mATX"));
        }
    }
}
