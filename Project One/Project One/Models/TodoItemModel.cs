using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project_One.Models
{
    public class TodoItemModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [DefaultValue(3)]
        [Range(1,5,ErrorMessage ="Number is not in range 1 to 5")]
        public int Priority { get; set; }

    }
}
