using System.Collections.Generic;
using App.Models;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace App.Repository
{
    public interface IUserDetailRepo
    {
        List<Hobbies> GetHobbies(string id);
        List<Individual> GetIndividual(string id);
        List<Organization> GetOrganization(string id);
    }
}    