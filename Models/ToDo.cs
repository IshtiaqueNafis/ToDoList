using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class ToDo
    {
        public int TodoId { get; set; }
        
     [Required(ErrorMessage="Please Enter Description")]   
     public string Description { get; set; }
     
     [Required(ErrorMessage="Please Enter Due date ")] 
     public DateTime? DueDate { get; set; } // nullable so custom error message can be shown and used. 
     
     [Required(ErrorMessage="Please select a category")] 
     public string CategoryId { get; set; }
     
     [Required(ErrorMessage="Please select a status")]
     public string StatusId { get; set; }

     public bool OverDue => StatusId == "open" && DueDate < DateTime.Today; // checks whether or not something is due or not. 

        // both are navigation property 
        public Category Category { get; set; }
        public Status Status { get; set; }
        
    }
}