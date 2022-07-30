// -----------------------------------------------------------------------
// <copyright file="Plugin.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace HintAds
{
    using Exiled.API.Features;

    /// <summary>
    /// The main plugin class.
    /// </summary>
    public class Plugin : Plugin<Config>
    {
        private EventHandlers eventHandlers;

        /// <summary>
        /// Gets a static instance of the <see cref="Plugin"/> class.
        /// </summary>
        public static Plugin Instance { get; private set; }

        /// <inheritdoc />
        public override void OnEnabled()
        {
            Instance = this;
            eventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Player.Destroying += eventHandlers.OnDestroying;
            Exiled.Events.Handlers.Player.Verified += eventHandlers.OnVerified;
            base.OnEnabled();
        }

        /// <inheritdoc />
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Destroying -= eventHandlers.OnDestroying;
            Exiled.Events.Handlers.Player.Verified -= eventHandlers.OnVerified;
            eventHandlers = null;
            Instance = null;
            base.OnDisabled();
        }
    }
}