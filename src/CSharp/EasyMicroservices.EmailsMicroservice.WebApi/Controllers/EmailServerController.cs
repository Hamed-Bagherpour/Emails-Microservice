﻿using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.EmailsMicroservice.Contracts.Common;
using EasyMicroservices.EmailsMicroservice.Contracts.Requests;
using EasyMicroservices.EmailsMicroservice.Database.Entities;

namespace EasyMicroservices.EmailsMicroservice.WebApi.Controllers
{
    public class EmailServerController : SimpleQueryServiceController<ServerEntity, CreateEmailServerRequestContract, UpdateEmailServerRequestContract, EmailServerContract, long>
    {
        private readonly IContractLogic<ServerEntity, CreateEmailServerRequestContract, UpdateEmailServerRequestContract, EmailServerContract, long> _contractlogic;
        public EmailServerController(IContractLogic<ServerEntity, CreateEmailServerRequestContract, UpdateEmailServerRequestContract, EmailServerContract, long> contractlogic) : base(contractlogic)
        {
            _contractlogic = contractlogic;
        }
    }
}
