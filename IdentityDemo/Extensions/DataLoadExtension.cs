using IdentityDemo.Context;
using Microsoft.EntityFrameworkCore;

namespace IdentityDemo.Extensions
{
	public static  class DataLoadExtension
	{
		public static IServiceCollection LoadDataLoadExtension(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

			return services;

		}
	}
}
