using Source.Models;
using System.Collections.Generic;

namespace Source.Repository.Contexts;

public class FakeDbContext
{
    public static List<Car> Cars { get; set; } = new()
    {
        new Car {Id=1,Model="Kia",Make="Cerato",Year=2013 },
        new Car { Id =2, Model = "Hyundai", Make = "Cerato", Year = 2013 },
        new Car { Id = 3, Model = "Bmw", Make = "Cerato", Year = 2013 },
        
    };


    public static List<Car> GetCars()
    {
       var list=new List<Car>();
        return list;
    }

}
