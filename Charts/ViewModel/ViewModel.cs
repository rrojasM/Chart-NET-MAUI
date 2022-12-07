using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charts.ViewModel
{
    class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }
        public ObservableCollection<Model> Data1 { get; set; }

        public ViewModel() 
        {
            Data = new ObservableCollection<Model>()
            {
                new Model("Lu",39),
                new Model("Ma",20),
                new Model("Mi",61),
                new Model("Ju",65),
                new Model("Vi",45),
                new Model("Sa",85),
                new Model("Do",45),

            };

            Data1 = new ObservableCollection<Model>()
            {
                new Model("Lu",45),
                new Model("Ma",30),
                new Model("Mi",50),
                new Model("Ju",60),
                new Model("Vi",60),
                new Model("Sa",70),
                new Model("Do",30),

            };
        }

    }

    public class Model
    {
        public string Country { get; set; }
        public double Counts { get; set; }

        public Model(string name, double count)
        {
            Country = name;
            Counts = count;
        }
    }
}
