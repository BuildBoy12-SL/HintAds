// -----------------------------------------------------------------------
// <copyright file="EventHandlers.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace HintAds
{
    using Exiled.Events.EventArgs;
    using HintAds.Components;
    using UnityEngine;

    /// <summary>
    /// Handles events derived from <see cref="Exiled.Events.Handlers"/>.
    /// </summary>
    public class EventHandlers
    {
        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnDestroying(DestroyingEventArgs)"/>
        public void OnDestroying(DestroyingEventArgs ev)
        {
            if (ev.Player.GameObject.TryGetComponent(out AdComponent adComponent))
                Object.Destroy(adComponent);
        }

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnVerified(VerifiedEventArgs)"/>
        public void OnVerified(VerifiedEventArgs ev)
        {
            ev.Player.GameObject.AddComponent<AdComponent>();
        }
    }
}