﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Commands.InsertUser;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUser;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUserByName;
using WebProjectsWithOnionArchitecture.Domain.Entities.App.Entities;

namespace WebProjectsWithOnionArchitecture.Application
{
    public static class ServiceRegistration
    {

        public static void AddApplicationServices(this IServiceCollection serviceCollection)
        {
            //TODO:MediatR library will be added here.           

            serviceCollection.AddTransient<InsertUserCommandHandler>();
            serviceCollection.AddTransient<User>();
            serviceCollection.AddTransient<InsertUserCommandResponse>();
            serviceCollection.AddTransient<GetUserHandler>();
            serviceCollection.AddScoped<List<GetUserResponse>>();
            serviceCollection.AddTransient<GetUserResponse>();
            serviceCollection.AddTransient<GetUserByNameHandler>();
            serviceCollection.AddTransient<GetUserByNameResponse>();
            




        }
    }
}
