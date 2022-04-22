using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUX.Models
{
  public enum HeaderSize
  {
    h1 = 1,
    h2,
    h3,
    h4,
    h5,
    h6
  }

  public class HeaderTagModel
  {
    public string Text { get; set; }

    public HeaderSize Size { get; set; }
  }
}
