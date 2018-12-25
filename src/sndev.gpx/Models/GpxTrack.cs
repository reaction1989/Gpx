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
    public class GpxTrack : GpxTrackOrRoute
    {
        private List<GpxTrackSegment> Segments_ = new List<GpxTrackSegment>(1);

        public IList<GpxTrackSegment> Segments
        {
            get { return Segments_; }
        }

        public override GpxPointCollection<GpxPoint> ToGpxPoints()
        {
            GpxPointCollection<GpxPoint> points = new GpxPointCollection<GpxPoint>();

            foreach (GpxTrackSegment segment in Segments_)
            {
                GpxPointCollection<GpxPoint> segmentPoints = segment.TrackPoints.ToGpxPoints();

                foreach (GpxPoint point in segmentPoints)
                {
                    points.Add(point);
                }
            }

            return points;
        }
    }
}
