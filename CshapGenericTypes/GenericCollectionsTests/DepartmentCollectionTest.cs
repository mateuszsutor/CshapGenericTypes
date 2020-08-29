using _2_GenericCollections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCollectionsTests
{
    [TestClass]
    public class DepartmentCollectionTest
    {
        [TestMethod]
        public void NoAddDuplicateEmployeeToCollection()
        {
            var employeeAndDepartmentCollection = new DepartmentCollection();
            employeeAndDepartmentCollection.Add("Sprzedaż", new Employee { FirstName = "Anna", LastName = "Cięciel" });
            employeeAndDepartmentCollection.Add("Sprzedaż", new Employee { FirstName = "Anna", LastName = "Cięciel" });

            Assert.AreEqual(1, employeeAndDepartmentCollection.Count);
        }

        [TestMethod]
        public void NoCreateDuplicateDepartment()
        {
            var employeeAndDepartmentCollection = new DepartmentCollection();
            employeeAndDepartmentCollection.Add("Sprzedaż", new Employee { FirstName = "Beata", LastName = "Cięciel" });
            employeeAndDepartmentCollection.Add("Sprzedaż", new Employee { FirstName = "Anna", LastName = "Cięciel" });
            employeeAndDepartmentCollection.Add("Księgowość", new Employee { FirstName = "Piotr", LastName = "Nowak" });
            employeeAndDepartmentCollection.Add("Księgowość", new Employee { FirstName = "Marek", LastName = "Bogucki" });

            Assert.AreEqual(2, employeeAndDepartmentCollection.Keys.Count);
        }

        [TestMethod]
        public void AlphabeticalSortedEmployeeByLastName()
        {
            var employeeAndDepartmentCollection = new DepartmentCollection();

            employeeAndDepartmentCollection.Add("Sprzedaż", new Employee { FirstName = "Beata", LastName = "Budrys" });
            employeeAndDepartmentCollection.Add("Sprzedaż", new Employee { FirstName = "Anna", LastName = "Falkowska" });
            employeeAndDepartmentCollection.Add("Sprzedaż", new Employee { FirstName = "Piotr", LastName = "Nowak" });
            employeeAndDepartmentCollection.Add("Sprzedaż", new Employee { FirstName = "Marek", LastName = "Ziemba" });

        }



    }
}
