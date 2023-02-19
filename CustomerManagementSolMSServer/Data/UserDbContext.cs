using System;
using System.Collections.Generic;
using CustomerManagementSolMSServer.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagementSolMSServer.Data;

public partial class UserDbContext : DbContext
{
    public UserDbContext()
    {
    }

    public UserDbContext(DbContextOptions<UserDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    
}
