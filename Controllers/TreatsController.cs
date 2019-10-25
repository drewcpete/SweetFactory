using Microsoft.AspNetCore.Mvc;
using SweetFactory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace SweetFactory.Controllers
{
    [Authorize]
    public class TreatsController : Controller
    {
        private readonly SweetFactoryContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        
        public TreatsController(UserManager<ApplicationUser> userManager, SweetFactoryContext db)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task<ActionResult> Index()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            var userTreats = _db.Treats.Where(entry => entry.User.Id == currentUser.Id);
            return View(userTreats);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}