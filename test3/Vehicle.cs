using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class Vehicle
    {
        protected string make;
        protected string model;
        protected string year;

        public Vehicle()
        {
        }
        public Vehicle(string make, string model, string year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        //Property
        public string Make
        {
            set { make = value; }
            get { return make; }
        }
        public string Model
        {
            set { model = value; }
            get { return model; }
        }
        public string Year
        {
            set { year = value; }
            get { return year; }
        }

        //methods
        public void Accelerate()
        {
        }
        public void Decelerate()
        {
        }
        public void Drive()
        {
        }
        public void Start()
        {
        }
        public void Stop()
        {
        }
    }
}