using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoItemsLearn
{
    public class TodoItem
    {
        [Required]
        public string Tittle { get; set; }
        public bool IsDone { get; set; }
    }
}
