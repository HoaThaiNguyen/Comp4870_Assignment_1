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
            if (_context == null || _context.Users == null || _context.ContributorApprovals == null)
            {
                return View(new List<ContributorApprovalViewModel>()); // Return empty list if database is null
            }
            
            var pendingUsers = _context.ContributorApprovals
                .Where(u => !u.IsApproved)
                .Join(_context.Users, ca => ca.UserId, u => u.Id, (ca, u) => new ContributorApprovalViewModel
                {
                    ApprovalId = ca.Id,
                    Email = u.Email
                })
                .ToList();

            if (pendingUsers == null)
            {
                pendingUsers = new List<ContributorApprovalViewModel>(); // ✅ Ensure Model is never null
            }

            return View(pendingUsers);
        }

        [HttpPost]
        public async Task<IActionResult> ApproveContributor(int id)
        {
            var approvalRecord = _context.ContributorApprovals.FirstOrDefault(a => a.Id == id);
            if (approvalRecord != null)
            {
                approvalRecord.IsApproved = true;
                _context.ContributorApprovals.Update(approvalRecord);
                await _context.SaveChangesAsync();
            }
            else 
            {
                return NotFound();
            }

            return RedirectToAction("ApproveContributors");
        }
    }
}
