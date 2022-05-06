using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyWebSite.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Bogus;

namespace MyWebSite.Models
{
    public static class SeedData
    {
        private static Skill[] AddSkill()
        {
            return new Skill[]
            {
                new Skill
                {
                    Name = "Computer Skills",
                    Percentage = 90
                },
                new Skill
                {
                    Name = "Teachability",
                    Percentage = 85
                },
                new Skill
                {
                    Name = "Active Listening",
                    Percentage = 90
                },
                new Skill
                {
                    Name = "Leadership",
                    Percentage = 75
                },
                new Skill
                {
                    Name = "Prioritizing",
                    Percentage = 80
                },
                new Skill
                {
                    Name = "Problem Solving",
                    Percentage = 85
                },
            };
        }
        

       
        
        private static Experience[] AddExperience()
        {


            return new Experience[] { new Experience
                {
                    Title = "IT Assistant",
                    Location = "Invercargill",
                    Duration = "03/2022 - Now (2 months)",
                    Description = "Providing Tier 1 support At SIT IT department which includes install, configure, test and maintain operating systems, application software and system management tools, implementing new equipment, provide on-going technical support, maintenance and troubleshooting to network users and maintain records/logs of repairs, fixes and maintenance schedule"
                },
                new Experience
                {
                    Title = "Imaging Assistant",
                    Location = "Invercargill",
                    Duration = "11/2021 - 02/2022 (4 months)",
                    Description = "During this internship at SIT, I was responsible for re-imaging devices ready for on selling, implementing new equipment as well as de-commissioning old equipment, troubleshooting, receipting and troubleshootiung network faults."
                },
                new Experience
                {
                    Title = "Network Internship",
                    Location = "Invercargill",
                    Duration = "07/2021 - 11/2021 (4 months)",
                    Description = "During this internship a small team of us were upgrading SIT internal network, this involved documenting the current network, de-commissioning network equipment, implementing new equipment with cable management, reciepting and troubleshooting network faults."

                },
                new Experience
                {
                    Title = "Lead of Software developers",
                    Location = "Beijing, China",
                    Duration = "2011-2017",
                    Description = "Helping the company to provid software development consulting service. We have created massive middlewares for Enterprise Management Information Systems, SEO Management Systems, Server Deploying, Database Architecture Design. I used Ruby on Rails to implement these solutions to the requirements of my clients."

                }
            };
        }
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyWebSiteContext(serviceProvider.GetRequiredService<DbContextOptions<MyWebSiteContext>>()))
            {

                if (!context.Skill.Any())
                    context.Skill.AddRange(AddSkill());
                if (!context.Experience.Any())
                    context.Experience.AddRange(AddExperience());
            
                


                context.SaveChanges();
            }
        }
    }
}