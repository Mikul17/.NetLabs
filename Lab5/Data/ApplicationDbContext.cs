using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab5.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    protected override void OnModelCreating( ModelBuilder builder )
    {
        base.OnModelCreating( builder );
        builder.HasDefaultSchema( "lab5" );
    }
}
