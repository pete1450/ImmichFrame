﻿using ImmichFrame.Core.Exceptions;
using ImmichFrame.Core.Interfaces;
using ImmichFrame.WebApi.Helpers;

namespace ImmichFrame.WebApi.Models
{
    public class WebClientSettings : IWebClientSettings, IConfigSettable
    {
        public string ImmichServerUrl { get; set; } = string.Empty;
        public string Margin { get; set; } = "0,0,0,0";
        public int Interval { get; set; } = 45;
        public double TransitionDuration { get; set; } = 1;
        public bool DownloadImages { get; set; } = false;
        public int RenewImagesDuration { get; set; } = 20;
        public bool ShowClock { get; set; } = true;
        public string? ClockFormat { get; set; } = "hh:mm";
        public bool ShowPhotoDate { get; set; } = true;
        public string? PhotoDateFormat { get; set; } = "MM/dd/yyyy";
        public bool ShowImageDesc { get; set; } = true;
        public bool ShowPeopleDesc { get; set; } = true;
        public bool ShowAlbumName { get; set; } = true;
        public bool ShowImageLocation { get; set; } = true;
        public string? ImageLocationFormat { get; set; } = "City,State,Country";
        public string? PrimaryColor { get; set; }
        public string? SecondaryColor { get; set; }
        public string Style { get; set; } = "none";
        public string? BaseFontSize { get; set; }
        public bool ShowWeatherDescription { get; set; } = true;
        public bool UnattendedMode { get; set; } = false;
        public bool ImageZoom { get; set; } = true;
        public bool ImagePan { get; set; } = false;
        public bool ImageFill { get; set; } = false;
        public string Layout { get; set; } = "splitview";
        public string Language { get; set; } = "en";
    }
}
