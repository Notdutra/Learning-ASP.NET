using System.ComponentModel.DataAnnotations;

namespace demoslabs4.Dtos
{
    public class Todo
    {
        [Required]
        [StringLength(50)]
        public string Title {get;set;}
        public string Notes {get;set;}
        public bool Done {get;set;}
        [Required]
        public string Id {get;set;}
    }
}