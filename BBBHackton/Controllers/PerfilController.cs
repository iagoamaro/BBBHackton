using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using BBBHackton.Models;
using BBBHackton.Data.Service.EF;

namespace BBBHackton.Controllers
{
    [Authorize]
    public class PerfilController : Controller
    {
        private PerfilEF _perfilManager = new PerfilEF();
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private CursoEF _cursoManager = new CursoEF();
        private ExpProfEF _expManager = new ExpProfEF();
        public PerfilController()
        {

        }
        public PerfilController(ApplicationSignInManager signInManager, ApplicationUserManager userManager)
        {
            _perfilManager = new PerfilEF();
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
        // GET: Perfil
        public ActionResult Index()
        {
            var userId =  User.Identity.GetUserId();
            var perfil = UserManager.Users.FirstOrDefault(x => x.Id == userId).Perfil;
            perfil.Cursos = _cursoManager.GetAll().Where(x => x.PerfilId == perfil.Id).ToList();
            perfil.Experiencias = _expManager.GetAll().Where(x => x.PerfilId == perfil.Id).ToList();
            return View(perfil);
        }
    }
}