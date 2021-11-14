using System;

namespace A4.Task2Interface
{
	interface ICarryPassengers
	{
		public abstract string CarryPassengers();
    }
	class Ship
	{
		public double Displacement { get; }

		public Ship(double displacement)
        {
			Displacement = displacement;
        }

		public override string ToString() => $"A ship that displaces {Displacement} tons of water"; 
	}

	class CruiseShip : Ship, ICarryPassengers
	{
		public int NumPassengers;

		public CruiseShip(double displacement, int numPassengers) : base (displacement)
		{
			NumPassengers = numPassengers;
		}

        public string CarryPassengers()
        {
			return $"{base.ToString()} and is carrying {NumPassengers} passengers on a Caribbean Cruise";
		}

        public override string ToString() => CarryPassengers();
    }

	class BigRig
	{
		public int NumTires;

        public BigRig(int numTires)
        {
            NumTires = numTires;
        }

        public override string ToString() => $"A vehicle with {NumTires} tires"; 
    }

	class TourBus : BigRig, ICarryPassengers
	{
		public int NumPassengers;

		public TourBus(int numTires, int numPassengers) : base(numTires)
		{
			NumPassengers = numPassengers;
		}

        public string CarryPassengers()
        {
			return $"{base.ToString()} and is carrying {NumPassengers} passengers on a cross country tour.";
		}

        public override string ToString() => CarryPassengers();
    }
}
