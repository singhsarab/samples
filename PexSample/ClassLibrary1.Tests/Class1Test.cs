// <copyright file="Class1Test.cs">Copyright ©  2016</copyright>
using System;
using ClassLibrary1;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary1.Tests
{
    /// <summary>This class contains parameterized unit tests for Class1</summary>
    [PexClass(typeof(Class1))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class Class1Test
    {
        /// <summary>Test stub for IsLeapYear(Int32)</summary>
        [PexMethod]
        public bool IsLeapYearTest(int year)
        {
            bool result = Class1.IsLeapYear(year);
            return result;
            // TODO: add assertions to method Class1Test.IsLeapYearTest(Int32)
        }
    }
}
