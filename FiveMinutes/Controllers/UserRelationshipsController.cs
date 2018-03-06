using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FiveMinutes.Models;

namespace FiveMinutes.Controllers
{
    public class UserRelationshipsController : Controller
    {
        private readonly FiveMinutesContext _context;

        public UserRelationshipsController(FiveMinutesContext context)
        {
            _context = context;
        }

        // GET: UserRelationships
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserRelationship.ToListAsync());
        }

        // GET: UserRelationships/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRelationship = await _context.UserRelationship
                .SingleOrDefaultAsync(m => m.ID == id);
            if (userRelationship == null)
            {
                return NotFound();
            }

            return View(userRelationship);
        }

        // GET: UserRelationships/Create/UserID/FriendID
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserRelationships/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UserID,FriendID,Accepted")] UserRelationship userRelationship)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userRelationship);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userRelationship);
        }

        // GET: UserRelationships/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRelationship = await _context.UserRelationship.SingleOrDefaultAsync(m => m.ID == id);
            if (userRelationship == null)
            {
                return NotFound();
            }
            return View(userRelationship);
        }

        // POST: UserRelationships/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,UserID,FriendID,Accepted")] UserRelationship userRelationship)
        {
            if (id != userRelationship.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userRelationship);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserRelationshipExists(userRelationship.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(userRelationship);
        }

        // GET: UserRelationships/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRelationship = await _context.UserRelationship
                .SingleOrDefaultAsync(m => m.ID == id);
            if (userRelationship == null)
            {
                return NotFound();
            }

            return View(userRelationship);
        }

        // POST: UserRelationships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var userRelationship = await _context.UserRelationship.SingleOrDefaultAsync(m => m.ID == id);
            _context.UserRelationship.Remove(userRelationship);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserRelationshipExists(string id)
        {
            return _context.UserRelationship.Any(e => e.ID == id);
        }
    }
}
