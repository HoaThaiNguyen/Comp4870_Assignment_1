using Assignment_1.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_1.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public AdminController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult ApproveContributors()
        {
            var pendingUsers = _context.ContributorApprovals
                .Where(u => !u.IsApproved)
                .Join(_context.Users, ca => ca.UserId, u => u.Id, (ca, u) => new { ca.Id, u.Email })
                .ToList();

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
            return RedirectToAction("ApproveContributors");
        }
    }
}
