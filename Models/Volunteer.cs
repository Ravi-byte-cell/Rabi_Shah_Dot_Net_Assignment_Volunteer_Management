using System.ComponentModel.DataAnnotations;

namespace Rabi_Shah_Dot_Net_project.Models
{
    public class Volunteer
    {
        [Key] // Primary key
        public int VolunteerId { get; set; }

        public required string Name { get; set; }  // Required using C# 11 feature

        public required string SpecifiedWork { get; set; }  // Required using C# 11 feature
    }
}
