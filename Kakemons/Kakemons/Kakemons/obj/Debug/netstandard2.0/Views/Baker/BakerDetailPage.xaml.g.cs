//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("Kakemons.UI.Views.Baker.BakerDetailPage.xaml", "Views/Baker/BakerDetailPage.xaml", typeof(global::Kakemons.UI.Pages.Baker.BakerDetailPage))]

namespace Kakemons.UI.Pages.Baker {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\Baker\\BakerDetailPage.xaml")]
    public partial class BakerDetailPage : global::Kakemons.UI.Views.ContentPageBase<global::Kakemons.Core.ViewModels.Baker.BakerProfileViewModel> {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Kakemons.UI.Controls.ListViews.CakeSmallList CakeList;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(BakerDetailPage));
            CakeList = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Kakemons.UI.Controls.ListViews.CakeSmallList>(this, "CakeList");
        }
    }
}
