using System.ComponentModel.DataAnnotations;

namespace DLStat.API.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }
        public int PositionNumber { get; set; }
        public string PositionTitle { get; set; }
    }
}