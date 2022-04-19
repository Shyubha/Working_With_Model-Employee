using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Working_With_Model_Employee.Models
{
    public class Employee
    {
        [Key]
        [ScaffoldColumn(false)]
        [DisplayName("id")]
        public int id { get; set; }


        [DisplayName("Name")] 
        [MinLength(2)]
        [MaxLength(15)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }


        [DisplayName("Salary")]
        [Required(ErrorMessage = "Salary is required")]
        public int Salary { get; set; }


        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email  is required")]
        public string Email { get; set; }


        [DisplayName("Address")]
        [DataType(DataType.Text)]
        [MinLength(2)]
        [MaxLength(50)]
        [Required(ErrorMessage = "address  is required")]
        public int Address { get; set; }



        [DisplayName("Pincode")]
        [DataType(DataType.PostalCode)]
        [MaxLength(6)]
        [Required(ErrorMessage = "Pincode  is required")]
        public int Pincode { get; set; }
    }
}
