// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;


ServiceFlight serviceFlight= new ServiceFlight();
serviceFlight.Flights = TestData.listFlights;
serviceFlight.GetFlights("destination", "Paris");