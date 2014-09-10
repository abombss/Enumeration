namespace Tests
{
    using System;
    using Shouldly;

    public class ParseTests
    {
        private const string BadDisplayName = "Blarg";
        private const int BadValue = -1337;

        public void Parse_with_good_DisplayName_should_return_expected_Enumeration()
        {
            Color.Parse("Red").ShouldBe(Color.Red);
        }

        public void FromValue_with_good_Value_should_return_expected_Enumeration()
        {
            Color.FromValue(2).ShouldBe(Color.Blue);
        }

        public void Parse_with_bad_DisplayName_should_throw_ArgumentException()
        {
            var ex = Should.Throw<ArgumentException>(() => Color.Parse(BadDisplayName));
            ex.Message.ShouldContain(BadDisplayName);
            ex.Message.ShouldContain(typeof(Color).FullName);
        }

        public void FromValue_with_bad_Value_should_throw_ArgumentException()
        {
            var ex = Should.Throw<ArgumentException>(() => Color.FromValue(BadValue));
            ex.Message.ShouldContain(Convert.ToString(BadValue));
            ex.Message.ShouldContain(typeof(Color).FullName);
        }

        public void TryParse_with_good_DisplayName_should_return_expected_Enumeration()
        {
            Color color;
            Color.TryParse("Blue", out color).ShouldBe(true);
            color.ShouldBe(Color.Blue);
        }

        public void TryParse_with_good_Value_should_return_expected_Enumeration()
        {
            Color color;
            Color.TryParse(1, out color).ShouldBe(true);
            color.ShouldBe(Color.Red);
        }

        public void TryParse_with_bad_DisplayName_should_not_throw_ArgumentException()
        {
            var parseResult = false;
            Color color = null;
            Should.NotThrow(() => { parseResult = Color.TryParse(BadDisplayName, out color); });
            parseResult.ShouldBe(false);
            color.ShouldBe(null);
        }

        public void TryParse_with_bad_Value_should_not_throw_ArgumentException()
        {
            var parseResult = false;
            Color color = null;
            Should.NotThrow(() => { parseResult = Color.TryParse(BadValue, out color); });
            parseResult.ShouldBe(false);
            color.ShouldBe(null);
        }
    }
}