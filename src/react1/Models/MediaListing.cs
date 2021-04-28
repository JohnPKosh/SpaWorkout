using System;
using System.ComponentModel.DataAnnotations;

namespace react1.Models
{
  /// <summary>
  /// An abstract catalog metadata base class for storing simple
  /// publication listings such as books and movies.
  /// </summary>
  /// <remarks>
  /// For a more robust catalog system consider basing
  /// on Dublin Core standard definitions.
  /// </remarks>
  public class MediaListing : IEquatable<MediaListing>
  {
    #region .ctors

    public MediaListing() { }

    protected MediaListing(string contentType) { ContentType = contentType; }

    #endregion

    #region Public Properties

    /// <summary>
    /// The catalog identifier value used in
    /// storage and retrieval by id
    /// </summary>
    public Guid Identifier { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(50, MinimumLength = 3)]
    /// <summary>
    /// The creator of the document (author or director)
    /// </summary>
    public string Creator { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 3)]
    /// <summary>
    /// The title of the media item
    /// </summary>
    public string Title { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 3)]
    /// <summary>
    /// A string that indicates the type of Media (e.g. Book, Movie, etc.)
    /// </summary>
    public string ContentType { get; set; } = "Media";

    #endregion

    #region IEquatable Methods

    /// <summary>
    /// MediaListing Equals methods for IEquatable.
    /// </summary>
    public bool Equals(MediaListing other)
    {
      return GetHashCode() == other?.GetHashCode();
    }

    /// <summary>
    /// Overidden GetHashCode method.
    /// </summary>
    public override int GetHashCode()
    {
      return HashCode.Combine(Creator, Title, ContentType);
    }

    /// <summary>
    /// Overridden object Equals method.
    /// </summary>
    public override bool Equals(object obj)
    {
      return Equals(obj as MediaListing);
    }

    /// <summary>
    /// Comparison operator to check equality of two DateRange objects.
    /// </summary>
    public static bool operator ==(MediaListing left, MediaListing right)
    {
      return left.Equals(right);
    }

    /// <summary>
    /// Comparison operator to check inequality of two DateRange objects.
    /// </summary>
    public static bool operator !=(MediaListing left, MediaListing right)
    {
      return !(left == right);
    }

    #endregion
  }

  /// <summary> A concrete implementation of a Book media listing </summary>
  public class Book : MediaListing
  {
    public const string CONTENT_TYPE = "Book";

    public Book() : base(CONTENT_TYPE) { }
  }

  /// <summary> A concrete implementation of a Movie media listing</summary>
  public class Movie : MediaListing
  {
    public const string CONTENT_TYPE = "Movie";

    public Movie() : base(CONTENT_TYPE) { }
  }
}
