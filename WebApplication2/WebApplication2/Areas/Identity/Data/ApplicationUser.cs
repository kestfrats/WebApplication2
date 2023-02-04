using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WebApplication2.Areas.Blog.Data;

namespace WebApplication2.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //navigation

    public ApplicationUser()
    {
        Articles= new HashSet<Article>();
    }

    public virtual ICollection<Article> Articles { get; set;}
}

