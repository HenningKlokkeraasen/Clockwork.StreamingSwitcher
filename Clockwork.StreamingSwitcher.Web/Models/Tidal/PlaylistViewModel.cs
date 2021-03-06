﻿using OpenTidl.Models;
using OpenTidl.Models.Base;

namespace Clockwork.StreamingSwitcher.Web.Models.Tidal
{
    public class PlaylistViewModel
    {
        public PlaylistModel Playlist { get; set; }
        public JsonList<TrackModel> Tracks { get; set; }
    }
}