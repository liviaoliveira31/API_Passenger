using API_Passenger.Models;
using API_Passenger.Utils;
using MongoDB.Driver;
using System.Collections.Generic;

namespace API_Passenger.Services
{
    public class DeletedPassengerServices
    {

        private readonly IMongoCollection<DeletedPassenger> _deletedPassenger;

        public DeletedPassengerServices(IDatabaseSettings settings)
        {
            var passenger = new MongoClient(settings.ConnectionString);
            var database = passenger.GetDatabase(settings.DatabaseName);
            _deletedPassenger = database.GetCollection<DeletedPassenger>(settings.DeletedPassengerCollectionName);
        }

        //public DeletedPassenger Create(DeletedPassenger)
    }
}
