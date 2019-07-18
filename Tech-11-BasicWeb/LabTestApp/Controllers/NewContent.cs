using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LabTestApp.Controllers
{
    public class NewContent : Controller
    {
        public IActionResult Test(int numberSubmitted)
        {
            List<int> numsList = new List<int>();

            for (int i = 0; i < numberSubmitted; i++)
            {
                numsList.Add(i + 1);
            }
            return View(numsList);
        }
    }
}
