using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SweetFactory.Models;
using System.Threading.Tasks;
using SweetFactory.ViewModels;

namespace SweetFactory.Controllers
{
    public class AccountController : Controller{
        private readonly SweetFactoryContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, SweetFactoryContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }
    }
}