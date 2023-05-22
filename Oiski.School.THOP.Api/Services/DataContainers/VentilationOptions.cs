﻿using System.ComponentModel.DataAnnotations;

namespace Oiski.School.THOP.Api.Services.DataContainers
{
    public class VentilationOptions : DeviceDetails
    {
        [Required] public bool On { get; set; } = true;
    }
}