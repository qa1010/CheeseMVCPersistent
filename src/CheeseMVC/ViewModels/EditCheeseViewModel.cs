using CheeseMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class EditCheeseViewModel : AddCheeseViewModel
    {
        public int ID { get; set; }

        public EditCheeseViewModel() { }

        public EditCheeseViewModel(int id, IEnumerable<CheeseCategory> categories) : base(categories)
        {
            ID = id;
        }
    }
}
