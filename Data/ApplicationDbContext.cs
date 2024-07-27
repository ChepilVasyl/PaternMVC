using System.Security.Claims;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.V5.Pages.Account.Manage.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace MyFirstWebServer.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<PersonalDataModel>? MyModel { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Виключення типів, які не повинні бути сутностями
        modelBuilder.Ignore<Endpoint>();
        modelBuilder.Ignore<FilterDescriptor>();
        modelBuilder.Ignore<BindingSource>();
        modelBuilder.Ignore<ModelExplorer>();
        modelBuilder.Ignore<ViewDataDictionary>();
        modelBuilder.Ignore<Func<ActionContext, bool>>();
        modelBuilder.Ignore<Func<IRazorPage>>();
        modelBuilder.Ignore<Claim>();

        base.OnModelCreating(modelBuilder);
    }
}