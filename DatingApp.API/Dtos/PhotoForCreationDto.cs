using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace DatingApp
{

  public class PhotoForCreationDto
  {
    public string Url { get; set; }
    public IFormFile File { get; set; }
    public string Description { get; set; }
    public DateTime DateAdded { get; set; }
    public string PublicId { get; set; }

    public PhotoForCreationDto()
    {
      DateAdded = DateTime.Now;
    }

  }


}