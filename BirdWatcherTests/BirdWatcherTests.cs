using BirdWatcher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeZone.UnitTests
{
    [TestFixture]
    public class BirdWatcherTests
    {
        [Test]
        public void LastWeek_WhenCalled_DisplayLastWeekCount()
        {
            // Arrange
            int[] lastWeekCount = { 2, 5, 0, 7, 4, 1 };
            BirdCount birdCount = new BirdCount(lastWeekCount);

            // Act
            var result = birdCount.LastWeek(lastWeekCount);    

            // Assert
            Assert.That(result, Is.EquivalentTo(lastWeekCount));
        }

        [Test]
        public void Today_WhenCalled_DisplayTheLastCount()
        {
            // Arrange
            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            BirdCount birdCount = new BirdCount(birdsPerDay);

            // Act
            var result = birdCount.Today();

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void IncrementTodaysCount_WhanCalled_IncrementTodaysCount()
        {
            // Arrange
            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            BirdCount birdCount = new BirdCount(birdsPerDay);

            // Act
            var result = birdCount.IncrementTodaysCount();

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void HasDayWithoutBirds_ZeroCount_ReturnTrue()
        {
            // Arrange
            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            BirdCount birdCount = new BirdCount(birdsPerDay);

            // Act
            var result = birdCount.HasDayWithoutBirds();

            // Assert
            Assert.That(result, Is.True);

        }


        [Test]
        public void HasDayWithoutBirds_NoZeroCount_ReturnFalse()
        {
            // Arrange
            int[] birdsPerDay = { 2, 5, 1, 7, 4, 1 };
            BirdCount birdCount = new BirdCount(birdsPerDay);

            // Act
            var result = birdCount.HasDayWithoutBirds();

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void CountForFirstDays_CountForFourDays_ReturnBirdCount()
        {
            // Arrange
            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            BirdCount birdCount = new BirdCount(birdsPerDay);

            // Act
            var result = birdCount.CountForFirstDays(4);

            // Assert
            Assert.That(result, Is.EqualTo(14));
        }

        [Test]
        public void BusyDays_BirdCountGreaterOrEqualFive_ReturnNumberOfDays()
        {
            // Arrange
            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            BirdCount birdCount = new BirdCount(birdsPerDay);

            // Act
            var result = birdCount.BusyDays();

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }
    }
}
