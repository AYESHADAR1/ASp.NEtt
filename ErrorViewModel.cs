using System;

namespace MyProjectSp.Models
{
    public class ErrorViewModel
    {
        public string ReqId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(ReqId);
    }

}