using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Strona.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the Konto_Pacjenta class
    public class Patient_account : IdentityUser
    {
        
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set;}
       
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Surname { get; set; }

     

    }
}
