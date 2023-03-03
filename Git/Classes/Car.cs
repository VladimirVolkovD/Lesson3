using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.Classes
{
    internal class Car
    {
        public double fuel;
        string model;
        int year;
        public double maxspeed = 250;
        public double speed;

        public Car(double fuel, string model, int year)
        {
            this.fuel = fuel;
            this.model = model;
            this.year = year;
        }

        public Car() { }


        
        public void IncreaseSpeed()
        {
            if(speed < maxspeed)
            {
                speed += 5;
            }            
        }

        public double IncreaseSpeed(out double currentSpeed)
        {
            currentSpeed = speed;

            if (speed < maxspeed)
            {
                speed += 5;
               
            }
           
            return speed;
        }

        public void IncreaseSpeed(int speed)
        {
            if (speed < maxspeed)
            {
                this.speed += speed;
            }
        }

        public void IncreaseSpeed(ref int speed)
        {
            if (speed < maxspeed)
            {
                this.speed += speed;
            }
        }
    }
}
