using System;
using System.Collections.Generic;

namespace DO_AN.Models.SQL_Server;

public partial class UserInfo
{
    public string? Magioithieu1 { get; set; }

    public string Name { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string Day { get; set; } = null!;

    public string Month { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;
}
