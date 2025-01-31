// In your User Controller, paste the code below.


        public JsonResult CheckEmailIsValid(string Email)
        {
            return Json((!db.user.Any(m => m.Email == Email)), JsonRequestBehavior.AllowGet);
        }
