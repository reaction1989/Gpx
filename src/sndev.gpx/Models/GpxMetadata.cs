// ==========================================================================
// Copyright (c) 2011-2016, dlg.krakow.pl
// All Rights Reserved
//
// NOTICE: dlg.krakow.pl permits you to use, modify, and distribute this file
// in accordance with the terms of the license agreement accompanying it.
// ==========================================================================

using System;

namespace Gpx
{
    public class GpxMetadata
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public GpxPerson Author { get; set; }
        public GpxCopyright Copyright { get; set; }
        public GpxLink Link { get; set; }
        public DateTime? Time { get; set; }
        public string Keywords { get; set; }
        public GpxBounds Bounds { get; set; }
    }
}
