using System;
using NUnit.Framework;
using FiniteStateMachine;

namespace FiniteStateMachine.Test
{
    public class FiniteStateMachine_Update_97a3df38bc
    {
        private FiniteStateMachine finiteStateMachine;

        [SetUp]
        public void Setup()
        {
            finiteStateMachine = new FiniteStateMachine();
        }

        [Test]
        public void Update_WithPositiveDeltaTime_UpdatesNormally()
        {
            // Arrange
            float deltaTime = 0.5f;

            // Act
            finiteStateMachine.Update(deltaTime);

            // Assert
            // TODO: Add assertions based on the expected outcome of the method
            Assert.Pass(); // This is a placeholder, replace with appropriate assertion
        }

        [Test]
        public void Update_WithNegativeDeltaTime_ThrowsException()
        {
            // Arrange
            float deltaTime = -0.5f;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => finiteStateMachine.Update(deltaTime));
        }

        [TearDown]
        public void Teardown()
        {
            // TODO: Clean up any resources used during testing here
            finiteStateMachine = null;
        }
    }
}
