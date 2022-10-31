using Source.Models;
using Source.Repository.Abstracts;
using Source.Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Repository.Concrets
{
    public class FakeCarRepository : Icarrepository
    {
        public void Add(Car entity)
       =>FakeDbContext.Cars.Add(entity);

        public Car? Get(Func<Car, bool> predicate)
         => FakeDbContext.Cars
            .FirstOrDefault(predicate);

        public IList<Car> GetList(Func<Car, bool>? predicate = null)
            => (predicate is null) switch
            {
                true => FakeDbContext.Cars,
            false => FakeDbContext.Cars.Where(predicate).ToList(),
            };

        public void Remove(Car entity)
        => FakeDbContext.Cars.Remove(entity);

        public void Update(Car entity)
        {
            var index = FakeDbContext.Cars.IndexOf(entity);
            FakeDbContext.Cars[index]=entity;
        }
    }
}
