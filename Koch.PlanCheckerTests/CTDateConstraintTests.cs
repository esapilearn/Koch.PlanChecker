using Microsoft.VisualStudio.TestTools.UnitTesting;
using Koch.PlanChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESAPIX.Constraints;
using ESAPIX.Facade.API;

namespace Koch.PlanChecker.Tests
{
    [TestClass()]
    public class CTDateConstraintTests
    {
        [TestMethod()]
        public void CTDatePasses()
        {

            // Arrange
            var im = new Image();
            im.CreationDateTime = DateTime.Now.AddDays(-59);
            // Act
            var constraint = new CTDateConstraint();
            var actual = constraint.Constrain(im).ResultType;
            // Assert
            var expected = ResultType.PASSED;
            Assert.AreEqual(expected, actual);
        }
    }
}