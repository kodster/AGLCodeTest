using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using AGLLabs;

namespace TestAGLLabs
{
    [TestClass]
    public class AGLHandlerTests
    {
        private OwnerPetsModel[] ownerPetsModels = null;

        [TestInitialize]
        public void Init()
        {
            ownerPetsModels = new List<OwnerPetsModel>
            {
                new OwnerPetsModel
                {
                    Gender = "Male",
                    PetName = "Same"
                },
                new OwnerPetsModel
                {
                    Gender = "Female",
                    PetName = "Sophie"
                }
            }.ToArray();
        }

        [TestMethod]
        public void GetPetOwnersByMale()
        {
            var mockedHandler = new Mock<IAglPetHandler>();
            //mockedHandler.Object(ownerPetsModels)
        }

        public void GetPetOwnersByFemale()
        {
            var mockedHandler = new Mock<IAglPetHandler>();
            //mockedHandler.Object(ownerPetsModels)
        }
    }
}
