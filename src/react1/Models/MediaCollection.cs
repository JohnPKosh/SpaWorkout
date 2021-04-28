using System.Collections.Generic;
using SRF.Models.Objects;

namespace react1.Models
{
  /// <summary>
  /// A class to store listings of media (e.g. Books, Movies, etc.)
  /// </summary>
  public class MediaCollection: ObjectBase<MediaCollection>
  {
    /// <summary>
    /// The collection property of media listings
    /// </summary>
    /// <remarks>
    /// Using <![CDATA[HashSet<MediaListing>]]> to apply
    /// IEquatable logic for distinct item guarantees and performance
    /// </remarks>
    public HashSet<MediaListing> Listings { get; set; } = new HashSet<MediaListing>();
  }
}
