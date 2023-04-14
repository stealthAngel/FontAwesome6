﻿namespace DesktopClient.Framework.FontAwesome.core
{
    /// <summary>
    /// Defines the different flip orientations that a icon can have.
    /// </summary>    
    public enum EFlipOrientation
    {
        /// <summary>
        /// Default
        /// </summary>
        Normal = 0,
        /// <summary>
        /// Flip horizontally (on x-achsis)
        /// </summary>
        Horizontal,
        /// <summary>
        /// Flip vertically (on y-achsis)
        /// </summary>
        Vertical,
    }

    /// <summary>
    /// Represents a flippable control
    /// </summary>
    public interface IFlippable
    {
        /// <summary>
        /// Gets or sets the current orientation (horizontal, vertical).
        /// </summary>
        EFlipOrientation FlipOrientation { get; set; }
    }
}
