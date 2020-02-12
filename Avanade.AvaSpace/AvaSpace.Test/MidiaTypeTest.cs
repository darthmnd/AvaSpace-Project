using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Services;
using AvaSpace.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AvaSpace.Test
{
    [TestClass]
    public class MidiaTypeTest : BaseTest
    {
        private readonly IMidiaTypeService _service;

        public MidiaTypeTest()
        {
            var repository = new MidiaTypeRepository();

            _service = new MidiaTypeService(repository);
        }

        [TestMethod]
        public void ValidateTest()
        {
            var midiaType = new MidiaType();

            _service.Insert(midiaType);
        }

        [TestMethod]
        public override void IntegratedTest()
        {
            var type = new MidiaType
            {
                Description = "TESTE",
                Extensions = "ext,para,teste"
            };

            var id = _service.Insert(type);

            _service.Delete(id);
        }
    }
}
