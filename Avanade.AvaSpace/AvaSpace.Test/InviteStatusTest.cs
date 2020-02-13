using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Services;
using AvaSpace.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AvaSpace.Test
{
    [TestClass]
    public class InviteStatusTest : BaseTest
    {
        private readonly IInviteStatusService _service;

        public InviteStatusTest()
        {
            var repository = new InviteStatusRepository();

            _service = new InviteStatusService(repository);
        }


        [TestMethod]
        public override void IntegratedTest()
        {
            var id = _service.Insert(new InviteStatus() { Description = "HELLO WORLD" });

        }
    }
}
