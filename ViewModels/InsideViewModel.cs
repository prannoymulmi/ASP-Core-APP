using System.Collections.Generic;
using App.Models;

namespace App.ViewModels
{
    public class InsideViewModel
    {
        public List<Individual> Individuals { get; set; }
        public List<Hobbies> Hobbies { get; set; }
        public List<Organization> Organizations { get; set; }
    }
}