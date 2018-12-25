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
    public abstract class GpxTrackOrRoute
    {
        private List<GpxLink> Links_ = new List<GpxLink>(0);

        public string Name { get; set; }
        public string Comment { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public int? Number { get; set; }
        public string Type { get; set; }

        public IList<GpxLink> Links
        {
            get { return Links_; }
        }

        // GARMIN_EXTENSIONS

        public GpxColor? DisplayColor { get; set; }

        public bool HasExtensions
        {
            get { return DisplayColor != null; }
        }

        public abstract GpxPointCollection<GpxPoint> ToGpxPoints();
    }
}
