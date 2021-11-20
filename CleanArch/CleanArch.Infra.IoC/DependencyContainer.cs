using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.CommandHandlers;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Commands;
using CleanArch.Domain.Core.Events;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Bus;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemory Bus
            services.AddScoped<IMediatorHandler, InMemoryBus>();
            
            // Application Services
            services.AddScoped<ICourseService, CourseService>();

            //add request handlers
            var assembly = AppDomain.CurrentDomain.GetAssemblies();
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

            // Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();

            services.AddScoped<UniversityDbContext>();
        }
    }
}
