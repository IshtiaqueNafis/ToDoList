using System.Collections.Generic;

namespace ToDoList.Models.ViewModel
{
    public class ToDoViewModel
    {
        public ToDoViewModel()
        {
            CurrentTask = new ToDo();
        }

        public Filters Filters { get; set; }
        public Status Statuses { get; set; }
        public List<Category>Categories { get; set; }

        public Dictionary <string,string>DueFilters{get; set; }
        public List<ToDo> Tasks { get; set; }

        public ToDo CurrentTask { get; set; }
      
        
    }
}