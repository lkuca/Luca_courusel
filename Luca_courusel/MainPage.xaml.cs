using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Luca_courusel
{
    public partial class MainPage : CarouselPage
    {


        public MainPage()
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
                            Source ="f35.jpg",
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
            var brownContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text ="su57",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source ="1227139.jpg",
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
            Children.Add(brownContentPage);


        }
    }
}

