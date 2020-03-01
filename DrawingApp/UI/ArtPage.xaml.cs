using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Xna.Framework.Media;
using System.IO;
using Microsoft.Phone.Data.Linq;
using System.Windows.Media.Imaging;
using System.Windows.Input;
using System.Windows.Shapes;
using System.Windows.Media;
using System.ComponentModel;

namespace DrawingApp.UI
{
    public partial class ArtPage : PhoneApplicationPage
    {
        public ArtPage()
        {
            InitializeComponent();
            Touch.FrameReported += new TouchFrameEventHandler(Touch_FrameReported);


        }

        string lineColor = "";
        int linePixel = 2;

        // preXArray and preYArray are used to store the start point 
        // for each touch point. currently silverlight support 4 muliti-touch
        // here declare as 10 points for further needs. 
        double[] preXArray = new double[10];
        double[] preYArray = new double[10];

        int pointsNumber = 0;
        void Touch_FrameReported(object sender, TouchFrameEventArgs e)
        {

                pointsNumber = e.GetTouchPoints(drawCanvas).Count;
                TouchPointCollection pointCollection = e.GetTouchPoints(drawCanvas);

                for (int i = 0; i < pointsNumber; i++)
                {
                    if (pointCollection[i].Action == TouchAction.Down)
                    {
                        preXArray[i] = pointCollection[i].Position.X;
                        preYArray[i] = pointCollection[i].Position.Y;
                    }
                    if (pointCollection[i].Action == TouchAction.Move)
                    {
                        Line line = new Line();


                        line.X1 = preXArray[i];
                        line.Y1 = preYArray[i];
                        line.X2 = pointCollection[i].Position.X;
                        line.Y2 = pointCollection[i].Position.Y;

                        line.StrokeThickness = linePixel;




                        if (lineColor == "black")
                        {
                            line.Stroke = new SolidColorBrush(Colors.Black);
                            line.Fill = new SolidColorBrush(Colors.Black);

                        }
                   else if (lineColor == "white")
                    {
                        line.Stroke = new SolidColorBrush(Colors.White);
                        line.Fill = new SolidColorBrush(Colors.White);

                    }
                    else
                        {
                            line.Stroke = new SolidColorBrush(Colors.Black);
                            line.Fill = new SolidColorBrush(Colors.Black);

                        }


                        drawCanvas.Children.Add(line);

                        preXArray[i] = pointCollection[i].Position.X;
                        preYArray[i] = pointCollection[i].Position.Y;
                    }
                }

            
        }

        
    private void Save_Click(object sender, RoutedEventArgs e)
        {
            MediaLibrary library = new MediaLibrary();
            WriteableBitmap bitMap = new WriteableBitmap(drawCanvas, null);
            MemoryStream ms = new MemoryStream();
            System.Windows.Media.Imaging.Extensions.SaveJpeg(bitMap, ms, bitMap.PixelWidth,
                                bitMap.PixelHeight, 0, 100);
            ms.Seek(0, SeekOrigin.Begin);
            library.SavePicture(string.Format("DImages\\{0}.jpg", Guid.NewGuid()), ms);

            MessageBox.Show(" Successfully Saved :) ");
        }

        int backImgCode = 0;

        private void New_Click(object sender, RoutedEventArgs e)
        {
             drawCanvas.Children.Clear();
            backImgCode++;
            ImageBrush background = new ImageBrush();
            background.ImageSource = new BitmapImage(new Uri(@"\abc"+backImgCode+".png", UriKind.Relative));
            drawCanvas.Background = background;
            if(backImgCode>2)
            {
                backImgCode = 0;
            }

        }
        protected override void OnBackKeyPress(CancelEventArgs e)
        {
            Touch.FrameReported -= Touch_FrameReported;
            //base.OnBackKeyPress(e);
            //MessageBox.Show("You pressed the Back button");
            //e.Cancel = true;
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            Touch.FrameReported -= Touch_FrameReported;

            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void blackButton_Click(object sender, RoutedEventArgs e)
        {
            linePixel = 4;
            lineColor = "black";
        }

        private void _8pxButton_Click(object sender, RoutedEventArgs e)
        {
            linePixel = 8;
        }

        private void _4pxButton_Click(object sender, RoutedEventArgs e)
        {
            linePixel = 4;
        }

        private void _2pxButton_Click(object sender, RoutedEventArgs e)
        {
            linePixel = 2;
        }

        private void whiteButton_Click(object sender, RoutedEventArgs e)
        {
            linePixel = 14;
            lineColor = "white";
        }
    }
}