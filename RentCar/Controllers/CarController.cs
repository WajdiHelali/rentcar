using Domain.Entities;
using Domain.ObjectValues;
using Microsoft.AspNetCore.Mvc;
using RentCar.DTOs;
using RentCar.Services.Cars;


namespace RentCar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarServices _carService;

        public CarController(ICarServices carService)
        {
            _carService = carService;
        }

        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<AddCarResponse>> AddNewCar([FromBody] AddNewCarRequest request)
        {
            var newCar = new Car()
            {
                Label = request.Label,
                Model = new CarModel(request.Model),
                PricePerDay = request.PricePerDay
            };

            await _carService.AddNewCar(newCar);
            return Ok(newCar);
        }
    }
}
