using System;
using System.Linq;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PivotHeaderStyle
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Color color = Colors.Red;
        public MainPage()
        {
            this.InitializeComponent();
            // Change FontFamily
            /*
             Setter setterFont = new Setter();
            setterFont.Property = Pivot.FontFamilyProperty;
            setterFont.Value = "Times New Roman";
            Style style = new Style(typeof(PivotHeaderItem));
            style.Setters.Add(setterFont);
            rootPivot.Resources[typeof(PivotHeaderItem)] = style;
            // Change color or set image of background on unselected items
            Setter setterBackground = new Setter();
            setterBackground.Property = Pivot.BackgroundProperty;
            ImageBrush image = new ImageBrush();
            image.ImageSource = new BitmapImage(new Uri(this.BaseUri, "/Assets/StoreLogo.png"));
            setterBackground.Value = image;
            //setterBackground.Value = Colors.Green;
            style.Setters.Add(setterBackground);
            rootPivot.Resources[typeof(PivotHeaderItem)] = style;
            */
        }

        private void ChangeColorOfResourse_OnClick(object sender, RoutedEventArgs e)
        {
            //Color(value) changes by reference
            var mergedDict = Application.Current.Resources.MergedDictionaries.Where(md => md.Source.OriginalString.Equals("ms-appx:///resourceDictionary.xaml")).FirstOrDefault();//Access to ResourseDictionary by source string
            var value = (SolidColorBrush)((Setter)((Style)mergedDict["Header"]).Setters[0]).Value;
            value.Color = color;
            Style back = (Style) mergedDict["Header"];
            rootPivot.Resources[typeof(PivotHeaderItem)] = back;
            color = Colors.Green;
        }
    }
}
