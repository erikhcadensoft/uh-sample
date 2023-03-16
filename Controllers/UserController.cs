using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using uh_sample.Models;
using uh_sample.Services;

namespace uh_sample.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        // GET: User
        public ActionResult Index()
        {
            try
            {
                var users = _userService.GetAllUsers();
                if (users?.Count() > 0)
                    return NotFound("Results not found.");

                return View(users);
            }
            catch (Exception ex)
            {
                //TODO: implement meaningful exception logging instance
            }
            return BadRequest("Error retrieving users. Please try again later");
        }

        // GET: User/Details/5int
        public ActionResult Details(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest("Invalid input, please correct and try again.");
            try
            {
                var user = _userService.GetUserById(id);
                if (user is null)
                    return NotFound("User by Id not found.");

                return View(user);
            }
            catch (Exception ex)
            {
                //TODO: implement meaningful exception logging instance
            }
            return BadRequest("Error retrieving user. Please try again later");
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            try
            {
                // TODO: Add insert logic here
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}