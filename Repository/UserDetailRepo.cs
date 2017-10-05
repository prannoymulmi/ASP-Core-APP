using System.Collections.Generic;
using System.Linq;
using App.Models;

namespace App.Repository
{
    public class UserDetailRepo :IUserDetailRepo
    {
        private readonly ProfileContextDb _userRepo;

        public UserDetailRepo(ProfileContextDb userRepo)
        {
            _userRepo = userRepo;
        }
        
        public List<Hobbies> GetHobbies(string id)
        {
            return _userRepo.Hobbies.Where(x => x.AspNetUserId == id).ToList();
            
        }

        public List<Individual> GetIndividual(string id)
        {
            return _userRepo.Indvidual.Where(x => x.AspNetUserId == id).ToList();
        }

        public List<Organization> GetOrganization(string id)
        {
            return _userRepo.Organization.Where(x => x.AspNetUserId == id).ToList();
        }
    }
}