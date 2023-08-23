using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.User
{
    public class ListRelatedBusinessesForTheProvidedUserQueryModel
    {
        public string Username { get; set; }
    }
}
