//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("Kakemons.UI.Views.Baker.BakerChatPage.xaml", "Views/Baker/BakerChatPage.xaml", typeof(global::Kakemons.UI.Pages.Baker.BakerChatPage))]

namespace Kakemons.UI.Pages.Baker {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\Baker\\BakerChatPage.xaml")]
    public partial class BakerChatPage : global::Kakemons.UI.Views.ContentPageBase<global::Kakemons.Core.ViewModels.Baker.BakerChatViewModel> {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.ListView ChatListView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Kakemons.UI.Controls.Entries.BorderlessEntry MessageEntry;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Button SendMessageBtn;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(BakerChatPage));
            ChatListView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ListView>(this, "ChatListView");
            MessageEntry = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Kakemons.UI.Controls.Entries.BorderlessEntry>(this, "MessageEntry");
            SendMessageBtn = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Button>(this, "SendMessageBtn");
        }
    }
}
