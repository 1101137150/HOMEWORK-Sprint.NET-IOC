
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao : GenericDao<Employee>, IEmployeeDao
    {

        override protected IRowMapper<Employee> GetRowMapper()
        {
            return new EmployeeRowMapper();
        }

        public IList<Employee> GetAllEmployees()
        {
            IList<Employee> employees = new List<Employee>();
            Employee lee = new Employee();
            lee.Name = "Tom";
            lee.Id = "1101137150";
            lee.Age = 20;
            return employees;
        }

        public Employee GetEmployeeById(string id)
        {
            Employee lee = new Employee();
            lee.Name = "Tom";
            lee.Id = "1101137150";
            lee.Age = 20;
            return lee;
        }

    }
}
