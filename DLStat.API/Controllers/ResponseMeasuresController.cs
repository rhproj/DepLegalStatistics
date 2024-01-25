using AutoMapper;
using DLStat.API.Data;
using DLStat.API.Models;
using DLStat.API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DLStat.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponseMeasuresController : ControllerBase
    {
        private readonly AppDbConrtext _dbContext;
        private readonly IMapper _mapper;

        public ResponseMeasuresController(AppDbConrtext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;

        }

        [HttpGet("getAllPositions")] //month + year will allow to set auto summ
        public async Task<IActionResult> GetAllPositions(int userId, byte month, byte week, int year) 
        {
            var responseMeasures = await _dbContext.ResponseMeasures.Where(r => 
                   (r.OperativeId == userId)
                && (r.ReportingYear == year)
                && (r.ReportingMonth == month)
                && (r.ReportingWeek == week)).ToListAsync();

            var result = _mapper.Map<IEnumerable<ResponseMeasuresDTO>>(responseMeasures); //add another DTO for Presenting RM with Position names

            return Ok(result);
        }

        [HttpPost("postPosition")]
        public async Task<IActionResult> PostPosition([FromBody] ResponseMeasuresDTO responseMeasuresDTO)
        {
            var responseMeasures = _mapper.Map<ResponseMeasures>(responseMeasuresDTO);

            await _dbContext.ResponseMeasures.AddAsync(responseMeasures);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
