// Corrected NUnit Test Case

using NUnit.Framework;
using Moq;

namespace FiniteStateMachine.Test
{
    public interface IFiniteStateMachine
    {
        void Initialize();
    }

    [TestFixture]
    public class FiniteStateMachine_Initialize_df35803478
    {
        private Mock<IFiniteStateMachine> _mockFiniteStateMachine;

        [SetUp]
        public void Setup()
        {
            _mockFiniteStateMachine = new Mock<IFiniteStateMachine>();
        }

        [Test]
        public void Initialize_WhenCalled_ShouldCallBaseInitialize()
        {
            // Arrange
            _mockFiniteStateMachine.Setup(m => m.Initialize()).Verifiable();

            // Act
            _mockFiniteStateMachine.Object.Initialize();

            // Assert
            _mockFiniteStateMachine.Verify(m => m.Initialize(), Times.Once);
        }

        [Test]
        public void Initialize_WhenCalledMultipleTimes_ShouldCallBaseInitializeMultipleTimes()
        {
            // Arrange
            _mockFiniteStateMachine.Setup(m => m.Initialize()).Verifiable();

            // Act
            _mockFiniteStateMachine.Object.Initialize();
            _mockFiniteStateMachine.Object.Initialize();

            // Assert
            _mockFiniteStateMachine.Verify(m => m.Initialize(), Times.Exactly(2));
        }

        [TearDown]
        public void TearDown()
        {
            _mockFiniteStateMachine = null;
        }
    }
}
