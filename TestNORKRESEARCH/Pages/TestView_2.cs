using Bunit;
using Microsoft.Extensions.DependencyInjection;
using NORKRESEARCH.Pages;
using NORKRESEARCH.Northwind;

namespace TestNORKRESEARCH
{
	[Collection("NORKRESEARCH")]
	public class TestView_2
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbGridModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<View_2>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
