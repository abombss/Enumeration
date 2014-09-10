namespace Tests
{
    using System;
    using System.Linq;
    using Shouldly;

    public class SortTests
    {
        public void Enumerations_should_sort_by_Value_by_default()
        {
            var states = new [] { State.Stopping, State.Off, State.Starting, State.Busy, State.Waiting };

            Array.Sort(states);

            states.ElementAt(0).ShouldBe(State.Off);
            states.ElementAt(1).ShouldBe(State.Starting);
            states.ElementAt(2).ShouldBe(State.Waiting);
            states.ElementAt(3).ShouldBe(State.Busy);
            states.ElementAt(4).ShouldBe(State.Stopping);
        }
    }
}
