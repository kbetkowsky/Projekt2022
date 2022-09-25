using System.ComponentModel.DataAnnotations;

namespace ProjectOne.Pages.TodoFeature
{
    public class TodoItem
    {
        [Required]
        public string Title { get; set; }

        public bool IsDone { get; set; }
    }
}
