using Source.Models;
using Source.Repository.Abstracts;
using Source.Repository.Concrets;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.ViewModels
{
    public class MainviewModel
    {
        private readonly Icarrepository _carRepository;
        public ObservableCollection<Car> Cars { get; set; }


        public MainviewModel(Icarrepository carRepository)
        {
            _carRepository = carRepository;
            Cars = new (_carRepository.GetList()?? new List<Car>());
        }
    }
}


//17 40