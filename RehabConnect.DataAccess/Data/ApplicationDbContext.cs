using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RehabConnect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehabConnect.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //public DbSet<Announcement> Announcements { get; set; }
        //public DbSet<RegistrationStatus> RegistrationStatuses { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<ParentDetail> ParentDetails { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Therapist> Therapists { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<CustomerSupport> CustomerSupports { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Roadmap> Roadmap { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //  Program Module
            // Data Seeding -

            modelBuilder.Entity<Roadmap>().HasData(
                new Roadmap{RoadmapId = 1,Name = "Idzmir Hub Roadmap"},
                new Roadmap{RoadmapId = 2,Name = "Test 2"});
            
            modelBuilder.Entity<Step>().HasData(
                new Step{StepId = 1, RoadmapId = 1, StepNo = 1, Title = "Screening and Consultation"},
                new Step{StepId = 2, RoadmapId = 1, StepNo = 2, Title = "Full Assessment"},
                new Step{StepId = 3, RoadmapId = 1, StepNo = 3, Title = "Intervention with consistency"},
                new Step{StepId = 4, RoadmapId = 1, StepNo = 4, Title = "Re-assessment"},
                new Step{StepId = 5, RoadmapId = 1, StepNo = 5, Title = "Road to School"},
                new Step{StepId = 6, RoadmapId = 2, StepNo = 1, Title = "Test1"},
                new Step{StepId = 7, RoadmapId = 2, StepNo = 2, Title = "Test2"}
                );
            
            modelBuilder.Entity<Program>().HasData(
                new Program{ProgramID = 1, ProgramName = "Consultation", NumOfSession = 1,StepId = 1},
                new Program{ProgramID = 2, ProgramName = "Assessment",  NumOfSession = 3,StepId = 2},
                new Program{ProgramID = 3, ProgramName = "Full Development Report",NumOfSession = 1,StepId = 2},
                new Program{ProgramID = 4, ProgramName = "Program A", NumOfSession = 4,StepId =3},
                new Program{ProgramID = 5, ProgramName = "Program B", NumOfSession = 8,StepId = 3},
                new Program{ProgramID = 6, ProgramName = "Program C",  NumOfSession = 12,StepId = 3},
                new Program{ProgramID = 7, ProgramName = "Program D",  NumOfSession = 20,StepId = 3},
                new Program{ProgramID = 8, ProgramName = "Assessment",  NumOfSession = 3,StepId = 4},
                new Program{ProgramID = 9, ProgramName = "Full Development Report",  NumOfSession = 1,StepId = 4},
                new Program{ProgramID = 10, ProgramName = "Ready to School A",  NumOfSession = 4,StepId = 5},
                new Program{ProgramID = 11, ProgramName = "Ready to School B",  NumOfSession = 8,StepId = 5}
                );
            
           
            base.OnModelCreating(modelBuilder);

        }

    }
}
