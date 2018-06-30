using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //Берем и заполняем нашу МОДЕЛЬ СВОИМИ данными
        private List<EmployeeView> employees = new List<EmployeeView>
        {
            new EmployeeView
            {
                Id = 1,
                FirstName = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
                Age = 22,
                MaritalStatus = "Не женат",
                Adress = "Нариманова 30"
            },
            new EmployeeView
            {
                Id = 2,
                FirstName = "Владислав",
                SurName = "Петров",
                Patronymic = "Иванович",
                Age = 35,
                 MaritalStatus = "Женат",
                 Adress = "Толбухина 90"
            },
            new EmployeeView
            {
                Id = 3,
                FirstName = "Kamil",
                SurName = "Abulkhanov",
                Patronymic = "Barievich",
                 Age = 19,
                 MaritalStatus = "Не женат",
                 Adress = "Московская 1/30"
            }
        };

        //Если заполнили данными модель(шаблон), то это нужно отдать
        public IActionResult Index()
        {
            return View(employees);
        }

        public IActionResult Details(int id)
        {
            var v = employees.Find(x => x.Id.Equals(id));           
            return View(v);

        }


    }


}
