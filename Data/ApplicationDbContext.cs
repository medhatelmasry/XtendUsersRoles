using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using XtendUsersRoles.Models;

namespace XtendUsersRoles.Data;

public class ApplicationDbContext : IdentityDbContext<XUser, XRole, string>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Use seed method here
        builder.Seed();
    }

}
