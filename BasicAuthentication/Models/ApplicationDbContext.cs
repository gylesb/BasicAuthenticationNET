using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BasicAuthentication.Models
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<ApplicationUser>(entity => entity.Property(m => m.Id)
				.HasMaxLength(127));
			builder.Entity<ApplicationUser>(entity => entity.Property(m => m.NormalizedEmail)
				.HasMaxLength(127));
			builder.Entity<ApplicationUser>(entity => entity.Property(m => m.NormalizedUserName)
				.HasMaxLength(127));

			builder.Entity<IdentityRole>(entity => entity.Property(m => m.Id)
				.HasMaxLength(127));
			builder.Entity<IdentityRole>(entity => entity.Property(m => m.NormalizedName)
				.HasMaxLength(127));

			builder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.LoginProvider)
				.HasMaxLength(127));
			builder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.ProviderKey)
				.HasMaxLength(127));
			builder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.UserId)
				.HasMaxLength(127));

			builder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.UserId)
				.HasMaxLength(127));
			builder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.RoleId)
				.HasMaxLength(127));

			builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.UserId)
				.HasMaxLength(127));
			builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.LoginProvider)
				.HasMaxLength(127));
			builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.Name)
				.HasMaxLength(127));

			builder.Entity<IdentityUserClaim<string>>(entity => entity.Property(m => m.Id)
				.HasMaxLength(127));
			builder.Entity<IdentityUserClaim<string>>(entity => entity.Property(m => m.UserId)
				.HasMaxLength(127));
			builder.Entity<IdentityRoleClaim<string>>(entity => entity.Property(m => m.Id)
				.HasMaxLength(127));
			builder.Entity<IdentityRoleClaim<string>>(entity => entity.Property(m => m.RoleId)
				.HasMaxLength(127));
		}

		public DbSet<Item> Items { get; set; }
	}
}
