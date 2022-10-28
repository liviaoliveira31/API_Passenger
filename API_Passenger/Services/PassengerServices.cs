using API_Passenger.Models;
using API_Passenger.Utils;
using MongoDB.Driver;
using System.Collections.Generic;

namespace API_Passenger.Services
{
    public class PassengerServices
    {

        private readonly IMongoCollection<Passenger> _passenger;

        public PassengerServices(IDatabaseSettings settings )
        {
            var passenger = new MongoClient(settings.ConnectionString);
            var database = passenger.GetDatabase(settings.DatabaseName);
            _passenger = database.GetCollection<Passenger>(settings.PassengerCollectionName);
        }

        public Passenger Create (Passenger passenger)
        {

            _passenger.InsertOne(passenger);
            return passenger;

        }

        public List<Passenger> Get() => _passenger.Find<Passenger>(passenger => true).ToList();

        public Passenger Get(string cpf) =>_passenger.Find<Passenger>(passenger => passenger.CPF == cpf).FirstOrDefault();  
    }
}
