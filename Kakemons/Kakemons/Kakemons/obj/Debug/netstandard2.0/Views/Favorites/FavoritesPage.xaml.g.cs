//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("Kakemons.UI.Views.Favorites.FavoritesPage.xaml", "Views/Favorites/FavoritesPage.xaml", typeof(global::Kakemons.UI.Pages.Favorites.FavoritesPage))]

namespace Kakemons.UI.Pages.Favorites {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\Favorites\\FavoritesPage.xaml")]
    public partial class FavoritesPage : global::MvvmCross.Forms.Views.MvxContentPage<global::Kakemons.Core.ViewModels.Favorites.FavoritesViewModel> {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Kakemons.UI.Controls.ListViews.CakeList CakeList;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(FavoritesPage));
            CakeList = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Kakemons.UI.Controls.ListViews.CakeList>(this, "CakeList");
        }
    }
}