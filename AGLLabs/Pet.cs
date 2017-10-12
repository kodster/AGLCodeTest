using System.Collections.Generic;

namespace AGLLabs
{
    public class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class Owner
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public List<Pet> Pets { get; set; }
    }

}
