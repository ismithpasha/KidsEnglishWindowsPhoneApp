using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Text;

namespace DrawingApp.UI
{
    public partial class ViewImage : PhoneApplicationPage
    {
        public ViewImage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if(NavigationContext.QueryString.ContainsKey("imgUrl"))
            {
                string image = NavigationContext.QueryString["imgUrl"].ToString();

                imageViewer.Source = new BitmapImage(new Uri(image, UriKind.Relative ));


                StringBuilder builder = new StringBuilder(image);
                builder.Remove(0, 33);

                if (builder.ToString() =="Aa.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/A.wav", UriKind.Relative);
                }
                else if(builder.ToString() == "Bb.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/B.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Cc.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/C.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Dd.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/D.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Ee.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/E.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Ff.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/F.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Gg.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/G.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Hh.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/H.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Ii.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/I.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Jj.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/J.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Kk.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/K.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Ll.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/L.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Mm.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/M.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Nn.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/N.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Oo.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/O.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Pp.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/P.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Qq.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/Q.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Rr.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/R.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Ss.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/S.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Tt.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/T.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Uu.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/U.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Vv.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/V.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Ww.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/W.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Xx.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/X.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Yy.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/Y.wav", UriKind.Relative);
                }
                else if (builder.ToString() == "Zz.jpg")
                {
                    mediaElement.Source = new Uri("Audio/Alphabet/Z.wav", UriKind.Relative);
                }
                mediaElement.Play();
            }

           


            base.OnNavigatedTo(e);
        }
    }
}