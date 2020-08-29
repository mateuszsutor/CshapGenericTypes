using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _2_GenericCollections
{
    public class EmployeeComparer : IEqualityComparer<Employee>, IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            

            if (string.Compare(x.LastName, y.LastName) == 0 && String.Compare(x.FirstName, y.FirstName) == 0)
            {
                return 0;
            }
            else if(string.Compare(x.LastName, y.LastName) == 0 && String.Compare(x.FirstName, y.FirstName) == 1)
            {
                return 1;
            }
            else if (string.Compare(x.LastName, y.LastName) == 0 && String.Compare(x.FirstName, y.FirstName) == -1)
            {
                return -1;
            }
            return string.Compare(x.LastName, y.LastName);

        }

        public bool Equals(Employee x, Employee y)
        {
            bool value = false;

            if (string.Equals(x.LastName, y.LastName))
            {
                if (string.Equals(x.FirstName, y.FirstName))
                {
                    value = true;
                }
               
            }
            return value;
        }

        public int GetHashCode(Employee obj)
        {
            return obj.LastName.GetHashCode();
        }
    }
}
