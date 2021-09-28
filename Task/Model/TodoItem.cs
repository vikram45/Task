using System.ComponentModel.DataAnnotations;

namespace TodoAPI.Models
{
    public class TodoItem
    {
        [Required]
        public string ID { get; set; }
        [Required]
        public string category { get; set; }

        [Required]
        public string task_subject { get; set; }

        [Required]
        public string priority { get; set; }
        [Required]
        public string Alloted_to { get; set; }
        [Required]
        public string Target_Date { get; set; }
        [Required]
        public string year { get; set; }
        [Required]
        public string end_Date { get; set; }


    }
}