using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;


namespace TriangleUnitTest
{
    public class UnitTest

    {
        [TestFixture]
        public class TriangleTest1

        {
            
           
            //-	Three (3) tests for verifying a zero length for one or more sides

            [Test]
            public void InvalidTriangle_Input0and4and5_OutputInvalidTriangle()
            {
                //Arrange
                int firstSide = 0;
                int secondSide = 4;
                int thirdSide = 5;
                string expected = "Invalid Triangle - a zero has been detected";
                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void InvalidTriangle_Input3and0and5_OutputInvalidTriangle()
            {
                //Arrange
                int firstSide = 3;
                int secondSide = 0;
                int thirdSide = 5;
                string expected = "Invalid Triangle - a zero has been detected";
                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void InvalidTriangle_Input3and4and0_OutputInvalidTriangle()
            {
                //Arrange
                int firstSide = 3;
                int secondSide = 4;
                int thirdSide = 0;
                string expected = "Invalid Triangle - a zero has been detected";
                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }


            //-	Three (3) tests for verifying an invalid response (other than a zero length)
            [Test]
            public void InvalidTriangle_Input1and2and3_OutputInvalidTriangle()
            {
                //Arrange
                int firstSide = 1;
                int secondSide = 2;
                int thirdSide = 3;
                string expected = "INVALID!!";
                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void InvalidTriangle_Input4and8and3_OutputInvalidTriangle()
            {
                //Arrange
                int firstSide = 4;
                int secondSide = 8;
                int thirdSide = 3;
                string expected = "INVALID!!";
                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void InvalidTriangle_Input5and10and15_OutputInvalidTriangle()
            {
                //Arrange
                int firstSide = 5;
                int secondSide = 10;
                int thirdSide = 15;
                string expected = "INVALID!!";
                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }








        }


    }
}
