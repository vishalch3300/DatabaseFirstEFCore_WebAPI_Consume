using System.ComponentModel.DataAnnotations;

namespace DatabaseFirstEFCore_WebAPI_Consume.Models
{

    public class Student
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public int standard { get; set; }
    }
}
