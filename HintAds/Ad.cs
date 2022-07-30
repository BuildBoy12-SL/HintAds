// -----------------------------------------------------------------------
// <copyright file="Ad.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace HintAds
{
    using System;
    using AdvancedHints.Enums;

    /// <summary>
    /// Represents an ad.
    /// </summary>
    [Serializable]
    public class Ad
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ad"/> class.
        /// </summary>
        public Ad()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ad"/> class.
        /// </summary>
        /// <param name="message"><inheritdoc cref="Message"/></param>
        /// <param name="location"><inheritdoc cref="Location"/></param>
        public Ad(string message, DisplayLocation location = DisplayLocation.MiddleBottom)
        {
            Message = message;
            Location = location;
        }

        /// <summary>
        /// Gets or sets the contents of the ad.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets where to display the ad.
        /// </summary>
        public DisplayLocation Location { get; set; }
    }
}