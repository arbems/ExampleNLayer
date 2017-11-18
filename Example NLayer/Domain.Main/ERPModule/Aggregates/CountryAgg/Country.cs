﻿namespace Nlayer.Samples.NLayerApp.Domain.Main.ERPModule.Aggregates.CountryAgg
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Nlayer.Samples.NLayerApp.Domain.Core;
    using Nlayer.Samples.NLayerApp.Domain.Main.Resources;

    /// <summary>
    /// The country entity
    /// </summary>
    public class Country
        :Entity
    {
        #region Properties

        /// <summary>
        /// Get or set the Country Name
        /// </summary>
        public string CountryName { get; private set; }

        /// <summary>
        /// Get or set the Country ISO Code
        /// </summary>
        public string CountryISOCode { get; private set; }

        #endregion

        #region Constructor

        //required by EF
        public Country() { } 

        public Country(string countryName, string countryISOCode)
        {
            if (String.IsNullOrWhiteSpace(countryName))
                throw new ArgumentNullException("countryName");

            if (String.IsNullOrWhiteSpace(countryISOCode))
                throw new ArgumentNullException("countryISOCode");

            this.CountryName = countryName;
            this.CountryISOCode = countryISOCode;
        }

        #endregion
    }
}