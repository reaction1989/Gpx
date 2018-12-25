// ==========================================================================
// Copyright (c) 2011-2016, dlg.krakow.pl
// All Rights Reserved
//
// NOTICE: dlg.krakow.pl permits you to use, modify, and distribute this file
// in accordance with the terms of the license agreement accompanying it.
// ==========================================================================

namespace Gpx
{
    public class GpxRoute : GpxTrackOrRoute
    {
        private GpxPointCollection<GpxRoutePoint> RoutePoints_ = new GpxPointCollection<GpxRoutePoint>();

        public GpxPointCollection<GpxRoutePoint> RoutePoints
        {
            get { return RoutePoints_; }
        }

        public override GpxPointCollection<GpxPoint> ToGpxPoints()
        {
            GpxPointCollection<GpxPoint> points = new GpxPointCollection<GpxPoint>();

            foreach (GpxRoutePoint routePoint in RoutePoints_)
            {
                points.Add(routePoint);

                foreach (GpxPoint gpxPoint in routePoint.RoutePoints)
                {
                    points.Add(gpxPoint);
                }
            }

            return points;
        }
    }
}
