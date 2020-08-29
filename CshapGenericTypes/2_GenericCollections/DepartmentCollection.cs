using System;
using System.Collections.Generic;
using System.Text;

namespace _2_GenericCollections
{
    public class DepartmentCollection : SortedDictionary<string, SortedSet<Employee>>
    {
        public DepartmentCollection Add(string departmentName, Employee employee) 
        {
            if (!ContainsKey(departmentName))
            {
                Add(departmentName, new SortedSet<Employee>(new EmployeeComparer()));
                
            }
            this[departmentName].Add(employee);
            return this;
        } 
    }
}
