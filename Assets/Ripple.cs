﻿using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects {
    [ExecuteInEditMode]
    [AddComponentMenu("Image Effects/Ripple")]
    public class Ripple : ImageEffectBase {
        // Called by camera to apply image effect
        void OnRenderImage(RenderTexture source, RenderTexture destination) {
            Graphics.Blit(source, destination, material);
        }
    }
}
