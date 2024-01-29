using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity;

public class ApplicationUser : IdentityUser<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ImageUrl { get; set; }

    public bool IsActive { get; set; }
    public string RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }
    public string ObjectId { get; set; }
}