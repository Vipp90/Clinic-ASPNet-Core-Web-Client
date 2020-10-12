using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Strona.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the Konto_Pacjenta class
    public class Konto_Pacjenta : IdentityUser
    {
        
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Imie { get; set;}
       
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Nazwisko { get; set; }

       
    }
}
