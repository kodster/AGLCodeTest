using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

namespace AGLLabs
{
    class Program
    {
        private static UnityContainer _container;
        static void Main(string[] args)
        {
            _container = new UnityContainer();
            _container.RegisterType<IAglPetHandler, AglPetHandler>();

            View(LoadJson());
        }

        public static List<Owner> LoadJson()
        {
            using (var client = new WebClient())
            {
                var json = client.DownloadString("http://agl-developer-test.azurewebsites.net/people.json");
                var reader = new JsonTextReader(new StringReader(json));
                var serializer = new JsonSerializer();
                var owners = serializer.Deserialize<List<Owner>>(reader);
                return owners;
            }
        }


        public static void View(List<Owner> owners)
        {
         
            var handler = _container.Resolve<AglPetHandler>();

            var maleOwnersSortedPets = handler.GetPetOwnersByGender(owners, AglPetHandler.Gender.Male);

            Console.WriteLine("Male");
            foreach (var maleOwnersSortedPet in maleOwnersSortedPets)
            {
                Console.WriteLine("\t - {0}", maleOwnersSortedPet.PetName);
            }

            var femaleOwnersSortedPets = handler.GetPetOwnersByGender(owners, AglPetHandler.Gender.Female);

            Console.WriteLine("Female");
            foreach (var femaleOwnersSortedPet in femaleOwnersSortedPets)
            {
                Console.WriteLine("\t - {0}", femaleOwnersSortedPet.PetName);
            }

            Console.ReadLine();
        }
    }
}
