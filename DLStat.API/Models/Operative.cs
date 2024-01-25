using System.ComponentModel.DataAnnotations;

namespace DLStat.API.Models
{
    public class Operative
    {
        [Key]
        public int Id { get; set; }
        public string OperativeName { get; set; }
        //public string? OperativeDepartment { get; set; }
    }
}