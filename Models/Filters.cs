using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Filters 
    // filters data based on category 
    {
        public Filters(string filterString)
        {
            FilterString = filterString ?? "all-all-all";// this will make it so if its empty will show everything 
            string[] filters = FilterString.Split('-');
            CategoryId = filters[0]; // 0 is category id 
            Due = filters[1]; // 1 is when its is due 
            StatusId = filters[2]; // status id is whether to do is done or not. 

        }

        public string FilterString { get;  }
        public string CategoryId { get; }
        public string Due { get;  }
        public string StatusId { get;}

        public bool HasCategory => CategoryId.ToLower() != "all"; // means user is not filtering by category
        public bool HasDue => Due.ToLower() != "all"; // user is not filtering by due 
        public bool HasStatus => StatusId.ToLower() != "all";  // means user is not filtering by status 

        public static Dictionary<string, string> DueFilterValues =>
            new Dictionary<string, string>
            {
                {"future", "Future"},
                {"past", "Past"},
                {"today", "Today"},
            };
        
        public bool IsPast => Due.ToLower() == "past"; // means user is not filtering by category
        public bool IsFuture => Due.ToLower() == "future"; // user is not filtering by due 
        public bool IsToday => Due.ToLower() == "today";  // means user is not filtering by status 
    }
}