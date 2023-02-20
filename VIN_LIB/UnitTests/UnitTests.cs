using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VIN_LIB;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        // Тестовые методы низкой сложности
        // Тест, на проверку, что метод для определения корректности вин номера вычисляет правиильно
        [TestMethod]
        public void CheckVIN_Correctly()
        {
            string vin = "JHMCM56557C404453";
            bool actual = Class1.CheckVIN(vin);
            Assert.IsTrue(actual);
        }
        // Тест, на проверку, что метод для определения корректности вин номера не считает не правильный результат верным
        [TestMethod]
        public void CheckVIN_NotCorrectlyDontTrue()
        {
            string vin = "OHMCM56557C404453";
            bool actual = Class1.CheckVIN(vin);
            Assert.IsFalse(actual);
        }
        // Тест, на проверку, что метод для определения корректности вин номера учитывает что в конце должны быть 4 цифры
        [TestMethod]
        public void CheckVIN_EndFourNumber()
        {
            bool correct = false;
            string vin = "HHMCM56557C4044G3";
            bool actual = Class1.CheckVIN(vin);
            Assert.AreEqual(correct, actual);
        }
        // Тест, на проверку, что метод для определения корректности вин номера выводит результат в верном типе
        [TestMethod]
        public void CheckVIN_CorrectlyType()
        {
            string vin = "KFFCF52557C401113";
            bool actual = Class1.CheckVIN(vin);
            Assert.IsInstanceOfType(actual, typeof(bool));
        }

        // Тест, на проверку, что метод который выводит континент по вин номеру, выводит коррректный результат
        [TestMethod]
        public void GetVINCountry_Correctly()
        {
            string correct = "Азия";
            string vin = "JHMCM56557C404453";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(correct, actual);
        }
        // Тест, на проверку, что метод который выводит континент по вин номеру, выводит результат котрый не является верным
        [TestMethod]
        public void GetVINCountry_NotCorrectly()
        {
            string correct = "Южная Америка";
            string vin = "FFLTJRI5794965678";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreNotEqual(correct, actual);
        }
        // Тест, на проверку, что метод который выводит континент по вин номеру, выводит результат с правильным типом данных
        [TestMethod]
        public void GetVINCountry_CorrectlyType()
        {
            string vin = "FFLTJRI5794965678";
            string actual = Class1.GetVINCountry(vin);
            Assert.IsInstanceOfType(actual, typeof(string));
        }
        // Тест, на проверку, что метод который выводит континент по вин номеру, выводит коррректный результат с числами
        [TestMethod]
        public void GetVINCountry_CorrectlyNumber()
        {
            string correct = "Северная Америка";
            string vin = "56JHMCM565C404453";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(correct, actual);
        }
        // Тест, на проверку, что метод для определения корректности вин номера вычисляет правиильно если передан параметр состоящий только из цифр
        [TestMethod]
        public void CheckVIN_CorrectlyNumber()
        {
            string vin = "12345678919748929";
            bool actual = Class1.CheckVIN(vin);
            Assert.IsTrue(actual == true);
        }
        // Тест, на проверку, что метод который выводит континент по вин номеру, выводит коррректный результат с крайнем значением
        [TestMethod]
        public void GetVINCountry_CorrectlyExtremeValue()
        {
            string correct = "Южная Америка";
            string vin = "99JHMCM565C404453";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(correct, actual);
        }


        // Методы высокой сложности
        // Тест, на проверку, что метод для определения корректности номера выдёт корректное значение если передана пустая строка
        [TestMethod]
        public void CheckVIN_EmptyParametr()
        {
            bool correct = false;
            string vin = "";
            bool actual = Class1.CheckVIN(vin);
            Assert.IsTrue(correct == actual);
        }
        // Тест, на проверку, что метод который выводит континент по вин номеру, если принимает неверный параметр, то не выводит пустое значение
        [TestMethod]
        public void GetVINCountry_EmptyVin()
        {
            string vin = "";
            string actual = Class1.GetVINCountry(vin);
            Assert.IsNotNull(actual);
        }
        // Тест, на проверку, что метод который выводит континент по вин номеру, если передан неверный формат вин номера выводит корректное значение
        [TestMethod]
        public void GetVINCountry_NotCorrectlyVin()
        {
            string vin = "OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO";
            string actual = Class1.GetVINCountry(vin);
            Assert.IsTrue(actual == "");
        }
        // Тест, на проверку, что метод для определения корректности номера выдёт корректное значение если передана очень большая строка
        [TestMethod]
        public void CheckVIN_CorrectlyLargeData()
        {
            string vin = "";
            for (int i = 0; i < 10000; i++)
            {
                vin += i;
            }
            bool actual = Class1.CheckVIN(vin);
            Assert.IsFalse(actual);
        }
        // Тест, на проверку, что метод который выводит континент по вин номеру, если принимает пустой параметр, то не выводит какой-либо континент
        [TestMethod]
        public void GetVINCountry_NullVin()
        {
            string correct = "";
            string vin = null;
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(correct, actual);
        }
    }
}
