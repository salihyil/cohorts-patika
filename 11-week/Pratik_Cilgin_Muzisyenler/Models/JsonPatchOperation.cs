using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Pratik_Cilgin_Muzisyenler.Models
{
    public class JsonPatchOperation
    {
        [DefaultValue("replace")]
        public string Op { get; set; } = "replace";

        [DefaultValue("/profession")]
        public string Path { get; set; } = "/profession";

        [Required]
        [DefaultValue("")]
        public string Value { get; set; }
    }
}