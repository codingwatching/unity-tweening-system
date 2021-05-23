﻿using System.Collections.Generic;

namespace Zigurous.TweenEngine
{
    /// <summary>
    /// An easing function type. Easing functions specify the rate of change of
    /// a parameter over time.
    /// </summary>
    public enum Ease : int
    {
        Linear,
        SineIn,
        SineOut,
        SineInOut,
        CubicIn,
        CubicOut,
        CubicInOut,
        QuadIn,
        QuadOut,
        QuadInOut,
        QuartIn,
        QuartOut,
        QuartInOut,
        QuintIn,
        QuintOut,
        QuintInOut,
        ExpoIn,
        ExpoOut,
        ExpoInOut,
        CircIn,
        CircOut,
        CircInOut,
        BackIn,
        BackOut,
        BackInOut,
        ElasticIn,
        ElasticOut,
        ElasticInOut,
        BounceIn,
        BounceOut,
        BounceInOut
    }

    public sealed class EaseEqualityComparer : IEqualityComparer<Ease>
    {
        public bool Equals(Ease x, Ease y) => x == y;

        public int GetHashCode(Ease ease) => (int)ease;
    }

    public static class EaseExtensions
    {
        /// <summary>
        /// Returns the f(x) value using the ease function.
        /// </summary>
        public static float ValueAt(this Ease ease, float x)
        {
            return EaseFunction.lookup[ease](x);
        }

    }

}
