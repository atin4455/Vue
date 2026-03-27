using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 
using Vue.Models; 


namespace Vue.Controllers
{
    public class GuestbookController : Controller
    {
        private readonly AppDbContext _context;

        public GuestbookController(AppDbContext context)
        {
            _context = context;
        }

        // 1. 顯示所有留言
        public async Task<IActionResult> Index()
        {
            var list = await _context.Guestbooks
                                     .OrderByDescending(m => m.CreatedAt)
                                     .ToListAsync();
            return View(list);
        }

        // 2. 儲存留言
        [HttpPost]
        public async Task<IActionResult> Create(string userName, string content)
        {
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(content))
            {
                var entry = new Guestbook
                {
                    UserName = userName,
                    Content = content,
                    CreatedAt = DateTime.Now
                };

                _context.Guestbooks.Add(entry);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
