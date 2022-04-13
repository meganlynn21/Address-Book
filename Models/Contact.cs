using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Contact
    {
        // Required Specifies that a data field value is required.
        [Required]
        // Displays what you want the user to see in the column(the label) Makes it read First Name instead of FirstName
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [DataType(DataType.PostalCode)]
        public int Zip { get; set; }

        // Makes sure what the user enters is a valid email address
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        // This is a type that consists of both data and time information
        public DateTime Created { get; set; }

        [NotMapped]
        [Display(Name = "Image")]
        [DataType(DataType.Upload)]
        public IFormFile ImageFile { get; set; }

        // stores a digital representation (byte array) for the contact image
        public byte[] ImageData { get; set; }

        // type of image for example, is it a png or jpg?
        public string ImageType { get; set; }

        // Acts as a primary key
        public int Id { get; set; }

        // When we do not want this to be in a column we put NotMapped
        [NotMapped]
        public string FullName { get { return $"{FirstName} {LastName}"; } }

    }
}
