using API_Passenger.Models;
using API_Passenger.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API_Passenger.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {

        private readonly PassengerServices _passengerServices;
        private readonly AddressServices _addressServices;

        public PassengerController(PassengerServices passangerServices, AddressServices addressServices)
        {
            _passengerServices = passangerServices;
            _addressServices = addressServices;
        }


        [HttpGet]
        public ActionResult<List<Passenger>> Get() => _passengerServices.Get();

        [HttpGet("CPF/{cpf}")]

        public ActionResult<Passenger> Get(string cpf)
        {
            var passenger = _passengerServices.Get(cpf);
            if(passenger == null)
                return NotFound();

            return Ok(passenger);
        }

        [HttpPost]
        public ActionResult<Passenger> Create(Passenger passenger, string cep)
        {
          //  Address address = _addressServices.GetAdress(cep);
           // passenger.Address = address;
            _passengerServices.Create(passenger);
            return passenger;
        }

    }
}
