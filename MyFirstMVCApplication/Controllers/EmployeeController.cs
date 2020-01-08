using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstMVCApplication.Models;
using System.Data;
using System.Data.SqlClient;

namespace MyFirstMVCApplication.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View("AddEmployee");
        }


        [HttpPost]
        public ActionResult AddNewEmployee(EmployeeModel emp)
        {
            if (ModelState.IsValid)
            {
                SqlConnection sqlConnection =new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True;Pooling=False");
                SqlCommand com = new SqlCommand("sp_InsertEmployee", sqlConnection);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@EmpId", emp.EmpId);
                com.Parameters.AddWithValue("@EmpName", emp.EmpName);
                com.Parameters.AddWithValue("@EmpAge", emp.EmpAge);
                com.Parameters.AddWithValue("@EmpGender", emp.EmpGender);
                sqlConnection.Open();
                int i = com.ExecuteNonQuery();
                sqlConnection.Close();
                if (i >= 1)
                {
                    ViewBag.Message = "New Employee Added Successfully";
                }

            }
            ModelState.Clear();
            return View("EmployeeDetails", emp);
        }

        //public ActionResult EmpDetails()
        //{
        //    EmployeeModel emp = TempData["Emp"] as EmployeeModel;
        //    return View(emp);
        //}

        public ActionResult ListEmployees()
        {
            List<EmployeeModel> lstEmployee = new List<EmployeeModel>();
            lstEmployee = GetAllEmployees().ToList();
            return View("EmployeesList", lstEmployee);
        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            List<EmployeeModel> lstemployee = new List<EmployeeModel>();

            using (SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True;Pooling=False"))
            {
                SqlCommand cmd = new SqlCommand("sp_GetEmployees", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                sqlConnection.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    EmployeeModel employee = new EmployeeModel();
                    employee.EmpId = Convert.ToInt32(rdr["EmpId"]);
                    employee.EmpName = rdr["EmpName"].ToString();
                    employee.EmpAge = Convert.ToInt32(rdr["EmpAge"]);
                    employee.EmpGender = rdr["EmpGender"].ToString();
                    lstemployee.Add(employee);
                }
                sqlConnection.Close();
            }
            return lstemployee;
        }
    }
}