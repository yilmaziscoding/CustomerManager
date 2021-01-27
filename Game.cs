using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject
{
    class Game:IEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
