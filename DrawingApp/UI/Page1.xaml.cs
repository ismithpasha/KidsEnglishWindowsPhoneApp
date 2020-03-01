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
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows.Shapes;
using Windows.Phone.UI.Input;
using System.ComponentModel;

namespace DrawingApp
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
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

        /// <summary>
        /// Every touch action will rise this event handler. 
        /// </summary>
        void Touch_FrameReported(object sender, TouchFrameEventArgs e)
        {
            int pointsNumber = e.GetTouchPoints(drawCanvas).Count;
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

                    if (lineColor=="red")
                    {
                        line.Stroke = new SolidColorBrush(Colors.Red);
                        line.Fill = new SolidColorBrush(Colors.Red);

                    }
                    else if(lineColor=="blue")
                    {
                        line.Stroke = new SolidColorBrush(Colors.Blue);
                        line.Fill = new SolidColorBrush(Colors.Blue);

                    }
                    else if (lineColor == "sky")
                    {
                        line.Stroke = new SolidColorBrush(Colors.Cyan);
                        line.Fill = new SolidColorBrush(Colors.Cyan);

                    }
                    else if (lineColor == "yellow")
                    {
                        line.Stroke = new SolidColorBrush(Colors.Yellow);
                        line.Fill = new SolidColorBrush(Colors.Yellow);

                    }
                    else if (lineColor == "green")
                    {
                        line.Stroke = new SolidColorBrush(Colors.Green);
                        line.Fill = new SolidColorBrush(Colors.Green);

                    }
                    else if (lineColor == "orange")
                    {
                        line.Stroke = new SolidColorBrush(Colors.Orange);
                        line.Fill = new SolidColorBrush(Colors.Orange);

                    }
                    else if (lineColor == "violate")
                    {
                        line.Stroke = new SolidColorBrush(Colors.Purple);
                        line.Fill = new SolidColorBrush(Colors.Purple);

                    }
                    else if (lineColor == "megenta")
                    {
                        line.Stroke = new SolidColorBrush(Colors.Magenta);
                        line.Fill = new SolidColorBrush(Colors.Magenta);

                    }
                    else if (lineColor == "white")
                    {
                        line.Stroke = new SolidColorBrush(Colors.White);
                        line.Fill = new SolidColorBrush(Colors.White);

                    }
                    else if (lineColor == "black")
                    {
                        line.Stroke = new SolidColorBrush(Colors.Black);
                        line.Fill = new SolidColorBrush(Colors.Black);

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

        /// <summary>
        /// Save image to Media Library so that we can view pictures we created
        /// </summary>
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            MediaLibrary library = new MediaLibrary();
            WriteableBitmap bitMap = new WriteableBitmap(drawCanvas, null);
            MemoryStream ms = new MemoryStream();
            Extensions.SaveJpeg(bitMap, ms, bitMap.PixelWidth,
                                bitMap.PixelHeight, 0, 100);
            ms.Seek(0, SeekOrigin.Begin);
            library.SavePicture(string.Format("DImages\\{0}.jpg",Guid.NewGuid()), ms);

            MessageBox.Show(" Successfully Saved :) ");
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            drawCanvas.Children.Clear();
        }




        protected override void OnBackKeyPress(CancelEventArgs e)
        {
            Touch.FrameReported -= Touch_FrameReported;
            //base.OnBackKeyPress(e);
            //MessageBox.Show("You pressed the Back button");
            //e.Cancel = true;
        }


        private void redButton_Click(object sender, RoutedEventArgs e)
        {
            lineColor = "red";
        }

        private void blueButton_Click(object sender, RoutedEventArgs e)
        {
            lineColor = "blue";
        }

        private void greenButton_Click(object sender, RoutedEventArgs e)
        {
            lineColor = "green";
        }

        private void yellowButton_Click(object sender, RoutedEventArgs e)
        {
            lineColor = "yellow";
        }

        private void violateButton_Click(object sender, RoutedEventArgs e)
        {
            lineColor = "violate";
        }

        private void blackButton_Click(object sender, RoutedEventArgs e)
        {
            lineColor = "black";
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            Touch.FrameReported -= Touch_FrameReported;
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void orangeButton_Click(object sender, RoutedEventArgs e)
        {
            lineColor = "orange";
        }

        private void skyBlueButton_Click(object sender, RoutedEventArgs e)
        {
            lineColor = "sky";
        }

        private void whiteButton_Click(object sender, RoutedEventArgs e)
        {
            linePixel=10;
            lineColor = "white";

        }

        private void _2pxButton_Click(object sender, RoutedEventArgs e)
        {
            linePixel = 2;
        }

        private void _4pxButton_Click(object sender, RoutedEventArgs e)
        {
            linePixel = 4;
        }

        private void _8pxButton_Click(object sender, RoutedEventArgs e)
        {
            linePixel = 8;
        }

        private void megentaButton_Click(object sender, RoutedEventArgs e)
        {
            lineColor = "megenta";
        }
    }
}