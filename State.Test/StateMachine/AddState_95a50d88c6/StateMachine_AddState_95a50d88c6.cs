using System;
using NUnit.Framework;
using Moq;

namespace FiniteStateMachine.Test
{
    public interface IStateMachine<T>
    {
        void AddState(IState<T> state);
        bool ContainsState(T stateKey);
    }

    public interface IState<T>
    {
        T StateKey { get; }
    }

    [TestFixture]
    public class StateMachine_AddState_95a50d88c6
    {
        private IStateMachine<int> _stateMachine;
        private IState<int> _state;

        [SetUp]
        public void Setup()
        {
            var mockStateMachine = new Mock<IStateMachine<int>>();
            var mockState = new Mock<IState<int>>();
            mockState.Setup(s => s.StateKey).Returns(1);
            _stateMachine = mockStateMachine.Object;
            _state = mockState.Object;
        }

        [Test]
        public void AddState_StateBelongsToStateMachine_AddsState()
        {
            _stateMachine.AddState(_state);

            Assert.IsTrue(_stateMachine.ContainsState(_state.StateKey));
        }

        [Test]
        public void AddState_StateDoesNotBelongToStateMachine_ThrowsException()
        {
            var otherStateMachine = new Mock<IStateMachine<int>>().Object;
            var otherState = new Mock<IState<int>>();
            otherState.Setup(s => s.StateKey).Returns(2);

            var ex = Assert.Throws<Exception>(() => _stateMachine.AddState(otherState.Object));
            Assert.That(ex.Message, Is.EqualTo("[FiniteStateMachine::AddState()] -> The State can only be added to the State Machine that was used to create it."));
        }
    }
}
