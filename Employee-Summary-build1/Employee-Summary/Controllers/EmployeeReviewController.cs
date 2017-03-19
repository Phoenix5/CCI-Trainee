using Employee_Summary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee_Summary.Controllers
{

    public static class iList {

        /*  Dev_Skills d = new Dev_Skills()
        {   CodingSkills = Dev_Rating.NeedsImprovement,
            QualityAssurance = Dev_Rating.MeetsExpectations,
            TimeLogging = Dev_Rating.AboveExpectations,
            TroubleShootingSkills = Dev_Rating.Outstanding
        };
        Tech_skills t = new Tech_skills()
        {
            TFS=Tech_Rating.Beginner,
            GIT=Tech_Rating.Expert,
            Ruby=Tech_Rating.Intermediate,
            ASPDotNETCORE=Tech_Rating.Proficient,
            AngularJS=Tech_Rating.Expert,
            CSharp=Tech_Rating.Expert

        };*/
        //  private int i = 2;
        public static IList<Summary> EList = new List<Summary>();
        /*  {new Summary {Id=1 ,Name="Prathamesh",Designation=Designations.JuniorDeveloper,Dskill=new Dev_Skills()
          {
              CodingSkills = Dev_Rating.NeedsImprovement,
              QualityAssurance = Dev_Rating.MeetsExpectations,
              TimeLogging = Dev_Rating.AboveExpectations,
              TroubleShootingSkills = Dev_Rating.Outstanding
          },Tskill=new Tech_skills()
          {
              TFS=Tech_Rating.Beginner,
              GIT=Tech_Rating.Expert,
              Ruby=Tech_Rating.Intermediate,
              ASPDotNETCORE=Tech_Rating.Proficient,
              AngularJS=Tech_Rating.Expert,
              CSharp=Tech_Rating.Expert
          }
          }
          };*/

    }
    public class EmployeeReviewController : Controller
    {
      
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Category(Summary summary1)
        {
           // i++;
           foreach(var item in iList.EList)
            {
                if (item.Designation == summary1.Designation && item.Name == summary1.Name)
                    return View("Summary",item);
            }
            return View(summary1);
        }


        public ActionResult DevSkills(Summary summary2)
        {
            summary2.set = true;
            return View(summary2);
        }

        public ActionResult TechSkills(Summary summary3)
        {
            summary3.set = true;
            //summary3.Tskill.Ruby = Tech_Rating.Intermediate;
            return View(summary3);
        }

        public ActionResult Summary(Summary summary4)
        {  // if (summary3.set == 1)
            iList.EList.Add(new Summary(summary4.Name,summary4.Designation,summary4.Dskill,summary4.Tskill));
                return View(summary4);
           // else
           //     return RedirectToAction("Index","EmployeeReview");

        }
        
    }
}