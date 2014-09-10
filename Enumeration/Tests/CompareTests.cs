namespace Tests
{
    using Shouldly;

    public class CompareTests
    {
        public void CompareTo_should_use_Value_of_Enumeration()
        {
            var red = Color.Red;
            var blue = Color.Blue;

            red.CompareTo(blue).ShouldBe(red.Value.CompareTo(blue.Value));
        }

        public void CompareTo_on_instance_should_compare_greater_than_null()
        {
            var red = Color.Red;

            red.CompareTo(default(Color)).ShouldBeGreaterThan(0);
        }

        public void CompareTo_should_return_zero_for_same_instance_comparisons()
        {
            var first = Color.Blue;
            var second = Color.Blue;

            first.CompareTo(second).ShouldBe(0);
        }
    }
}