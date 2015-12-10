using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge
{
    public class EmployeeSorter
    {
        /// <summary>
        /// Sort employees by first name
        /// </summary>
        /// <param name="employees">List of employees</param>
        /// <returns>Sorted list of employees</returns>
        public IEnumerable<Employee> SortByFirstName(IList<Employee> employees)
        {
            return employees.OrderBy(x => x.FirstName);
        }
    }
}
