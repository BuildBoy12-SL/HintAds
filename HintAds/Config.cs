// -----------------------------------------------------------------------
// <copyright file="Config.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace HintAds
{
    using AdvancedHints.Enums;
    using Exiled.API.Interfaces;

    /// <inheritdoc />
    public class Config : IConfig
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets the amount of time, in seconds, that each ad should display for.
        /// </summary>
        public float RotationInterval { get; set; } = 5f;

        /// <summary>
        /// Gets or sets the amount of time, in seconds, that the ad should have a buffer for.
        /// </summary>
        public float DisplayOffset { get; set; } = 1f;

        /// <summary>
        /// Gets or sets the collection of ads to cycle through.
        /// </summary>
        public Ad[] HintsToRotate { get; set; } =
        {
            new("<align=left>Look at me!</align>", DisplayLocation.Bottom),
            new("<align=left>I'm so cool!</align>", DisplayLocation.Bottom),
        };
    }
}