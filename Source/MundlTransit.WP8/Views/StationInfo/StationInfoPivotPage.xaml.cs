﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using CM = Caliburn.Micro;

namespace MundlTransit.WP8.Views.StationInfo
{
    public partial class StationInfoPivotPage : PhoneApplicationPage
    {
        public StationInfoPivotPage()
        {
            InitializeComponent();
            BuildLocalizedApplicationBar();
        }

        private void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();

            var addToFavsAppBarButton = new CM.AppBarButton()
            {
                IconUri = new Uri("/Assets/favs.addto.png", UriKind.Relative),
                Text = "favorite",
                Message = "AddToFavorites"
            };

            ApplicationBar.Buttons.Add(addToFavsAppBarButton);

            var walkToAppBarButton = new CM.AppBarButton()
            {
                IconUri = new Uri("/Assets/map.centerme.png", UriKind.Relative),
                Text = "walk to",
                Message = "WalkTo"
            };

            ApplicationBar.Buttons.Add(walkToAppBarButton);

            var refreshAppBarButton = new CM.AppBarButton()
            {
                IconUri = new Uri("/Assets/refresh.png", UriKind.Relative),
                Text = "refresh",
                Message = "RefreshDepartureInformation"
            };

            ApplicationBar.Buttons.Add(refreshAppBarButton);
        }
    }
}