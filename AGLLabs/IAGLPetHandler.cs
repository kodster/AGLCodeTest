using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGLLabs
{
    public interface IAglPetHandler
    {       
        IEnumerable<OwnerPetsModel> GetPetOwnersByGender(List<Owner> owners, AglPetHandler.Gender gender);
    }
}
