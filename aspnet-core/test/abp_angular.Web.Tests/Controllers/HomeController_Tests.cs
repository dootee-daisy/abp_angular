using System.Threading.Tasks;
using abp_angular.Models.TokenAuth;
using abp_angular.Web.Controllers;
using Shouldly;
using Xunit;

namespace abp_angular.Web.Tests.Controllers
{
    public class HomeController_Tests: abp_angularWebTestBase
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