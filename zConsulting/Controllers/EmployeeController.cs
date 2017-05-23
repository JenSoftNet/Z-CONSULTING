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
            var viewModel = new ExpertViewModel(_experts) {Title = "���� ��������"};
            return View(viewModel);
        }

        private void InitExperts()
        {
            _experts = new List<Expert>
            {
                new Expert
                {
                    ID = 0,
                    FirstName = "����",
                    LastName = "����",
                    Position = "������������ ��������",
                    ShortDescription = "���������� � ���������� ��������������� ������ �������",
                    Photo = "/img/trainers/profile-2.jpg",
                    Activities = new List<Activity>
                    {
                        new Activity {Name = "���������� � ���������� ��������������� ������ �������"},
                        new Activity {Name = "���������������� � ����������� ��������� ������"},
                        new Activity {Name = "������ ����������������� �� �������"},
                        new Activity {Name = "����� ���������������� �������������"}
                    }
                },
                new Expert
                {
                    ID = 1,
                    FirstName = "����� ",
                    LastName = "��������",
                    Position = "��������� ������������ ����� � ����������",
                    ShortDescription = "������������� �������������",
                    Photo = "/img/trainers/profile-8.jpg",
                    Activities = new List<Activity>
                    {
                        new Activity {Name = "����������� ������� ��������� ������������"},
                        new Activity {Name = "������������� �������������"},
                        new Activity {Name = "��������� ���� � ����������"},
                        new Activity {Name = "������������� ��������� ������� � ��������� �������"}
                    }
                },
                new Expert
                {
                    ID = 2,
                    FirstName = "No Name",
                    LastName = "No Name",
                    Position = "����������� �����������",
                    ShortDescription = "����������� ������������� �������",
                    Photo = "/img/trainers/profile-2.jpg",
                    Activities = new List<Activity>
                    {
                        new Activity {Name = "����������� ������������� �������"},
                        new Activity {Name = "������������� ��������� ������� � ��������������� �������"}
                    }
                },
                new Expert
                {
                    ID = 3,
                    FirstName = "�����",
                    LastName = "�������",
                    Position = "HR",
                    ShortDescription = "HR �������������",
                    Photo = "/img/trainers/profile-7.jpg",
                    Activities = new List<Activity>
                    {
                        new Activity {Name = "HR �������������"},
                        new Activity {Name = "�������� �����������������"},
                        new Activity {Name = "����� � ������ �� ������������"}
                    }
                },
                new Expert
                {
                    ID = 4,
                    FirstName = "�������",
                    LastName = "����",
                    Position = "����������� ��������",
                    ShortDescription = "����������������� �������",
                    Photo = "/img/trainers/profile-3.jpg",
                    Activities = new List<Activity>
                    {
                        new Activity {Name = "����������� ����������� � ���"},
                        new Activity {Name = "����������������� �������"},
                        new Activity {Name = "PR & CMM"}
                    }
                },
                new Expert
                {
                    ID = 5,
                    FirstName = "�����",
                    LastName = "���������",
                    Position = "�����������",
                    ShortDescription = "����������� �� �������� ���������������",
                    Photo = "/img/trainers/profile-1.png",
                    Activities = new List<Activity>
                    {
                        new Activity {Name = "����������� �� �������� ���������������"},
                        new Activity {Name = "������������ �� �������� ��������������� ������� �����������"},
                        new Activity {Name = "������ ����������������� �� �������"},
                        new Activity {Name = "������������ �� �������� ���"}
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