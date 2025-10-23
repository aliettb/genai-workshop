using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Authentication;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.HasDefaultSchema("auth");

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = "cbfe03b8-8a14-4138-ad1d-58fd4536dfa7",
                Name = "Owner",
                NormalizedName = "OWNER"
            },
            new IdentityRole
            {
                Id = "c9880e29-3ca4-4d5d-9c26-5615dec36007",
                Name = "User",
                NormalizedName = "USER"
            }
        );
    }
}
