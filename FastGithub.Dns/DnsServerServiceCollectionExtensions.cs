﻿using FastGithub.Dns;
using Microsoft.Extensions.DependencyInjection;

namespace FastGithub
{
    /// <summary>
    /// dns服务注册扩展
    /// </summary>
    public static class DnsServerServiceCollectionExtensions
    {
        /// <summary>
        /// 注册dns服务
        /// </summary>
        /// <param name="services"></param> 
        /// <returns></returns>
        public static IServiceCollection AddDnsServer(this IServiceCollection services)
        {
            return services
                .AddSingleton<RequestResolver>()
                .AddHostedService<DnsServerHostedService>();
        }
    }
}
