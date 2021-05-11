﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.DbRepository;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmUser
{
    public class GetCrmUserHandler
    {
        readonly ICrmUserRepository _crmUserRepository;

        public GetCrmUserHandler(ICrmUserRepository crmUserRepository)
        {
            _crmUserRepository = crmUserRepository;
        }

        public async Task<GetCrmUserResponse> GetCrmUserFromDb(GetCrmUserRequest getCrmUserRequest)
        {
            //count control will be added with automapper library

            var crmusers =await _crmUserRepository.GetWhereAsync(p=>p.UserName.Contains(getCrmUserRequest.UserName) && p.Password.Contains(getCrmUserRequest.Password) );
            GetCrmUserResponse getCrmUserResponse = new GetCrmUserResponse()
            {
                BusinessUnitId = crmusers.First().BusinessUnitId,
                UserName = crmusers.First().UserName,
                OdataContext = crmusers.First().OdataContext,
                OrganizationId = crmusers.First().OrganizationId,
                Password = crmusers.First().Password,
                UserId = crmusers.First().UserId
            };
            return  getCrmUserResponse;
        }

    }
}