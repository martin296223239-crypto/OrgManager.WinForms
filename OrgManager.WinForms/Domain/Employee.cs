using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgManager.WinForms.Domain
{
    public class Employee
    {
        
            public int Id { get; set; }


            [MaxLength(20)]
            public string? Title { get; set; }


            [Required, MaxLength(100)]
            public string FirstName { get; set; } = null!;


            [Required, MaxLength(100)]
            public string LastName { get; set; } = null!;


            [Phone, MaxLength(30)]
            public string? Phone { get; set; }


            [EmailAddress, MaxLength(200)]
            public string? Email { get; set; }


            public override string ToString() =>
            string.IsNullOrWhiteSpace(Title)
            ? $"{FirstName} {LastName}"
            : $"{Title} {FirstName} {LastName}";
        }
    }
