namespace Tests
{
    using Shouldly;

    public class EqualityTests
    {
        public void Equals_operator_should_return_true_for_same_value()
        {
            var first = Color.Red;
            var second = Color.Red;

            (first == second).ShouldBe(true);
        }

        public void NotEquals_operator_should_return_true_for_different_values()
        {
            var first = Color.Red;
            var second = Color.Blue;

            (first != second).ShouldBe(true);
        }

        public void Equals_operator_should_return_false_for_different_values()
        {
            var first = Color.Blue;
            var second = Color.Red;

            (first == second).ShouldBe(false);
        }

        public void NotEquals_operator_should_return_false_for_same_values()
        {
            var first = Color.Blue;
            var second = Color.Blue;

            (first != second).ShouldBe(false);
        }
    }
}
