using System;

namespace WebAppHotel.Models
{
    public class ErrorViewModels
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}