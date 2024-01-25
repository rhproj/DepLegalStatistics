using AutoMapper;
using DLStat.API.Models.DTO;

namespace DLStat.API.Models.Mappers
{
    public class ResponseMeasuresProfile : Profile
    {
        public ResponseMeasuresProfile()
        {
            CreateMap<ResponseMeasures, ResponseMeasuresDTO>().ReverseMap();
        }
    }
}
