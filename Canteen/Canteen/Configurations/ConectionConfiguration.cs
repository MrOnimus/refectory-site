using Canteen.Core.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Canteen.Configurations
{
    public static class ConectionConfiguration
    {// вынесли подключение БД из стартап в отдельный класс(для удобства)
        public static IServiceCollection AddConnectionProvider(this IServiceCollection services,
            IConfiguration conf)
        {
            services.AddDbContext<CanteenDbContext>(opt => opt.UseMySQL(conf.GetConnectionString("Cook")));
            // подключаем mysql, достаем строку подключения с помощью iconfiguration
            return services;
        }
    }
}
