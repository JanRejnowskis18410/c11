using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.DTOs
{
    public class UpdateDoctorRequest
    {
        [MaxLength(100, ErrorMessage = "Za długie imię")]
        public string FirstName { get; set; }
        [MaxLength(100, ErrorMessage = "Za długie nazwisko")]
        public string LastName { get; set; }
        [MaxLength(100, ErrorMessage = "Za długi email")]
        public string Email { get; set; }
    }
}
