using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoShip
{
    class Ship
    {
        const int CYCLE_WEIGHT = 3;
        const int CAR_WEIGHT = 5;
        const int TRUCK_WEIGHT = 11;
        const int TRAIN_WEIGHT = 17;

        const int MAX_WEIGHT = 10;

        public int Capacity { get; set; }
        public int CycleCount { get; set; }
        public int CarCount { get; set; }
        public int TruckCount { get; set; }
        public int TrainCarCount { get; set; }

        Random random = new Random();

        public int getShipLoad()
        {
            // calculate total weight of cargo ship
            return CycleCount * CYCLE_WEIGHT + CarCount * CAR_WEIGHT + TruckCount * TRUCK_WEIGHT + TrainCarCount * TRAIN_WEIGHT;
        }

        //constructor
        public Ship()
        {
            CycleCount = 0;
            CarCount = 0;
            TruckCount = 0;
            TrainCarCount = 0;

            //create a random sized ship
            Capacity = random.Next(MAX_WEIGHT) * CYCLE_WEIGHT + random.Next(MAX_WEIGHT) + CAR_WEIGHT + random.Next(MAX_WEIGHT) + TRUCK_WEIGHT + random.Next(MAX_WEIGHT) + TRAIN_WEIGHT;
        }

        public int overUnder()
        {
            //return a value of how loaded the ship is
            return Capacity - getShipLoad();
        }

        public override string ToString()
        {
            return "Capacity = " + Capacity + ", CurrentLoad = " + getShipLoad(); 
        }
    }
}
