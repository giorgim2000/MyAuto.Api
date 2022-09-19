using Application.Abstraction;
using Application.Commands.CarAdCommands;
using Application.Models;
using Application.Queries;
using Domain.Entities;
using Infrastructure.DataContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyAuto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarAdsController : ControllerBase
    {
        private readonly ICarAdService _service;
        private readonly IMediator _mediator;
        public CarAdsController(ICarAdService service, IMediator mediator)
        {
            _service = service;
            _mediator = mediator;
        }
        
        // GET: api/<CarAdsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetAllCarAds());
        }

        // GET api/<CarAdsController>/carAdId
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var ad = await _service.GetCarAdById(id);
            if (ad != null)
                return Ok(ad);
            else
                return BadRequest();
        }

        // GET api/<CarAdsController>/myCarAds
        [HttpGet("/myCarAds")]
        public async Task<IActionResult> GetByUserId(int userId)
        {
            var userCarAds = await _service.GetCarAdByUserId(userId);

            if (userCarAds.Count != 0)
                return Ok(userCarAds);
            else
                return BadRequest();
        }

        // GET api/<CarAdsController>/5
        [HttpGet(nameof(GetByUserName))]
        public async Task<IActionResult> GetByUserName(string userName)
        {
            var userCarAds = await _service.GetCarAdByUserName(userName);

            if (userCarAds.Count != 0)
                return Ok(userCarAds);
            else
                return BadRequest();
        }

        // GET api/<CarAdsController>/5
        [HttpGet(nameof(FilterCarAds))]
        public async Task<IActionResult> FilterCarAds([FromQuery]FilterCarAdQuery input)
        {
            var carAdList = await _mediator.Send(input); 

            if (carAdList.Count != 0)
                return Ok(carAdList);
            else
                return BadRequest();
        }
        // POST api/<CarAdsController>
        [HttpPost]
        public async Task<IActionResult> Post(CreateCarAdCommand input)
        {
            return Ok(await _mediator.Send(input));
        }

        // PUT api/<CarAdsController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromForm]UpdateCarAdCommand input)
        {
            return Ok(await _mediator.Send(input));
        }

        // DELETE api/<CarAdsController>/5
        [HttpDelete("{carAdId}")]
        public async Task<IActionResult> Delete([FromRoute]int carAdId)
        {
            var carAdDeleted = await _mediator.Send(new RemoveCarAdCommand() { CarAdId = carAdId });
            if (!carAdDeleted)
                return BadRequest();
            else
                return Ok();
        }
    }
}
