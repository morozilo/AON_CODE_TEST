using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AON_coding_test.Models;
using StringManipulation;

namespace AON_coding_test.Controllers
{
   /// <summary>
   /// main controller
   /// </summary>
    public class HomeController : Controller
    {
       
        /// <summary>
        /// initializing private StringManipulationService object
        /// </summary>
        private static StringManipulationService _strManipulationSvc = new StringManipulationService();

         
        /// <summary>
        /// public property to access StringManipulationService service
        /// </summary>
        public StringManipulationService StringManiplationSvc
        {
            get
            {
                return _strManipulationSvc;
            }
        }

       
        public ActionResult Index()
        {
            return View();
        }

      
        /// <summary>
        /// action to display results that takes model from the Index action
        /// </summary>
        public ActionResult DisplayResults(StringModel model)
        {
            // checking model state on the server side
            if (ModelState.IsValid)
            {
                // calling method to rearrange letters in the string
                var newModel = this.StringManiplationSvc.CharSwitch(model);

                // calling Dislay results controller
                return View("DisplayResults",newModel);

            }
            // if data is invalid sending user back to input screen
            return View("Index");

        }
        
    }
}
