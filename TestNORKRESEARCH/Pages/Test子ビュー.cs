using Bunit;
using Microsoft.Extensions.DependencyInjection;
using NORKRESEARCH.Pages;
using NORKRESEARCH.Financial;

namespace TestNORKRESEARCH
{
	[Collection("NORKRESEARCH")]
	public class Test子ビュー
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbAccordionModule),
				typeof(IgbExpansionPanelModule),
				typeof(IgbCardModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule),
				typeof(IgbStepperModule),
				typeof(IgbTabsModule),
				typeof(IgbNavbarModule),
				typeof(IgbNavDrawerModule),
				typeof(IgbButtonGroupModule),
				typeof(IgbToggleButtonModule),
				typeof(IgbCheckboxModule),
				typeof(IgbComboModule),
				typeof(IgbDatePickerModule),
				typeof(IgbAvatarModule),
				typeof(IgbInputModule),
				typeof(IgbTextareaModule),
				typeof(IgbRadioGroupModule),
				typeof(IgbRadioModule),
				typeof(IgbRatingModule),
				typeof(IgbSwitchModule),
				typeof(IgbSelectModule),
				typeof(IgbSliderModule));
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			var componentUnderTest = ctx.RenderComponent<子ビュー>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
