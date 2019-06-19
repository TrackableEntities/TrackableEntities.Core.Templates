using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TrackableEntities.Common.Core;

namespace TrackableEntities.Core.Templates.Sample.Models
{
    public partial class Employee : ITrackable, IMergeable
    {
        public Employee()
        {
            EmployeeTerritories = new HashSet<EmployeeTerritories>();
        }

        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual ICollection<EmployeeTerritories> EmployeeTerritories { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }

        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }

        [NotMapped]
        public Guid EntityIdentifier { get; set; }
    }
}
