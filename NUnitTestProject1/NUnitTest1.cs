using RPNCalc;
using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTestProject1
{
    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            RPNCalculator obj = new RPNCalculator();
            Int32 []arr = {3,4,6,8,1};
            Assert.AreEqual(8, obj.find(arr));
        }

        [Test]
        public void TestCalc()
        {
            RPNCalculator calc = new RPNCalculator();
            int result = calc.PerformCalc(3, 5, "+");
            Assert.AreEqual(8, result);
        }

        [Test]
        public void MyCalcTest()
        {
            try
            {
                RPNCalculator calc = new RPNCalculator();
                int result = calc.MyCalc(" ");
                Assert.Fail();
            }

            catch(Exception ex)
            {
                Assert.AreEqual("Invalid Exp", ex.Message);
            }
        }


        [Test]
        public void TestStack()
        {
            try
            {
                RPNCalculator calc = new RPNCalculator();

                Stack<int> st = new Stack<int>();
                
                //int result = calc.OperateStack(("3,5,+","+");
                Assert.Fail();
            }

            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Exp", ex.Message);
            }
        }   

    }

   
}