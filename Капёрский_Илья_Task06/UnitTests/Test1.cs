using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace Task1_Test
{
    [TestClass]
    public class Task1_Test
    {
        /// <summary>
        ///  Проверка создания списка
        /// </summary>
        [TestMethod]
        public void GeneratePeople1()
        {
            People P = new People();
            Assert.IsNotNull(P);
        }

        /// <summary>
        ///  Проверка удаления каждого второго
        /// </summary>
        [TestMethod]
        public void CountPeople1(int n)
        {
            People P = new People();
            P.Count(n);
            Assert.AreEqual(1, P.Print(n));
        }

        
    }
}
