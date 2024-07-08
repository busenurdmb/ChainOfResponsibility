using ChainOfResp.ChainofRespPattern;
using ChainOfResp.DAL;
using ChainOfResp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChainOfResp.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerViewModel customerViewModel)
        {

            Employee treasurer = new Treasurer(_context);
            Employee managerAssistant = new ManagerAsistant(_context);
            Employee manager = new Manager(_context);
            Employee areaDirector = new AreaDirector(_context);

            treasurer.SetNextApprover(managerAssistant);
            managerAssistant.SetNextApprover(manager);
            manager.SetNextApprover(areaDirector);

            treasurer.ProcessRequest(customerViewModel);

            return RedirectToAction("Success","Default");
        }
        [HttpGet]
        public IActionResult Success()
        {
            return View();
        }

    }
}
