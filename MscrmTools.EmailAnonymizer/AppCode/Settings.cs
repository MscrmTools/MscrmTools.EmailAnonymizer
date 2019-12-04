using Microsoft.Xrm.Sdk.Metadata;
using System.Collections.Generic;

namespace MscrmTools.EmailAnonymizer.AppCode
{
    internal class Settings
    {
        public List<StringAttributeMetadata> Attributes { get; set; } = new List<StringAttributeMetadata>();
        public string Format { get; set; }
        public int ItemsPerRequest { get; set; }
    }
}