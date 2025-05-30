using JedlikToys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeZone.UnitTests
{
    [TestFixture]
    public class JedlikToysTests
    {
        [Test]
        public void Buy_WhenCalled_ReturnInstanceOfRemoteControlCar()
        {
            var car = RemoteControlCar.Buy();

            Assert.That(car, Is.InstanceOf<RemoteControlCar>());
        }

        [Test]
        public void DistanceDisplay_DriveIsCalledOnce_ReturnDrivenDistanceIsEqual20()
        {
            var car = new RemoteControlCar();
            car.Drive();

            var result = car.DistanceDisplay();

            Assert.That(result, Is.EqualTo("Driven 20 meters"));
        }

        [Test]
        public void BatteryDisplay_BatteryIsNotEmpty_ReturnBatteryLevel()
        {
            var car = new RemoteControlCar();
            car.Drive();

            var result = car.BatteryDisplay();

            Assert.That(result, Is.EqualTo("Battery at 99%"));
        }

        [Test]
        public void BatteryDisplay_BatteryIsEmpty_ReturnBatteryIsEmpty()
        {
            var car = new RemoteControlCar();
            
            for (var i = 0; i < 100; i++)
            {
                car.Drive();
            }

            var result = car.BatteryDisplay();

            Assert.That(result, Is.EqualTo("Battery empty"));
        }
    }
}
