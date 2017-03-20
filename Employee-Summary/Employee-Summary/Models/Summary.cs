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
        public DevSkills Dskill { get; set; }
        public Techskills Tskill { get; set; }

        public bool set { get; set; } = false;
        public Summary()
        {
            Id = Id + 1;
            Name = "Not Entered";
        }
        public Summary(string name, Designations designation, DevSkills dskill, Techskills tskill)
        {
            Id = Id + 1;
            this.Name = name;
            this.Designation = designation;
            this.Dskill = new DevSkills(dskill.CodingSkills,dskill.QualityAssurance,dskill.TimeLogging,dskill.TroubleShootingSkills);
            this.Tskill = new Techskills(tskill.AngularJS,tskill.ASPDotNETCORE,tskill.CSharp,tskill.GIT,tskill.Ruby,tskill.TFS);
        }
    }
    public class DevSkills
    {
        public DevRating CodingSkills{get;set;}
        public DevRating TroubleShootingSkills {get;set;}
        public DevRating QualityAssurance {get;set;}
        public DevRating TimeLogging {get;set;}
        public DevSkills() { }
        public DevSkills(DevRating c, DevRating q, DevRating t, DevRating tr)
        {
            this.CodingSkills = c;
            this.QualityAssurance = q;
            this.TimeLogging = t;
            this.TroubleShootingSkills = tr;
        }
    }
    public class Techskills
    {
        public TechRating TFS{ get; set; }
        public TechRating GIT{get;set;}
        public TechRating CSharp{get;set;}
        public TechRating ASPDotNETCORE{get;set;}
        public TechRating Ruby{get;set;}
        public TechRating AngularJS {get;set;}
        public Techskills() { }
        public Techskills(TechRating aj,TechRating a,TechRating c,TechRating g,TechRating r,TechRating t)
        {
            this.AngularJS = aj;
            this.ASPDotNETCORE = a;
            this.CSharp = c;
            this.GIT = g;
            this.Ruby = r;
            this.TFS = t;
        }
    }

    public enum DevRating { NotRated,Unsatisfactory, NeedsImprovement, MeetsExpectations, AboveExpectations, Outstanding }
    public enum TechRating { NotRated,Beginner, Intermediate, Proficient, Expert }
    public enum Designations { NotGiven,JuniorDeveloper,Developer,SeniorDeveloper,Manager}
}