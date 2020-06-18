using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YXAspNetCoreStudyWeb.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId { get => !string.IsNullOrEmpty(RequestId); }
    }
}
