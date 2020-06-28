using System;
using Xunit;
using Xunit.Abstractions;

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

        private readonly ITestOutputHelper output;

        public JsonExtensionMethods(ITestOutputHelper output)
        {
            this.output = output;
        }
        [Fact]
        public void FromJsonToTypeMethodDeserializesCarFromValidJson()
        {
            string text = @"{""Wheels"": 4, ""Doors"": 2}";
            
            var car = text.FromJsonTo<Car>();

            Assert.IsType<Car>(car);
            Assert.Equal(2, car.Doors);
            Assert.Equal(4, car.Wheels);
        }

        [Fact]
        public void ToJsonMethodSerializesCarToValidJson()
        {
            Car car = new Car();

            string json = car.ToJson();

            var thing = json.FromJsonTo<Car>();

            Assert.Equal(@"{""Wheels"":4,""Doors"":2}", json);
            Assert.IsType<Car>(thing);
            Assert.Equal(2, thing.Doors);
            Assert.Equal(4, thing.Wheels);
        }

        [Fact]
        public void MethodsCanEmitExamplesForExamination()
        {
            var now = DateTime.Now;
            output.WriteLine($"{now.ToJsonAs<DateTime>()}\n");

            var car = new Car();
            output.WriteLine($"{car.ToJson()}\n");
        }
    }
}
