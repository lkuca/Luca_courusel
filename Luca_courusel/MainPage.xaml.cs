using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Luca_courusel
{
    public partial class MainPage : CarouselPage
    {


        public MainPage()
        {
           

            var webViewPage = new ContentPage
            {
                Content = new WebView
                {
                    Source = "https://www.defense.gov/Multimedia/Quizzes/Quiz/Article/1677339/just-a-plane-quiz/"
                }
            };

            var openBrowserButton = new Button
            {
                Text = "Open in Browser",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

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
                        },
                        new Label
                        {
                            Text= "Sa otsustad rahulik valik, võib olla ülehinnatud aga see on sinu valik",
                            FontSize=20,
                            HorizontalOptions = LayoutOptions.Center,
                            TextColor= Color.Black,
                            IsVisible= false
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
                        },
                        new Label
                        {
                             Text= "Kui Sa otsustad see valik, olen nõus see on hea valik",
                            FontSize=20,
                            HorizontalOptions = LayoutOptions.Center,
                            TextColor= Color.Black,
                            IsVisible= true
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
                        },
                        new Label
                        {
                             Text= "Saa oled Hipster!",
                            FontSize=20,
                            HorizontalOptions = LayoutOptions.Center,
                            TextColor= Color.Black,
                            IsVisible= false
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
                            Source ="suk.jpg",
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
            Children.Add(webViewPage);
            imageText();
            
            
            
            
        }
        


        private void imageText()
        {
            var redtaprecognizer = new TapGestureRecognizer();
            redtaprecognizer.Tapped += (sender, e) =>
            {
                ((Label)((StackLayout)((ContentPage)Children[0]).Content).Children[2]).IsVisible = !((Label)((StackLayout)((ContentPage)Children[0]).Content).Children[2]).IsVisible;
            };
            ((Image)((StackLayout)((ContentPage)Children[0]).Content).Children[1]).GestureRecognizers.Add(redtaprecognizer);

            var greentaprecognizer = new TapGestureRecognizer();
            greentaprecognizer.Tapped += (sender, e) =>
            {
                ((Label)((StackLayout)((ContentPage)Children[1]).Content).Children[2]).IsVisible = !((Label)((StackLayout)((ContentPage)Children[1]).Content).Children[2]).IsVisible;
            };
            ((Image)((StackLayout)((ContentPage)Children[1]).Content).Children[1]).GestureRecognizers.Add(greentaprecognizer);

            var bluetaprecognizer = new TapGestureRecognizer();
            bluetaprecognizer.Tapped += (sender, e) =>
            {
                ((Label)((StackLayout)((ContentPage)Children[2]).Content).Children[2]).IsVisible = !((Label)((StackLayout)((ContentPage)Children[2]).Content).Children[2]).IsVisible;
            };
            ((Image)((StackLayout)((ContentPage)Children[2]).Content).Children[1]).GestureRecognizers.Add(bluetaprecognizer);

            var browni = new TapGestureRecognizer();
            browni.Tapped += (sender, e) =>
            {
                ((Label)((StackLayout)((ContentPage)Children[3]).Content).Children[2]).IsVisible = !((Label)((StackLayout)((ContentPage)Children[3]).Content).Children[2]).IsVisible;
            };
            ((Image)((StackLayout)((ContentPage)Children[3]).Content).Children[1]).GestureRecognizers.Add(browni);
        }
    }
}

