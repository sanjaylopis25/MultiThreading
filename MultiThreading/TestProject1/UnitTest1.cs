using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using MultiThreading;



namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<EmployeDetails> EmpDetailList = new List<EmployeDetails>();
            EmpDetailList.Add(new EmployeDetails(1, "sanjay", "haliyal", 581329));
            EmpDetailList.Add(new EmployeDetails(2, "derick", "mangalore", 581329));
            EmpDetailList.Add(new EmployeDetails(3, "jason", "banglore", 581329));
            EmpDetailList.Add(new EmployeDetails(4, "sanjay", "haliyal", 581329));
            EmpDetailList.Add(new EmployeDetails(5, "sanjay", "haliyal", 581329));
            EmpDetailList.Add(new EmployeDetails(6, "gian", "pune", 581329));
        }
    }
}