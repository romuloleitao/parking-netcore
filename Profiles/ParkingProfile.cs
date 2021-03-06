using AutoMapper;
using Parking.Dtos;
using Parking.Models;

namespace Parking.Profiles
{
    public class ParkingProfile : Profile
    {
        public ParkingProfile()
        {
            //Source => Target
            CreateMap<Car, CarReadDto>();
            CreateMap<CarCreateDto, Car>();
            CreateMap<CarUpdateDto, Car>();
            CreateMap<Car, CarUpdateDto>();
        }
    }
}