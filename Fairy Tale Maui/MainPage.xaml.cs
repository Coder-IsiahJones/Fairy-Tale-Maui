using Fairy_Tale_Maui.Models;
using Microsoft.Maui.Handlers;
using System.Collections.ObjectModel;

namespace Fairy_Tale_Maui
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<FairyTale> FairyTales { get; set; } = [];
        public ObservableCollection<FairyTale> FairyTalesCopy { get; set; } = [];

        public MainPage()
        {
            InitializeComponent();
            ModifySearchBar();
            InitializeFairyTales();
            BindingContext = this;
        }

        private void InitializeFairyTales()
        {
            FairyTales =
            [
                new FairyTale
                {
                    Name = "The Rabbit",
                    ReadTime = new TimeSpan(0, 3, 0),
                    IsSaved = false,
                    Image = "bunny.png"
                },

                new FairyTale
                {
                    Name = "Adventure of Brave",
                    ReadTime = new TimeSpan(0, 6, 0),
                    IsSaved = false,
                    Image = "bunny5.jpeg"
                },

                new FairyTale
                {
                    Name = "Rudy the Brave Rabbit ",
                    ReadTime = new TimeSpan(0, 9, 0),
                    IsSaved = false,
                    Image = "bunny2.jpeg"
                },

                new FairyTale
                {
                    Name = "Misadventures Rumble",
                    ReadTime = new TimeSpan(0, 12, 0),
                    IsSaved = false,
                    Image = "bunny3.jpeg"
                },

                new FairyTale
                {
                    Name = "Rabbit's Great Carrot",
                    ReadTime = new TimeSpan(0, 16, 0),
                    IsSaved = false,
                    Image = "bunny4.jpeg"
                },
            ];

            FairyTalesCopy =
            [
                new FairyTale
                {
                    Name = "The Rabbit",
                    ReadTime = new TimeSpan(0, 3, 0),
                    IsSaved = false,
                    Image = "bunny.png"
                },

                new FairyTale
                {
                    Name = "Adventure of Brave",
                    ReadTime = new TimeSpan(0, 6, 0),
                    IsSaved = false,
                    Image = "bunny5.jpeg"
                },

                new FairyTale
                {
                    Name = "Rudy the Brave Rabbit ",
                    ReadTime = new TimeSpan(0, 9, 0),
                    IsSaved = false,
                    Image = "bunny2.jpeg"
                },

                new FairyTale
                {
                    Name = "Misadventures Rumble",
                    ReadTime = new TimeSpan(0, 12, 0),
                    IsSaved = false,
                    Image = "bunny3.jpeg"
                },

                new FairyTale
                {
                    Name = "Rabbit's Great Carrot",
                    ReadTime = new TimeSpan(0, 16, 0),
                    IsSaved = false,
                    Image = "bunny4.jpeg"
                },
            ];
        }

        private static void ModifySearchBar()
        {
            SearchBarHandler.Mapper.AppendToMapping("CustomSearchIconColor", (handler, view) =>
            {
#if ANDROID
                var context = handler.PlatformView.Context;
                var searchIconId = context.Resources.GetIdentifier("search_mag_icon", "id", context.PackageName);
                if (searchIconId != 0) 
                {
                    var searchIcon = handler.PlatformView.FindViewById<Android.Widget.ImageView>(searchIconId);                    
                    searchIcon.SetColorFilter(Android.Graphics.Color.Rgb(172, 157, 185), Android.Graphics.PorterDuff.Mode.SrcIn);                                           
                }

                Android.Widget.LinearLayout linearLayout =  handler.PlatformView.GetChildAt(0) as Android.Widget.LinearLayout;  
                linearLayout = linearLayout.GetChildAt(2) as Android.Widget.LinearLayout;  
                linearLayout = linearLayout.GetChildAt(1) as Android.Widget.LinearLayout;  
                linearLayout.Background = null;  
#endif
            });
        }
    }

}
