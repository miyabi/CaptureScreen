using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Devices;
using CaptureScreen;

using System.Diagnostics;
using Microsoft.Xna.Framework;
using System.Windows.Media.Imaging;


namespace CaptureTest
{
	public partial class MainPage : PhoneApplicationPage
	{
		// Constructor
		public MainPage()
		{
			InitializeComponent();

			captureButton.Click += new RoutedEventHandler(captureButton_Click);
		}

		void captureButton_Click(object sender, RoutedEventArgs e)
		{
			captureButton.Visibility = Visibility.Collapsed;
			CaptureScreen.CaptureScreen.capture(100);
			captureButton.Visibility = Visibility.Visible;
		}
	}
}