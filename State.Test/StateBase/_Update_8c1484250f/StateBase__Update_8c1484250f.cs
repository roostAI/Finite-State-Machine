using NUnit.Framework;
using Moq;

namespace FiniteStateMachine.Test 
{
    public class StateBase__Update_8c1484250f
    {
        private Mock<IStateBase> _mockStateBase;
        private float _dt;

        [SetUp]
        public void Setup()
        {
            _mockStateBase = new Mock<IStateBase>();
            _dt = 0.5f; // TODO: Change this value as per your requirement
        }

        [Test]
        public void _Update_WhenCalled_CallsUpdateMethod()
        {
            // Arrange
            _mockStateBase.Setup(s => s.Update(_dt));

            // Act
            _mockStateBase.Object.Update(_dt);

            // Assert
            _mockStateBase.Verify(s => s.Update(_dt), Times.Once);
        }

        [Test]
        public void _Update_WithZeroDt_DoesNotCallUpdateMethod()
        {
            // Arrange
            float zeroDt = 0f;
            _mockStateBase.Setup(s => s.Update(zeroDt));

            // Act
            _mockStateBase.Object.Update(zeroDt);

            // Assert
            _mockStateBase.Verify(s => s.Update(zeroDt), Times.Never);
        }
    }

    public interface IStateBase
    {
        void Update(float dt);
    }
}
