using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the person
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The first name of the person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// The Email of the person
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The cell phone number of the person
        /// </summary>
        public string CellphoneNumber { get; set; }




        public string FullName
        {
            get
            {
                return $"{FirstName} {Lastname}"; 
            }
        }

    }
}
