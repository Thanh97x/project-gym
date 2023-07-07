using System.Threading.Tasks;
using Demotht.Models.TokenAuth;
using Demotht.Web.Controllers;
using Shouldly;
using Xunit;

namespace Demotht.Web.Tests.Controllers
{
    public class HomeController_Tests: DemothtWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}