using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10.IModel
{
     public interface IEmployeeModel< T>    
    {
        List<T> GetEmployees();
        void GetEmployeeById(int id);
        bool CreateEmployee();
    }
}
