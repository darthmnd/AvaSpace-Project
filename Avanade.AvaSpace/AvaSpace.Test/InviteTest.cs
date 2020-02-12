using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Services;
using AvaSpace.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AvaSpace.Test
{
    [TestClass]
    public class InviteTest : BaseTest
    {
        private readonly IInviteService _service;
        private readonly IUserService _userService;

        public InviteTest()
        {
            var repositoryInvite = new InviteRepository();
            var repositoryUser = new UserRepository();

            _service = new InviteService(repositoryInvite, repositoryUser);
        }

        [TestMethod]
        public override void IntegratedTest()
        {
            var invitestatus = new InviteStatus();

            var invite = new Invite
            {
                SenderId = Guid.NewGuid(),
                ReceiverId = Guid.NewGuid(),
                InviteStatus = "aguardando"
            };

            var id = _service.Insert(invite);

            _service.Delete(id);
        }
    }
}

