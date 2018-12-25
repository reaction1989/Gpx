// ==========================================================================
// Copyright (c) 2011-2016, dlg.krakow.pl
// All Rights Reserved
//
// NOTICE: dlg.krakow.pl permits you to use, modify, and distribute this file
// in accordance with the terms of the license agreement accompanying it.
// ==========================================================================

namespace Gpx
{
    public class GpxTrackSegment
    {
        GpxPointCollection<GpxTrackPoint> TrackPoints_ = new GpxPointCollection<GpxTrackPoint>();

        public GpxPointCollection<GpxTrackPoint> TrackPoints
        {
            get { return TrackPoints_; }
        }
    }
}
