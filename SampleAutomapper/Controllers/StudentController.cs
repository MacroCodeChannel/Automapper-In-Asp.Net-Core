using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SampleAutomapper.Models;

namespace SampleAutomapper.Controllers
{
    public class StudentController : Controller
    {
        private readonly IMapper _mapper;

        public StudentController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new StudentDTO();

            return View(model);
        }

        [HttpPost]  
        public IActionResult Create(StudentDTO model)
        {
            var studenddetails = _mapper.Map<Student>(model);

            return View(studenddetails);
        }
    }
}
