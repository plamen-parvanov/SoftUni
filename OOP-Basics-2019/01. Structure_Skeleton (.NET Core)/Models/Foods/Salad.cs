﻿namespace SoftUniRestaurant.Models.Foods
{
    public class Salad : Food
    {
        private const int InitialServingSize = 300;

        public Salad(string name, decimal price) 
            : base(name, InitialServingSize, price)
        {
        }

        public override string ToString()
        {
            return string.Format(base.ToString(), this.Name, this.ServingSize, this.Price);
        }
    }
}
