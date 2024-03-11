using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Luca_courusel
{
    public partial class MainPage2 : CarouselPage
    {


        public MainPage2()
        {

            var redContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text ="F35",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source ="F35-Fighter-jet-at-supersonic-speeds.jpg",
                            WidthRequest = 200,
                            HeightRequest = 200,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };

            var greenContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text ="F16",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source ="images.jpg",
                            WidthRequest = 200,
                            HeightRequest = 200,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };
            var BlueContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text ="jetgen6",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source ="UQNIDVJ2RJADBHLNUYV3GU55I4.jpg",
                            WidthRequest = 200,
                            HeightRequest = 200,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };
            Children.Add(redContentPage);
            Children.Add(greenContentPage);
            Children.Add(BlueContentPage);


        }
    }
}