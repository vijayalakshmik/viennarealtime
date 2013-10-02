﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WienerLinien.Api.Routing;

namespace MundlTransit.WP8.Model
{
    public class RoutingTripModel : List<RoutingTripLegModel>
    {
        public static List<RoutingTripModel> TripsToTripModels(List<Trip> trips)
        {
            return trips.Select(t => new RoutingTripModel(t)).ToList();
        }

        public RoutingTripModel(Trip t) : base(t.Legs.Select(l => l.ToModel()))
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
