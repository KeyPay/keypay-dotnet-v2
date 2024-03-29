using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Common
{
    public class WhiteLabelBrandingModel
    {
        public string LogoUrl { get; set; }
        public string BackgroundImageUrl { get; set; }
        public string BackgroundColour { get; set; }
        public string TextColour { get; set; }
        public string TextHoverColour { get; set; }
        public string TextSecondaryColour { get; set; }
        public string DarkModeLogoUrl { get; set; }
        public string DarkModeBackgroundColour { get; set; }
        public string DarkModeTextColour { get; set; }
        public string DarkModeTextSecondaryColour { get; set; }
    }
}
