using NUnit.Framework;
using Shouldly;

namespace LaunchyThingTests
{
    public class ItShouldHaveTests
    {
        [Test]
        public void BecauseTestsAreGrand()
        {
            true.ShouldBe(true);
        }
    }
}