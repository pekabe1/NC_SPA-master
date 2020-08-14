using eShop_ApplicationCore.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop_ApplicationCore.Helpers
{
     public static class Extensions
    {
        public static string GenerateIdentification<T>(T employee) where T : EmployeeAbstract
        {
            if (employee.LastName.Length <= 2)
            {
                var lastCharacter = employee.LastName.Substring(employee.LastName.Length - 1);
                employee.LastName += lastCharacter;
            }

            if (employee.FirstName.Length <= 2)
            {
                var lastCharacter = employee.FirstName.Substring(employee.FirstName.Length - 1);
                employee.FirstName += lastCharacter;

            }
            return (employee.FirstName.Substring(0, 3) + "-" + employee.LastName.Substring(0, 3) + "-" + employee.Id).ToUpper();
        }

    }
}
