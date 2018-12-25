// ==========================================================================
// Copyright (c) 2011-2016, dlg.krakow.pl
// All Rights Reserved
//
// NOTICE: dlg.krakow.pl permits you to use, modify, and distribute this file
// in accordance with the terms of the license agreement accompanying it.
// ==========================================================================

using System.Collections.Generic;

namespace Gpx
{
    public class GpxRoutePoint : GpxPoint
    {
        // GARMIN_EXTENSIONS

        public IList<GpxPoint> RoutePoints
        {
            get { return Properties_.GetListProperty<GpxPoint>("RoutePoints"); }
        }

        public bool HasExtensions
        {
            get { return RoutePoints.Count != 0; }
        }
    }
}
