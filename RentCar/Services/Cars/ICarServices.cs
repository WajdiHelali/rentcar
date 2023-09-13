using Domain.Entities;

namespace RentCar.Services.Cars
{
    public interface ICarServices
    {
        public Task<Car> AddNewCar(Car car);

        public Task<IEnumerable<Car>> GetAllCars();

        public Task<IEnumerable<Car>> GetCarsByLabel(Car car);
        public Task<IEnumerable<Car>> GetCarsByModel(Car car);
        public Task<IEnumerable<Car>> GetCarsByAvailability(Car car);
        public Task<Car> GetCarsId(Guid id);

        public void RemoveCar(Guid id);
        public Task UpdateCar(Car car);
    }
}
