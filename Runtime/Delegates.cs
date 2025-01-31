﻿namespace Zigurous.Tweening
{
    /// <summary>
    /// A function delegate that gets the current value of a parameter.
    /// </summary>
    /// <typeparam name="T">The type of the parameter.</typeparam>
    /// <returns>The current value of the parameter.</returns>
    public delegate T TweenGetter<T>();

    /// <summary>
    /// A function delegate that sets a new value of a parameter.
    /// </summary>
    /// <typeparam name="T">The type of the parameter.</typeparam>
    /// <param name="value">The new value of the parameter.</param>
    public delegate void TweenSetter<T>(T value);

    /// <summary>
    /// A function delegate that can be invoked during various tween events
    /// and/or state changes.
    /// </summary>
    public delegate void TweenCallback();

    /// <summary>
    /// A function delegate that interpolates the value between
    /// <paramref name="a"/> and <paramref name="b"/> by <paramref name="t"/>.
    /// </summary>
    /// <typeparam name="T">The type of the parameter.</typeparam>
    /// <param name="a">The start value.</param>
    /// <param name="b">The end value.</param>
    /// <param name="t">The interpolation value between the start and end value.</param>
    /// <param name="snapping">Snaps the interpolated value to the nearest whole number.</param>
    /// <returns>The interpolated value between the start and end value.</returns>
    public delegate T Interpolater<T>(T a, T b, float t, bool snapping);

}
