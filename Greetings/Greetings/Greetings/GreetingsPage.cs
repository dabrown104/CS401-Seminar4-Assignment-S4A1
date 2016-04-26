using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Greetings
{
    public partial class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            Content = new Label
            {
                FormattedText = new FormattedString
                {
                    Spans =
                    {
                    new Span
                    {
                    Text = "Please take a look at this "
                    },
                    new Span
                    {
                    Text = "very",
                    FontAttributes = FontAttributes.Bold
                    },
                    new Span
                    {
                    Text = " important story about changing " +
                    "so much within a text. "
                    },
                    new Span
                    {
                    Text =
                    " This is a combination of " +
                    "span features and wrapping text " +
                    "within the same program." +
                    "You will also see how to change " +
                    "the text color and the background "
                    },
                    }
                },
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Green,
                TextColor = Color.Blue
            };

            Padding = new Thickness(5, Device.OnPlatform(20, 5, 5), 5, 5);

        }
    }
}
