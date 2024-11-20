using IdentityDemo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityDemo.Mapping
{
	public class UserClaimMap : IEntityTypeConfiguration<UserClaim>
	{
		public void Configure(EntityTypeBuilder<UserClaim> builder)
		{
			// Primary key
			builder.HasKey(uc => uc.Id);

			// Maps to the AspNetUserClaims table
			builder.ToTable("AspNetUserClaims");
		}
	}
}
