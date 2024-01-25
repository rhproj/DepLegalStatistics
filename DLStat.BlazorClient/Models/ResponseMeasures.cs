using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DLStat.BlazorClient.Models
{
    public class ResponseMeasures
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public int OperativeId { get; set; }
        public Operative Operative { get; set; }

        public DateTime FillDate { get; set; }

        public byte ReportingWeek { get; set; }
        public byte ReportingMonth { get; set; }
        public int ReportingYear { get; set; }

        public int BySK { get; set; }
        public int ByMVD { get; set; }
        public int ByFSB { get; set; }
        public int Overall { get; set; }

        //DTO:
        //public int Id { get; set; }
        //public Position Position { get; set; }
        //public Operative Operative { get; set; }

        //public DateTime FillDate { get; set; }
        //public byte ReportingWeek { get; set; }
        //public byte ReportingMonth { get; set; }
        //public int ReportingYear { get; set; }

        //public int BySK { get; set; }
        //public int ByMVD { get; set; }
        //public int ByFSB { get; set; }
        //public int Overall { get; set; }
    }
}
