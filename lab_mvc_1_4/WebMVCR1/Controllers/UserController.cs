using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebMVCR1.Models;

namespace WebMVCR1.Controllers
{
	public class UserController : Controller
	{
		static List<User> users = new List<User>();
		// GET: UserController
		public ActionResult Index()
		{
			return View(users);
		}

		// GET: UserController/Details/5
		public ActionResult Details(User user)
		{
			return View(user);
		}

		// GET: UserController/Create
		public ActionResult Create()
		{
			return View();
		}
        [HttpPost]
        public ActionResult Create(User user)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					return View("Create", user);
				}

				users.Add(user);

				return RedirectToAction("Index");

			}
			catch
			{
				return View();
			}
		}


		// GET: UserController/Edit/5
		public ActionResult Edit(int id)
		{
            User user = new();
            foreach (User u in users)
            {
                if (u.Id == id)
                {
                    user.Name = u.Name;
                    user.Age = u.Age;
                    user.Id = u.Id;
                    user.Phone = u.Phone;
                    user.Email = u.Email;

                    return View(user);
                }
            }
            return View(user);
		}

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", user);
            }

            foreach (User u in users)
            {
                if (u.Id == user.Id)
                {
                    u.Name = user.Name;
                    u.Age = user.Age;
                    u.Id = user.Id;
                    u.Phone = user.Phone;
                    u.Email = user.Email;
                }
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            User user = new();
            foreach (User u in users)
            {
                if (u.Id == id)
                {
                    user.Name = u.Name;
                    user.Age = u.Age;
                    user.Id = u.Id;
                    user.Phone = u.Phone;
                    user.Email = u.Email;

                    return View(user);
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(User user)
        {
            try
            {
                foreach (User u in users)
                {
                    if (u.Id == user.Id)
                    {
                        users.Remove(u);
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
