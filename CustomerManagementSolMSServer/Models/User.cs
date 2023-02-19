using System;
using System.Collections.Generic;

namespace CustomerManagementSolMSServer.Models;

public partial class User
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Address { get; set; }

    public string? Password { get; set; }

    public int Type { get; set; }
}
