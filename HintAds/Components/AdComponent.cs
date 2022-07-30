// -----------------------------------------------------------------------
// <copyright file="AdComponent.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace HintAds.Components
{
    using System.Collections.Generic;
    using Exiled.API.Features;
    using MEC;
    using UnityEngine;

    /// <inheritdoc />
    public class AdComponent : MonoBehaviour
    {
        private Player player;
        private CoroutineHandle coroutine;
        private Config config;
        private int currentIndex;

        private void Awake()
        {
            player = Player.Get(gameObject);
            config = Plugin.Instance.Config;
            coroutine = Timing.RunCoroutine(DisplayNext());
        }

        private void OnDestroy()
        {
            Timing.KillCoroutines(coroutine);
        }

        private IEnumerator<float> DisplayNext()
        {
            while (true)
            {
                yield return Timing.WaitForSeconds(config.RotationInterval);

                Ad ad = GetNext();
                if (ad != null)
                    AdvancedHints.Extensions.ShowManagedHint(player, ad.Message, config.RotationInterval + config.DisplayOffset, false, ad.Location);
            }
        }

        private Ad GetNext()
        {
            if (config.HintsToRotate == null || config.HintsToRotate.Length == 0)
                return null;

            if (++currentIndex == config.HintsToRotate.Length)
                currentIndex = 0;

            return config.HintsToRotate[currentIndex];
        }
    }
}