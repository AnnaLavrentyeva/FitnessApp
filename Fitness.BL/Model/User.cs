using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BL.Model
{
    /// <summary>
    /// User
    /// </summary>
    public class User
    {
        #region User's condition
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get;}      //Once set
        /// <summary>
        /// Gender
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// DateOfBirth
        /// </summary>
        public DateTime BirthDate { get; }
        /// <summary>
        /// Weight
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        public double Height { get; set; }
        #endregion
        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="name"> Name. </param>
        /// <param name="gender"> Gender. </param>
        /// <param name="birthDay"> Birthday. </param>
        /// <param name="weight"> Weight. </param>
        /// <param name="height"> Height. </param>
        public User(string name, Gender gender, DateTime birthDay, 
                        double weight, double height)
        {
            #region Set conditions
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("User name cannot be empty or null.", nameof(name));
            }
            if(gender == null)
            {
                throw new ArgumentNullException("Gender cannot be empty or null.", nameof(gender));
            }
            if (birthDay < DateTime.Parse("01.01.1900") || birthDay >= DateTime.Now)
            {
                throw new ArgumentNullException("Incorrect date of birth.", nameof(birthDay));
            }

            if (weight <= 0)
            {
                throw new ArgumentNullException("Weight cannot be less then 0.", nameof(weight));
            }
            if (height <= 0)
            {
                throw new ArgumentNullException("Height cannot be less then 0.", nameof(height));
            }

            Name = name;
            Gender = gender;
            BirthDate = birthDay;
            Weight = weight;
            Height = height;
        }
        #endregion

        public override string ToString()
        {
            return Name;
        }
    }
}
