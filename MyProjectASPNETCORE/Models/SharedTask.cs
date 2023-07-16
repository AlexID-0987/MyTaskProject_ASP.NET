using System.ComponentModel.DataAnnotations;

namespace MyProjectASPNETCORE.Models
{
    public class SharedTask
    {
        public int Id { get; set; }
        
        public string Task { get; set; }
        
        public string DayOfWeek { get; set; }
        
        public string Title { get; set; }   

        
    }
}
