using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection servicecolection)
        {
            servicecolection.AddMemoryCache();
            servicecolection.AddSingleton<ICacheManager, MemoryCacheManager>();
            servicecolection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            servicecolection.AddSingleton<Stopwatch>();
        }


    }
}