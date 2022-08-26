using System;
using System.Web.Mvc;
using ApplicantProject.Models;


namespace ApplicantProject.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            UserModel newUser = new UserModel();
            return View(newUser);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                DateTime registerDate;
                if (!DateTime.TryParse(userModel.RegisterDateString, out registerDate))
                {
                    //Handle error
                }
                else
                {
                    userModel.RegisterDate = registerDate;
                }

                //Make a Test function that accepts a first name and a last name and returns a string containing the passed in values
                if (!string.IsNullOrEmpty(userModel.FirstName) && !string.IsNullOrEmpty(userModel.LastName))
                {
                    userModel.FullName = userModel.FirstName + " " + userModel.LastName; 
                }
                //********************************************************************************************************************
            }

            return View(userModel);
        }

        [HttpPost]
        public JsonResult JsonIndex(UserModel userModel)
        {
            string fullName = "";

            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(userModel.FirstName) && !string.IsNullOrEmpty(userModel.LastName))
                {
                    fullName = userModel.FirstName + " " + userModel.LastName;
                }
            }

            return Json(new { result = fullName }, JsonRequestBehavior.AllowGet);
        }
    }
}
