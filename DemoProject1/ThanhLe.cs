﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoProject1
{
    [TestClass]
    public class ThanhLe
    {
        [TestMethod]
        public void TestMethod2_ThanhLe2()
        {
            Console.WriteLine("Welcome Thanh 2");

            Console.WriteLine("Thanh 2 says Hello!");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Hello Thanh 1");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Console.WriteLine("Hello Thanh 3");
        }
    }
}
