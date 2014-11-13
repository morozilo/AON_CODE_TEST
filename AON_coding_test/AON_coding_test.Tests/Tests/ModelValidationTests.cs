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
    public class ModelTest
    {

        // Testing successful execution and then checking that correct view is called (DisplayResults)
        [TestMethod]
        public void TestStringManipulationSucces()
        {

            var controller = new HomeController();

            var model = new StringModel()
            {
                InputString = "ABCD",
                StartIndex = 2,
                EndIndex = 4
            };

            var result = controller.DisplayResults(model) as ViewResult;
            Assert.IsTrue(String.Equals("DisplayResults", result.ViewName, StringComparison.InvariantCultureIgnoreCase));

        }

        // testing scenario when Input string is empty
        [TestMethod]
        public void TestValidateModelError_InputIsEmpty()
        {

            var controller = new HomeController();

            var model = new StringModel()
            {
                InputString = "",
                StartIndex = 10,
                EndIndex = 2
            };

            var valCtx = new System.ComponentModel.DataAnnotations.ValidationContext(model);

            var validfationResult = model.Validate(valCtx);

            foreach (var a in validfationResult)
            {
                Console.WriteLine(a.ErrorMessage);
            }
            Assert.AreEqual(validfationResult.Count(), 1);

        }

        // testing scenario when start index is 0
        [TestMethod]
        public void TestValidateModelError_StartIndexIsEmpty()
        {

            var controller = new HomeController();

            var model = new StringModel()
            {
                InputString = "ABCD",
                StartIndex = 0,
                EndIndex = 2
            };

            var valCtx = new System.ComponentModel.DataAnnotations.ValidationContext(model);

            var validfationResult = model.Validate(valCtx);

            foreach (var a in validfationResult)
            {
                Console.WriteLine(a.ErrorMessage);
            }
            Assert.AreEqual(validfationResult.Count(), 0);

        }


        // testing scenario when end index is 0
        [TestMethod]
        public void TestValidateModelError_EndIndexIsEmpty()
        {

            var controller = new HomeController();

            var model = new StringModel()
            {
                InputString = "ABCD",
                StartIndex = 2,
                EndIndex = 0
            };

            var valCtx = new System.ComponentModel.DataAnnotations.ValidationContext(model);

            var validfationResult = model.Validate(valCtx);

            foreach (var a in validfationResult)
            {
                Console.WriteLine(a.ErrorMessage);
            }
            Assert.AreEqual(validfationResult.Count(), 1);

        }

        // testing scenario when start index is greater than end index
        [TestMethod]
        public void TestValidateModelError_StartPosIsGreatThatEndPos()
        {

            var controller = new HomeController();

            var model = new StringModel()
            {
                InputString = "ABCD",
                StartIndex = 4,
                EndIndex = 2
            };

            var valCtx = new System.ComponentModel.DataAnnotations.ValidationContext(model);

            var validfationResult = model.Validate(valCtx);


            foreach (var a in validfationResult)
            {
                Console.WriteLine(a.ErrorMessage);
            }
            Assert.AreEqual(validfationResult.Count(), 1);


        }

        // testing scenaro when end index is greater that input string length
        [TestMethod]
        public void TestValidateModelError_EndPosIsGreatThanStrLength()
        {

            var controller = new HomeController();

            var model = new StringModel()
            {
                InputString = "ABCD",
                StartIndex = 2,
                EndIndex = 7
            };

            var valCtx = new System.ComponentModel.DataAnnotations.ValidationContext(model);

            var validfationResult = model.Validate(valCtx);


            foreach (var a in validfationResult)
            {
                Console.WriteLine(a.ErrorMessage);
            }
            Assert.AreEqual(validfationResult.Count(), 1);


        }

        // testing scenaro when start index is greater that input string length
        [TestMethod]
        public void TestValidateModelError_StartPosIsGreatThanStrLength()
        {

            var controller = new HomeController();

            var model = new StringModel()
            {
                InputString = "ABCD",
                StartIndex = 7,
                EndIndex = 3
            };

            var valCtx = new System.ComponentModel.DataAnnotations.ValidationContext(model);

            var validfationResult = model.Validate(valCtx);


            foreach (var a in validfationResult)
            {
                Console.WriteLine(a.ErrorMessage);
            }
            Assert.AreEqual(validfationResult.Count(), 2);


        }
    }
}
