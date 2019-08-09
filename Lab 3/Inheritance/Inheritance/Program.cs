using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class College
    {
        string collegeName;
        string principalName;

        public string CollegeName
        {
            get
            {
                return collegeName;
            }

            set
            {
                collegeName = value;
            }
        }

        public string PrincipalName
        {
            get
            {
                return principalName;
            }

            set
            {
                principalName = value;
            }
        }
    }
    class Program : College
    {
        string deptName;
        string hodName;
        public string DeptName
        {
            get;
            set;
        }
        public string HodName
        {
            get;
            set;
        }

        static void Main(string[] args)
        {
            Program deptObj = new Program();
            Console.WriteLine("Please enter the names of the College, Principal, Department, and HOD.");
            deptObj.CollegeName = Console.ReadLine();
            deptObj.PrincipalName = Console.ReadLine();
            deptObj.DeptName = Console.ReadLine();
            deptObj.HodName = Console.ReadLine();

            Console.WriteLine("College name: {0}\nPrincipal Name: {1}\nDepartment Name: {2}\n, HOD Name: {3}", deptObj.CollegeName, deptObj.PrincipalName, deptObj.DeptName, deptObj.HodName);
            Console.Read();
        }
    }
}
