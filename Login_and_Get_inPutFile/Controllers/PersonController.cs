﻿using Microsoft.AspNetCore.Mvc;
using Login_and_Get_inPutFile.Models;
using System;



namespace Login_and_Get_inPutFile.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterPerson()
        {
            var model = new PersonViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult RegisterPerson(PersonViewModel model)
        {
            if (model.File != null)
            {
                using (var ms = new MemoryStream())
                {
                    model.File.CopyTo(ms);
                    var fileByte = ms.ToArray();
                    string s = Convert.ToBase64String(fileByte);
                    model.ImageName = s;
                }
            }
            return View(model);
        }

    }
}
