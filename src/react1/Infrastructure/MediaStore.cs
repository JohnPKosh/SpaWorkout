using System.IO;
using SRF.Settings;
using react1.Models;


namespace react1.Infrastructure
{
  /// <summary>
  /// A basic concrete IMediaStore implementation used to store and load media listings
  /// </summary>
  public class MediaStore : IMediaStore
  {
    const string FILE_NAME = "data.json";

    readonly string m_FilePath;

    public MediaStore() { m_FilePath = Path.Combine(IoConfig.Data.FullName, FILE_NAME); }

    /// <inheritdoc/>
    public bool Add(MediaListing listing)
    {
      if (listing == null) return false;
      var fileInfo = new FileInfo(m_FilePath);

      var media = new MediaCollection().FromFile(fileInfo);
      if (!media.Listings.Add(listing)) return false;
      media.ToFile(fileInfo);
      return true;
    }

    /// <inheritdoc/>
    public MediaCollection GetAll()
      => new MediaCollection().FromFile(new FileInfo(m_FilePath));
  }
}
