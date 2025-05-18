using AnnalynInfiltration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeZone.UnitTests
{
    [TestFixture]
    public class AnnalynInfiltrationTests
    {
        [Test]
        public void CanFastAttack_KnightIsAwake_ReturnFalse()
        {
            bool knightIsAwake = true;

            var result = QuestLogic.CanFastAttack(knightIsAwake);

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void CanFastAttack_KnightIsSleeping_ReturnTrue()
        {
            bool knightIsAwake = false;

            var result = QuestLogic.CanFastAttack(knightIsAwake);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void CanSpy_AtLeastOnePersonIsAwake_ReturnTrue()
        {
            bool knightIsAwake = true;
            bool archerIsAwake = false;
            bool prisonerIsAwake = false;

            var result = QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void CanSpy_AllAreSleeping_ReturnFalse()
        {
            bool knightIsAwake = false;
            bool archerIsAwake = false;
            bool prisonerIsAwake = false;

            var result = QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake);

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void CanSignalPrisoner_ArcherIsSleepingPrisonerIsAwake_ReturnTrue()
        {
            bool archerIsAwake = false;
            bool prisonerIsAwake = true;

            var result = QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void CanSignalPrisoner_ArcherIsAwakePrisonerIsSleeping_ReturnFalse()
        {
            bool archerIsAwake = true;
            bool prisonerIsAwake = false;

            var result = QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake);

            Assert.That(result, Is.EqualTo(false));
        }


        [Test]
        public void CanSignalPrisoner_ArcherIsSleepingPrisonerIsSleeping_ReturnFalse()
        {
            bool archerIsAwake = false;
            bool prisonerIsAwake = false;

            var result = QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake);

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void CanFreePrisoner_DogIsPresentArcherIsSleepingKnightIsAwakePrisonerIsAwake_ReturnTrue()
        {
            bool knightIsAwake = true;
            bool archerIsAwake = false;
            bool prisonerIsAwake = true;
            bool petDogIsPresent = true;

            var result = QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void CanFreePrisoner_DogIsNotPresentArcherIsSleepingKnightIsSleepingPrisonerIsAwake_ReturnTrue()
        {
            bool knightIsAwake = false;
            bool archerIsAwake = false;
            bool prisonerIsAwake = true;
            bool petDogIsPresent = false;

            var result = QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void CanFreePrisoner_DogIsNotPresentArcherIsSleepingKnightIsSleepingPrisonerIsSleeping_ReturnFalse()
        {
            bool knightIsAwake = false;
            bool archerIsAwake = false;
            bool prisonerIsAwake = false;
            bool petDogIsPresent = false;

            var result = QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent);

            Assert.That(result, Is.EqualTo(false));
        }
    }
}
