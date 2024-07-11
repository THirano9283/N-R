using Bunit;
using Microsoft.Extensions.DependencyInjection;
using NORKRESEARCH.Pages;
using NORKRESEARCH.Northwind;
using NORKRESEARCH.Financial;

namespace TestNORKRESEARCH
{
	[Collection("NORKRESEARCH")]
	public class TestView_3
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbGridModule),
				typeof(IgbCategoryChartModule),
				typeof(IgbFinancialChartModule),
				typeof(IgbPieChartModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			var componentUnderTest = ctx.RenderComponent<View_3>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
