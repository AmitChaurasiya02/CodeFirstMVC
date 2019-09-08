using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CodeFristMVC_8_9_19.Models
{
    [Table("tbl_Student")]
    public class Student
    {
        [Key]
        public int Std_Id { get; set; }


        [Required(ErrorMessage ="Name is Required")]
        [StringLength(40,ErrorMessage ="Can not accept more then 40 char")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage ="Invalid Name")]
        [MinLength(3,ErrorMessage ="Name shoult contain atleast 3 char")]
        public string  Std_Name { get; set; }


        [Required(ErrorMessage = "Address is Required")]
       
        public string address { get; set; }
        [Required(ErrorMessage ="Email is Required")]
        [RegularExpression(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$", ErrorMessage ="Email is invalid")]

        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Date is Required")]

        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [RegularExpression(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,10})$", ErrorMessage ="Invalid Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is Required")]
        [Compare("Password",ErrorMessage ="Password does not match")]
        public string CPassword { get; set; }

        [Required(ErrorMessage = "Age is Required")]
        [Range(18,60,ErrorMessage ="Age should ly between 18-60")]
        public int age { get; set; }


    }

    public class Db:DbContext
    {
        public Db():base("CS")
        {

        }

        public DbSet<Student> Students { get; set; }





    }

}