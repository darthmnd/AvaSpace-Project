using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Services;
using AvaSpace.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AvaSpace.Test
{
    [TestClass]
    public class MidiaTest : BaseTest
    {
        private readonly IMidiaService _service;

        public MidiaTest()
        {
            var repository = new MidiaRepository();

            _service = new MidiaService(repository);
        }

        [TestMethod]
        public void ValidateTest()
        {
            var midiaType = new Midia();

            _service.Insert(midiaType);
        }

        [TestMethod]
        public override void IntegratedTest()
        {
            var midiaTypeReposiory = new MidiaTypeRepository();

            var type = midiaTypeReposiory.Get(x => x.Description == "Photo").Single();

            var midia = new Midia
            {
                Description = "Foto na praia",
                Path = "/photos/file.jpg",
                MidiaTypeId = type.Id
            };

            var id = _service.Insert(midia);

            _service.Delete(id);
        }
    }
}
