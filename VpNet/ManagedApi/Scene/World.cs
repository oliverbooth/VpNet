﻿using System;
using System.Xml.Serialization;

namespace VpNet
{
    /// <summary>
    ///     Represents a world.
    /// </summary>
    [Serializable]
    public class World : IEquatable<World>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="World" /> class.
        /// </summary>
        public World()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="World" /> class by initializing the <see cref="Name" /> property.
        /// </summary>
        /// <param name="name">The world name.</param>
        public World(string name)
        {
            Name = name;
        }

        /// <summary>
        ///     Gets or sets the name of the world.
        /// </summary>
        /// <value>The name of the world.</value>
        public string Name { get; set; }
        
        /// <summary>
        ///     Gets or sets the number of users currently in the world.
        /// </summary>
        /// <value>The number of users currently in the world.</value>
        public int UserCount { get; set; }
        
        /// <summary>
        ///     Gets or sets the world state.
        /// </summary>
        /// <value>The world state.</value>
        public WorldState State { get; set; }

        /// <summary>
        ///     Gets or sets a view of the world attributes.
        /// </summary>
        /// <value>The world attributes.</value>
        public Dictionary<string, string> RawAttributes { get; set; } = new Dictionary<string, string>();
        
        /// <summary>
        ///     Gets or sets the local cache path.
        /// </summary>
        /// <value>The local cache path.</value>
        /// <remarks>
        ///     If this value is specified, the SDK will allow the option to cache models, unzip them and read their contents.
        /// </remarks>
        public string LocalCachePath { get; set; }

        /// <inheritdoc />
        public bool Equals(World other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Name == other.Name;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((World) obj);
        }

        /// <inheritdoc />
        public override int GetHashCode() => (Name != null ? Name.GetHashCode() : 0);

        public static bool operator ==(World left, World right) => Equals(left, right);

        public static bool operator !=(World left, World right) => !Equals(left, right);
    }
}
