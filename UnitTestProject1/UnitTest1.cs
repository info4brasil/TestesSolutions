using System;
using System.Diagnostics;
using FluentValidation.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelFluent;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Usuario customer = new Usuario();
            UserMap validator = new UserMap();

            ValidationResult results = validator.Validate(customer);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    Trace.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }
            }
        }
    }
}
