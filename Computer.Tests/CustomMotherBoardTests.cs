using Computer.Components.MotherBoards;
using NUnit.Framework;
using System;

namespace Computer.Tests
{
    public class CustomMotherBoardTests
    {
        [Test]
        public void CustomMotherBoard_Constructor_NotNullValues_CreateInstance()
        {
            CustomMotherBoard motherBoard = new("Manufacturer", "Model", "form", "socket", "chipset", 2000, 2, 20, true);

            Assert.That(motherBoard, Is.Not.Null);
        }

        [Test]
        public void CustomMotherBoard_Constructor_PositiveInt_CreateInstance()
        {
            CustomMotherBoard motherBoard = new("Manufacturer", "Model", "form", "socket", "chipset", 2000, 2, 20, true);

            Assert.That(motherBoard, Is.Not.Null);
        }

        [Test]
        public void CustomMotherBoard_Constructor_NullManufacturer_ThrowArguemtNullExeption()
        {
            Assert.Throws<ArgumentNullException>(() => new CustomMotherBoard(null, "Model", "form", "socket", "chipset", 2000, 2, 20, true));
        }

        [Test]
        public void CustomMotherBoard_Constructor_NullModel_ThrowArguemtNullExeption()
        {
            Assert.Throws<ArgumentNullException>(() => new CustomMotherBoard("Manufacturer", null, "form", "socket", "chipset", 2000, 2, 20, true));
        }

        [Test]
        public void CustomMotherBoard_Constructor_NullFormFactor_ThrowArguemtNullExeption()
        {
            Assert.Throws<ArgumentNullException>(() => new CustomMotherBoard("Manufacturer", "Model", null, "socket", "chipset", 2000, 2, 20, true));
        }

        [Test]
        public void CustomMotherBoard_Constructor_NullSocket_ThrowArguemtNullExeption()
        {
            Assert.Throws<ArgumentNullException>(() => new CustomMotherBoard("Manufacturer", "Model", "form", null, "chipset", 2000, 2, 20, true));
        }

        [Test]
        public void CustomMotherBoard_Constructor_NullChipset_ThrowArguemtNullExeption()
        {
            Assert.Throws<ArgumentNullException>(() => new CustomMotherBoard("Manufacturer", "Model", "form", "socket", null, 2000, 2, 20, true));
        }

        public void CustomMotherBoard_Constructor_NegativeMaxMemoryFrequency_ThrowArguemtNullExeption()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new CustomMotherBoard("Manufacturer", "Model", "form", "socket", "chipset", -1, 2, 20, true));
        }

        public void CustomMotherBoard_Constructor_NegativeMemorySlots_ThrowArguemtNullExeption()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new CustomMotherBoard("Manufacturer", "Model", "form", "socket", "chipset", 2000, -2, 20, true));
        }

        public void CustomMotherBoard_Constructor_NegativeMaxMemorySizeGB_ThrowArguemtNullExeption()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new CustomMotherBoard("Manufacturer", "Model", "form", "socket", "chipset", 2000, 2, -20, true));
        }
    }
}