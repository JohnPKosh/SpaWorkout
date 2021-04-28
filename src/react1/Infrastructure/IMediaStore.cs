using react1.Models;

namespace react1.Infrastructure
{
  /// <summary>
  /// Public interface used to store and load media listings
  /// </summary>
  public interface IMediaStore
  {
    /// <summary>
    /// Method used to add/append a new media listing to the store.
    /// If the item does not already exist and is added to
    /// the store the method returns "true" otherwise "false"
    /// </summary>
    bool Add(MediaListing listing);

    /// <summary>
    /// Method used to retrieve a MediaCollection of all stored listings
    /// </summary>
    MediaCollection GetAll();
  }
}