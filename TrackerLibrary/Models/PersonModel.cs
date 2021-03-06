using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Id for the person
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the first name of a person
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents the last name of a person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents the email of a person
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represenst the phone number of a person
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get { 
                return $"{ FirstName } { LastName }"; 
            }
        }

    }
}
