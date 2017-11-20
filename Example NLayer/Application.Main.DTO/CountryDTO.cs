﻿namespace Application.Main.DTO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// This is the data transfer object
    /// for country entity. The name
    /// of properties for this type
    /// is based on conventions of many mappers
    /// to simplificate the mapping process
    /// </summary>
    public class CountryDTO
    {
        public CountryDTO() { }
        /// <summary>
        /// The country identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The country name
        /// </summary>
        public string CountryName { get; set; }

        /// <summary>
        /// The country ISO Code
        /// </summary>
        public string CountryISOCode { get; set; }
    }
}
