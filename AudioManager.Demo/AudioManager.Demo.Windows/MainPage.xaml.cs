﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace AudioManager.Demo.Windows
{
    public sealed partial class MainPage : IAudioManagerContainer
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new AudioManager.Demo.App());

            AudioManagerContainer = this.Content as Canvas;
        }

        public Canvas AudioManagerContainer { get; set; }
    }
}
