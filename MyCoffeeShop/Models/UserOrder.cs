using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoffeeShop.Models
{
    public class UserOrder
    {
        private string firstName;
        private string lastName;
        private string email;
        private string IOH;
        private string flavor;
        private string type;
        private string total;

        [DisplayName("First Name")]
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string FirstName { get => firstName; set => firstName = value; }

        [DisplayName("Last Name")]
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string LastName { get => lastName; set => lastName = value; }

        [DisplayName("E-mail")]
        [Required]
        [MaxLength(30)]
        [MinLength(2)]
        public string Email { get => email; set => email = value; }

        [Required]
        public string IOH1 { get => IOH; set => IOH = value; }

        [Required]
        public string Flavor { get => flavor; set => flavor = value; }

        [Required]
        public string Type { get => type; set => type = value; }

        [DataType(DataType.Currency)]
        public string Total { get => total; set => total = value; }
        


    }
}
