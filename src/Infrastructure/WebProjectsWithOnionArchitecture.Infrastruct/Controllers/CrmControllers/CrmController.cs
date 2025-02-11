﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUserByName;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Commands.InsertCrmAccount;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Commands.InsertCrmUser;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Queries.GetCrmAccount;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Queries.GetCrmUser;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Commands.TruncateCrmUser;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmUser;
using WebProjectsWithOnionArchitecture.Infrastruct.ServiceManagers.Crm.Services;

namespace WebProjectsWithOnionArchitecture.Infrastruct.Controllers.CrmControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrmController : ControllerBase
    {
        private readonly CrmServiceManager _crmServiceManager;
        private readonly GetCrmUserHandler _getCrmUserHandler;
        private readonly TruncateCrmUserCommandHandler _truncateCrmUserCommandHandler;
        
        public CrmController(CrmServiceManager crmServiceManager, GetCrmUserHandler getCrmUserHandler, TruncateCrmUserCommandHandler truncateCrmUserCommandHandler)
        {
            _crmServiceManager = crmServiceManager;
            _getCrmUserHandler = getCrmUserHandler;
            _truncateCrmUserCommandHandler = truncateCrmUserCommandHandler;
        
        }

        #region CrmUser

        [HttpPost("get/crmuser/fromservice")]
        public async Task<string> GetCrmUserFromService(GetCrmUserRequest getCrmUserRequest)
        {
            return await _crmServiceManager.GetCrmUserManager(getCrmUserRequest);
        }

        [HttpPost("insert/crmuser")]
        public async Task<InsertCrmUserCommandServiceResponse> InsertCrmUserFromService(GetUserByNameRequest getUserByNameRequest)
        {
            return await _crmServiceManager.InsertCrmUserManager(getUserByNameRequest);
        }

        [HttpGet("get/crmuser/fromdb")]
        public async Task<List<GetCrmUserResponse>> GetCrmUserFromDb()
        {
            return await _getCrmUserHandler.GetCrmUserFromDb();
        }

        [HttpPost("truncate/crmuser/fromdb")]
        public async Task<TruncateCrmUserCommandServiceResponse> TruncateCrmUserFromDb(TruncateCrmUserCommandRequest truncateCrmUserCommandRequest)
        {
            return await _truncateCrmUserCommandHandler.TruncateCrmUser(truncateCrmUserCommandRequest);
        }

        #endregion

        #region CrmAccount

        [HttpPost("get/crmaccount/fromservice")]
        public async Task<List<string>> GetCrmAccountFromService(GetCrmAccountRequest getCrmAccountRequest)
        {
            return await _crmServiceManager.GetCrmAccountManager(getCrmAccountRequest);
        }

        [HttpPost("insert/crmaccount")]
        public async Task<InsertCrmAccountCommandServiceResponse> InsertCrmAccountFromService(GetUserByNameRequest getUserByNameRequest)
        {
            return await _crmServiceManager.InsertCrmAccountManager(getUserByNameRequest);
        }

        //[HttpGet("get/crmaccount/fromdb")]
       

        #endregion






    }
}
