﻿namespace API_Passenger.Utils
{
    public interface IDatabaseSettings
    {

        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
        string PassengerCollectionName { get; set; }
        string AdressCollectionName { get; set; }
        string DeletedPassengerCollectionName { get; set; }
    }
}
