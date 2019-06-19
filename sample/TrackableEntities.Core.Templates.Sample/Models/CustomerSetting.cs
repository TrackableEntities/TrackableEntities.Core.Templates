using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TrackableEntities.Common.Core;

namespace TrackableEntities.Core.Templates.Sample.Models
{
    public partial class CustomerSetting : ITrackable, IMergeable
    {
        public string CustomerId { get; set; }
        public string Setting { get; set; }

        public virtual Customer Customer { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }

        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }

        [NotMapped]
        public Guid EntityIdentifier { get; set; }
    }
}
