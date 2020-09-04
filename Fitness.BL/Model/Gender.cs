﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BL.Model
{
    /// <summary>
    /// Gender
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// New Gender
        /// </summary>
        /// <param name="name">Name of gender</param>
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Gender cannot be empty or null", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

}
