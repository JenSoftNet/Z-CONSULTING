using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using zConsulting.Models.Business;

namespace zConsulting.Controllers
{
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private List<Expert> _experts;

        public EmployeeController()
        {
            InitExperts();
        }
        [Route("Experts")]
        public IActionResult Index()
        {
            var viewModel = new ExpertViewModel(_experts) {Title = "НАШИ ЭКСПЕРТЫ"};
            return View(viewModel);
        }

        private void InitExperts()
        {
            _experts = new List<Expert>
            {
                new Expert
                {
                    ID = 0,
                    FirstName = "Юлия",
                    LastName = "Зима",
                    Position = "Руководитель компании",
                    ShortDescription = "Разработка и построение организационной модели бизнеса",
                    Photo = "/img/trainers/profile-2.jpg",
                    Activities = new List<Activity>
                    {
                        new Activity {Name = "Разработка и построение организационной модели бизнеса"},
                        new Activity {Name = "Консультирование и оптимизация налоговых рисков"},
                        new Activity {Name = "Полное администрирование ИТ бизнеса"},
                        new Activity {Name = "Права интеллектуальной собственности"}
                    }
                },
                new Expert
                {
                    ID = 1,
                    FirstName = "Ирина ",
                    LastName = "Мосиенко",
                    Position = "Начальник департамента учета и отчетности",
                    ShortDescription = "Бухгалтерское сопровождение",
                    Photo = "/img/trainers/profile-8.jpg",
                    Activities = new List<Activity>
                    {
                        new Activity {Name = "Организация ведения первичной документации"},
                        new Activity {Name = "Бухгалтерское сопровождение"},
                        new Activity {Name = "Налоговый учет и отчетность"},
                        new Activity {Name = "Представление интересов бизнеса в налоговых органах"}
                    }
                },
                new Expert
                {
                    ID = 2,
                    FirstName = "No Name",
                    LastName = "No Name",
                    Position = "Юридический департамент",
                    ShortDescription = "Юридическое сопровождение бизнеса",
                    Photo = "/img/trainers/profile-2.jpg",
                    Activities = new List<Activity>
                    {
                        new Activity {Name = "Юридическое сопровождение бизнеса"},
                        new Activity {Name = "Представление интересов бизнеса в государственных органах"}
                    }
                },
                new Expert
                {
                    ID = 3,
                    FirstName = "Дарья",
                    LastName = "Луговая",
                    Position = "HR",
                    ShortDescription = "HR сопровождение",
                    Photo = "/img/trainers/profile-7.jpg",
                    Activities = new List<Activity>
                    {
                        new Activity {Name = "HR сопровождение"},
                        new Activity {Name = "Кадровое администрирование"},
                        new Activity {Name = "Поиск и подбор ИТ специалистов"}
                    }
                },
                new Expert
                {
                    ID = 4,
                    FirstName = "Леонтий",
                    LastName = "Зима",
                    Position = "Технический директор",
                    ShortDescription = "Администрирование бизнеса",
                    Photo = "/img/trainers/profile-3.jpg",
                    Activities = new List<Activity>
                    {
                        new Activity {Name = "Регистрация предприятий и СПД"},
                        new Activity {Name = "Администрирование бизнеса"},
                        new Activity {Name = "PR & CMM"}
                    }
                },
                new Expert
                {
                    ID = 5,
                    FirstName = "Елена",
                    LastName = "Бондарева",
                    Position = "Консультант",
                    ShortDescription = "Консультант по вопросам налогообложения",
                    Photo = "/img/trainers/profile-1.png",
                    Activities = new List<Activity>
                    {
                        new Activity {Name = "Консультант по вопросам налогообложения"},
                        new Activity {Name = "Консультации по вопросам налогообложения прибыли предприятий"},
                        new Activity {Name = "Полное администрирование ИТ бизнеса"},
                        new Activity {Name = "Консультации по вопросам НДС"}
                    }
                }
            };
        }

        [HttpGet("byId")]
        [Route("Details")]
        public IActionResult Details(int id)
        {
            var expert = _experts.FirstOrDefault<Expert>(e => e.ID == id);
            return View(expert);
        }
    }
}