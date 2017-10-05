using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public static class Initializer
    {
        public static void InitializeContext(ProfileContextDb context)
        {
            context.Database.EnsureCreated();
           
            //Return if Any data is in the table
            if (context.Indvidual.Any())
            {
                return;   
            }

            // Individuals
            var individual = new Individual
            {
                FullName = "Prannoy",
                DateOfBirth = new DateTime(1994,08,31),
                Address = "4437 Texas Street",
                AspNetUserId = "7dc62b0f-00ca-4c06-a173-026a33151430",
                State = "Hamburg",
                City = "Hamburg",
                ZipCode = "22527"
            };

            context.Indvidual.Add(individual);
            context.SaveChanges();

            // Organizations
            var organization = new Organization
            {
                BusinessName = "None",
                HireDate = DateTime.Now,
                Address = "Dehnheide",
                AspNetUserId = "7dc62b0f-00ca-4c06-a173-026a33151430",
                State = "Hamburg",
                Profession = "Developer",
                City = "Hamburg",
                ZipCode = "32323"
            };
            context.Organization.Add(organization);
            context.SaveChanges();
            
            // Hobbies
            var hobby = new Hobbies
            {
                HobbieId = Guid.NewGuid(),
                Name = "Running",
                Rating = 5,
                AspNetUserId = "7dc62b0f-00ca-4c06-a173-026a33151430",
            };
            context.Hobbies.Add(hobby);
            context.SaveChanges();
            
            var hobbyTwo = new Hobbies
            {
                HobbieId = Guid.NewGuid(),
                Name = "Swimming",
                Rating = 3,
                AspNetUserId = "7dc62b0f-00ca-4c06-a173-026a33151430",
            };
            context.Hobbies.Add(hobbyTwo);
            context.SaveChanges();

         
           
        }
    }
}