using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee_Summary.Models
{
    public class Summary
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; }
        public Designations Designation { get; set; }
        public Dev_Skills Dskill { get; set; }
        public Tech_skills Tskill { get; set; }

        public bool set { get; set; } = false;
        public Summary()
        {
            Id = Id + 1;
            Name = "Not Entered";
        }
        public Summary(string name, Designations designation, Dev_Skills dskill, Tech_skills tskill)
        {
            Id = Id + 1;
            this.Name = name;
            this.Designation = designation;
            this.Dskill = new Dev_Skills(dskill.CodingSkills,dskill.QualityAssurance,dskill.TimeLogging,dskill.TroubleShootingSkills);
            this.Tskill = new Tech_skills(tskill.AngularJS,tskill.ASPDotNETCORE,tskill.CSharp,tskill.GIT,tskill.Ruby,tskill.TFS);
        }
    }
    public class Dev_Skills
    {
        public Dev_Rating CodingSkills{get;set;}
        public Dev_Rating TroubleShootingSkills {get;set;}
        public Dev_Rating QualityAssurance {get;set;}
        public Dev_Rating TimeLogging {get;set;}
        public Dev_Skills() { }
        public Dev_Skills(Dev_Rating c, Dev_Rating q, Dev_Rating t, Dev_Rating tr)
        {
            this.CodingSkills = c;
            this.QualityAssurance = q;
            this.TimeLogging = t;
            this.TroubleShootingSkills = tr;
        }
    }
    public class Tech_skills
    {
        public Tech_Rating TFS{ get; set; }
        public Tech_Rating GIT{get;set;}
        public Tech_Rating CSharp{get;set;}
        public Tech_Rating ASPDotNETCORE{get;set;}
        public Tech_Rating Ruby{get;set;}
        public Tech_Rating AngularJS {get;set;}
        public Tech_skills() { }
        public Tech_skills(Tech_Rating aj,Tech_Rating a,Tech_Rating c,Tech_Rating g,Tech_Rating r,Tech_Rating t)
        {
            this.AngularJS = aj;
            this.ASPDotNETCORE = a;
            this.CSharp = c;
            this.GIT = g;
            this.Ruby = r;
            this.TFS = t;
        }
    }

    public enum Dev_Rating { NotRated,Unsatisfactory, NeedsImprovement, MeetsExpectations, AboveExpectations, Outstanding }
    public enum Tech_Rating { NotRated,Beginner, Intermediate, Proficient, Expert }
    public enum Designations { NotGiven,JuniorDeveloper,Developer,SeniorDeveloper,Manager}
}