using IdentityDemo.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace IdentityDemo.Context
{
	public class AppDbContext:IdentityDbContext<User,Role,Guid,UserClaim,UserRole,UserLogin,RoleClaim,UserToken>
	{
		public AppDbContext()
		{
			
		}
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.ApplyConfigurationsFromAssembly(assembly:Assembly.GetExecutingAssembly());	

		}
	}
}
