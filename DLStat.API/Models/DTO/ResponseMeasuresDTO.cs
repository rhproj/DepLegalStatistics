using System.ComponentModel.DataAnnotations.Schema;

namespace DLStat.API.Models.DTO
{
    public class ResponseMeasuresDTO
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        public int OperativeId { get; set; }

        public DateTime FillDate { get; set; }
        public byte ReportingWeek { get; set; }
        public byte ReportingMonth { get; set; }
        public int ReportingYear { get; set; }

        public int BySK { get; set; }
        public int ByMVD { get; set; }
        public int ByFSB { get; set; }
        public int Overall { get; set; }
    }
}
