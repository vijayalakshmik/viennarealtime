﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WienerLinien.Api.Routing;

namespace MundlTransit.WP8.Model
{
    public class RoutingTripModel
    {
        public RoutingTripModel(Trip t)
        {
            Trip = t;
        }

        public Trip Trip { get; set; }

        public string TripName
        {
            get
            {
                return "Trip " + Trip.Number.ToString();
            }
        }

        public string Duration
        {
            get
            {
                // TODO: Better formatting depending on "are there seconds at all" &c
                return Trip.Duration.ToString();
            }
        }

        public string LegInfo
        {
            get
            {
                return "# of legs: " + Trip.Legs.Count().ToString();
            }
        }
    }
}
