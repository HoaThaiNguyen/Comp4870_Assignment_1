using Assignment_1.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Assignment_1.Models;

namespace Assignment_1.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<CustomUser> _userManager;

        public AdminController(ApplicationDbContext context, UserManager<CustomUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult ApproveContributors()
        {
            if (_context == null || _context.Users == null)
            {
                return View(new List<CustomUser>()); // Return empty list if database is null
            }

            var pendingUsers = _context.Users
                .Where(u => !u.IsApproved)
                .ToList();

            if (pendingUsers == null)
            {
                pendingUsers = new List<CustomUser>(); // Ensure Model is never null
            }

            return View(pendingUsers);
        }

        [HttpPost]
        public async Task<IActionResult> ApproveContributor(string id)
        {
            var approvalRecord = _context.Users?.FirstOrDefault(a => a.Id == id);
            if (approvalRecord != null)
            {
                approvalRecord.IsApproved = true;
                _context.Users?.Update(approvalRecord);
                await _context.SaveChangesAsync();
            }
            else 
            {
                return NotFound();
            }

            return RedirectToAction("ApproveContributors");
        }

        public IActionResult ManageUsers()
        {
            if (_context == null || _context.Users == null)
            {
                return View(new List<CustomUser>()); // Return empty list if database is null
            }

            var users = _context.Users.ToList();
            var userRoles = new Dictionary<string, string>();
                
            if (users == null)
            {
                users = new List<CustomUser>(); // Ensure Model is never null
            }

            return View(users);
        }

        // [HttpPost]
        // public async Task<IActionResult> ToggleApproval(string id)
        // {
        //     var user = await _userManager.FindByIdAsync(id);
        //     if (user == null) return NotFound();

        //     user.IsApproved = !user.IsApproved; // ✅ Toggle approval status
        //     await _userManager.UpdateAsync(user);

        //     return RedirectToAction("ManageUsers");
        // }

    }
}
