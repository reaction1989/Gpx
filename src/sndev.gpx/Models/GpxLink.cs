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
    public class GpxLink
    {
        public string Href { get; set; }
        public string Text { get; set; }
        public string MimeType { get; set; }

        public Uri Uri
        {
            get
            {
                return Uri.TryCreate(Href, UriKind.Absolute, out var result) ? result : null;
            }
        }
    }
}
