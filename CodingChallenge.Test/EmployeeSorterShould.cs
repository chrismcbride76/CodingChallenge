using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge.Test
{
    [TestClass]
    public class EmployeeSorterShould
    {
        [TestMethod]
        public void SortEmptyList()
        {
            EmployeeSorter sorter = new EmployeeSorter();

            var sortedList = sorter.SortByFirstName(new List<Employee>());
            Assert.IsFalse(sortedList.Any());
        }

        [TestMethod]
        public void SortByFirstName()
        {
            EmployeeSorter sorter = new EmployeeSorter();
            var employee1 = new Employee {FirstName = "Zack", LastName = "Brimhall"};
            var employee2 = new Employee {FirstName = "Alex", LastName = "Bashmakov"};
            var employee3 = new Employee {FirstName = "Jaycen", LastName = "Grant" };
            var employee4 = new Employee {FirstName = "Christopher", LastName = "Spencer"};

            List<Employee> listToSort = new List<Employee>{ employee1, employee2, employee3, employee4 };

            var sorted = sorter.SortByFirstName(listToSort).ToArray();
            Assert.AreEqual(sorted[0], employee2);
            Assert.AreEqual(sorted[1], employee4);
            Assert.AreEqual(sorted[2], employee3);
            Assert.AreEqual(sorted[3], employee1);
        }
    }
}
