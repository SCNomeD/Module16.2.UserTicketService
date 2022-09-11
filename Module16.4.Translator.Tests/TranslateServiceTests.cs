using Xunit;

namespace Module16._4.Translator.Tests
{
    public class TranslateServiceTests
    {
        [Fact]
        public void GetTranslationMustBeReturnCorrectValue()
        {
            var translateService = new TranslateService();
            translateService.AddTranslation("orange", "апельсин");

            Assert.Equal("апельсин", translateService.GetTranslation("orange"));
        }
    }
}
