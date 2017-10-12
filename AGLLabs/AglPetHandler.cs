using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AGLLabs
{
    public class AglPetHandler : IAglPetHandler
    {
        public enum Gender
        {   
            Male,
            Female
        };

        public IEnumerable<OwnerPetsModel> GetPetOwnersByGender(List<Owner> owners, Gender gender)
        {
            var g = gender.ToString();
            var petOwners = from o in owners
                                 where (o.Pets != null && o.Gender == gender.ToString())
                                 orderby o.Name
                                 select o;

            var ownerPetsModels = (from petOwner in petOwners
                from pet in petOwner.Pets
                select new OwnerPetsModel()
                {
                    Gender = petOwner.Gender,
                    PetName = pet.Name
                }).ToList();

            var sortedPetsByGender = ownerPetsModels.OrderBy(p => p.PetName).ToList();

            return sortedPetsByGender;
        }
    }
}
