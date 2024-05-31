using AutoMapper;
using Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestSuiza.DTO;
using TestSuiza.Models;
using TestSuiza.Requests;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestSuiza.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IMediator _mediator;
        private IMapper _mapper;

        public ValuesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            await _mediator.Send(new GetCitas());
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult<bool>> Post([FromBody] CitaInput citaDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            var createCita = _mapper.Map<CreateCita>(citaDto);
            bool response = await _mediator.Send(createCita);

            if(!response)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            return Ok(response);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, [FromBody] CitaInput citaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            citaDto.id = id;
            var updateCita = _mapper.Map<UpdateCita>(citaDto);

            bool response = await _mediator.Send(updateCita);

            if (!response)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }


            return Ok(response);

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            return Ok();
        }
    }
}
