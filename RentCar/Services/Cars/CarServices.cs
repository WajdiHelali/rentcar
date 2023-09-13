using DataAccess.ApplicationContext;
using Domain.Entities;

namespace RentCar.Services.Cars
{

   

    public class CarServices : ICarServices
    {
        private readonly ApplicationDbContext dbContext;
        public CarServices(ApplicationDbContext _context)
        {
            dbContext= _context;
        }

        public async Task<Car> AddNewCar(Car car)
        {
            dbContext.Cars.Add(car);
            await dbContext.SaveChangesAsync();
            return car;
        }

        public Task<IEnumerable<Car>> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Car>> GetCarsByAvailability(Car car)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Car>> GetCarsByLabel(Car car)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Car>> GetCarsByModel(Car car)
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetCarsId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void RemoveCar(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
