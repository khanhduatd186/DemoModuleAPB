using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace DemoModule.Blazor.Menus;

public class DemoModuleMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        var menuItem = context.Menu.AddItem(new ApplicationMenuItem(DemoModuleMenus.Prefix, displayName: "DemoModule", "/DemoModule", icon: "fa fa-globe"));

        menuItem.AddItem(new(
           name: DemoModuleMenus.Customers,
           displayName: "CM Customers",
           url: "~/sample-cm/customers",
           order: 1));

        menuItem.AddItem(new(
            name: DemoModuleMenus.Countries,
            displayName: "Countries",
            url: "~/sample-cm/countries",
            order: 2));

        return Task.CompletedTask;
    }
}
