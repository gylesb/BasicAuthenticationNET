using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BasicAuthentication.Models
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{

	}
    protected override void OnMOdelCreating(ModelBuilder builder)
    {
        TypeBaseExtensions.OnModelCreating(builder);
    }
    public DbSet<Item> Items { get; set; }
}