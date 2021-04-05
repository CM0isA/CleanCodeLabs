using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab01
{
    public class CarManager
    {
        private readonly List<Car> _carsDb = new List<Car>(new[]
        {
            new Car("1", "Golf III", "Volkswagen"),
            new Car("2", "Multipla", "Fiat"),
            new Car("3", "Megane", "Renault")
        });


        public Car GetCarFromDb(string carId)
        {
            foreach (var car in _carsDb)
            {
                if (car.Id.Equals(carId))
                {
                    return car;
                }
            }

            return null;
        }

        public string GetCarsNames()
        {
            string carNames = "";
            foreach (var car in _carsDb)
            {
                carNames += FormatCarNames(car);
            }
            return carNames.Substring(0, carNames.Length - 2);
        }

        private string FormatCarNames(Car car)
        {
            var sb = new StringBuilder();
            sb.Append(car.Brand);
            sb.Append(" ");
            sb.Append(car.Model);
            sb.Append(", ");
            return sb.ToString();
        }

        public Car GetBestCar()
        {
            Car bestCar = null;
            foreach (var car in _carsDb)
            {
                if (bestCar == null || car.Model.CompareTo(bestCar.Model) > 0)
                {
                    bestCar = car;
                }
            }

            return bestCar;
        }
    }
}