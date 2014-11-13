using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AON_coding_test;
using AON_coding_test.Controllers;
using AON_coding_test.Models;
using StringManipulation;

namespace AON_coding_test.Tests.Tests
{
    [TestClass]
    public class StringManipulationTest
    {
       
        // testing scenario when both start and end indexes fall on the middle of the input string
        [TestMethod]
        public void Test_StringManipulationService_MiddleString()
        {

            StringManipulationService stringManipService = new StringManipulationService();
            var model = new StringModel()
            {
                InputString = "ABCD",
                StartIndex = 2,
                EndIndex = 4
            };

            StringModel model1 = new StringModel();
            model1 = stringManipService.CharSwitch(model);

            Assert.AreEqual("ADCB", model1.InputString);
        }

        // testing scenario when start and end indexes fall on the first and last elements of the input string
        [TestMethod]
        public void Test_StringManipulationService_EndsOfString()
        {

            StringManipulationService stringManipService = new StringManipulationService();
            var model = new StringModel()
            {
                InputString = "ABCD",
                StartIndex = 1,
                EndIndex = 4
            };

            StringModel model1 = new StringModel();
            model1 = stringManipService.CharSwitch(model);

            Assert.AreEqual("DBCA", model1.InputString);
        }

            
    }
}
