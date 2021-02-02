using NUnit.Framework;
using Redmine.Pages;
using Redmine.SeleniumStuff;
using System;
namespace RedmineTestCases
{
    [TestFixture]
    [Category("RedmineErick")]
    public class Timesheets
    {
        #region TestInitialize
        [SetUp]
        public void Init()
        {
            Driver.Initialize();
        }
        #endregion TestInitialize

        ///Meeting
        ///Test Case Design 
        ///Testing
        ///Development
        ///Research (Non-Project Bucket)

        [Test]
        public void Automation1_Ayer()
        {
            RedminePage.LlenarHoras(1, 6, 0, 0, 1, "02/01/2021");
        }

        [Test]
        public void Automation3_Mañana()
        {
            RedminePage.LlenarHoras(1, 6, 0, 0, 1, "02/05/2021");
        }

        [Test]
        public void Automation2_Hoy()
        {
            RedminePage.LlenarHoras(1, 6, 0, 0, 1);
        }

        #region CleanUp
        [TearDown]
        public void Cleanup()
        {
            Driver.Close();
        }
        #endregion CleanUp
    }
}
