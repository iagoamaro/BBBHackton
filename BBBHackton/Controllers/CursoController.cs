using BBBHackton.Data.Model;
using BBBHackton.Data.Service.EF;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BBBHackton.Controllers
{
    [Authorize]
    public class CursoController : Controller
    {
        private PerfilEF _perfilManager = new PerfilEF();
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private CursoEF _cursoManager = new CursoEF();
        public CursoController()
        {

        }
        public CursoController(ApplicationSignInManager signInManager, ApplicationUserManager userManager)
        {
            
            _userManager = userManager;
            _signInManager = signInManager;
            

        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        // GET: Curso
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var perfilId = UserManager.Users.FirstOrDefault(x => x.Id == userId).Perfil.Id;
            var cursos = _cursoManager.GetAll().Where(x => x.PerfilId == perfilId).ToList();
            return View(cursos);
        }


        [AllowAnonymous]
        public ActionResult Create()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Create(Curso curso)
        {
            var userId = User.Identity.GetUserId();
            curso.PerfilId = UserManager.Users.FirstOrDefault(x => x.Id == userId).Perfil.Id;
            _cursoManager.Create(curso);

            return RedirectToAction("Index");
        }

    }
}