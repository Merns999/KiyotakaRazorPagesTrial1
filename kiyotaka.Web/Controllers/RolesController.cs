//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;

//namespace kiyotaka.Web.Controllers
//{
//    public class RolesController : Controller
//    {
//        public readonly RoleManager<IdentityRole> _rolemanager;
//        public RolesController(RoleManager<IdentityRole> rolemanager)
//        {
//            _rolemanager = rolemanager;
//        }
//        public IActionResult Index()
//        {
//            var roles = _rolemanager.Roles;
//            return View( "Pages/Roles.cshtml", roles);
//        }

//        [HttpGet]
//        public IActionResult Create()
//        {
//            return View();
//        }

//        [HttpPost]
//        public async Task<IActionResult> Create(IdentityRole model)
//        {
//            if (!_rolemanager.RoleExistsAsync(model.Name).GetAwaiter().GetResult())//Checks whether the role is already there
//            {
//                _rolemanager.CreateAsync(new IdentityRole(model.Name)).GetAwaiter().GetResult();//If not it is created
//            }
            
//            return RedirectToAction("Index");
//        }
//    }
//}
