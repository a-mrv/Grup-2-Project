

using Entities;

namespace MextFSBeginner.Entities.BaseClasses
{
    public class PersonBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName}{LastName}";
            }
        }

        public static implicit operator Teacher(Parent parent)
        {
            return new Teacher()
            {
                FirstName = parent.FirstName,
                LastName = parent.LastName,
                IdentityNumber = parent.IdentityNumber
            };
        }
        public string FullInfo => $"{FullName} - {IdentityNumber}";
      

    }
}
