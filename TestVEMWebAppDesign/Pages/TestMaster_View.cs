using Bunit;
using Microsoft.Extensions.DependencyInjection;
using VEMWebAppDesign.Pages;

namespace TestVEMWebAppDesign
{
  [Collection("VEMWebAppDesign")]
  public class TestMaster_View
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbAvatarModule),
        typeof(IgbButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbInputModule));
      var componentUnderTest = ctx.RenderComponent<Master_View>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
