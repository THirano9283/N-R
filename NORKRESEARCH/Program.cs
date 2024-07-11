using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using NORKRESEARCH;
using NORKRESEARCH.Financial;
using NORKRESEARCH.Northwind;
using IgniteUI.Blazor.Controls;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();


builder.Services.AddScoped<IFinancialService, FinancialService>();
builder.Services.AddScoped<INorthwindService, NorthwindService>();
RegisterIgniteUI(builder.Services);

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbGridModule),
        typeof(IgbFinancialChartModule),
        typeof(IgbPieChartModule),
        typeof(IgbAccordionModule),
        typeof(IgbExpansionPanelModule),
        typeof(IgbCardModule),
        typeof(IgbButtonModule),
        typeof(IgbStepperModule),
        typeof(IgbTabsModule),
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
        typeof(IgbSliderModule)
    );
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
