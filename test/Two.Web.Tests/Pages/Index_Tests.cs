using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Two.Pages
{
    public class Index_Tests : TwoWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
