using Xunit;

namespace Fetchgoods.Text.Json.Extensions.Tests
{
    public class JsonExtensionMethods
    {
        class Car
        {
            public int Wheels { get; set; }
            public int Doors { get; set; }

            public Car()
            {
                this.Wheels = 4;
                this.Doors = 2;
            }

            public Car(int wheels = 4, int doors = 2)
            {
                this.Wheels = wheels;
                this.Doors = doors;
            }
        }

        [Fact]
        public void FromJsonMethodDeserializesCarFromValidJson()
        {
            string json = @"{""Wheels"": 4, ""Doors"": 2}";
            
            var car = json.FromJson<Car>();

            Assert.IsType<Car>(car);
            Assert.Equal(2, car.Doors);
            Assert.Equal(4, car.Wheels);
        }

        [Fact]
        public void ToJsonMethodSerializesCarToValidJson()
        {
            Car car = new Car();

            string json = car.ToJson<Car>();

            var thing = json.FromJson<Car>();

            Assert.Equal(@"{""Wheels"":4,""Doors"":2}", json);
            Assert.IsType<Car>(thing);
            Assert.Equal(2, thing.Doors);
            Assert.Equal(4, thing.Wheels);
        }
    }
}
