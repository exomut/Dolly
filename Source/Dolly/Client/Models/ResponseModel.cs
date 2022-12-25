using System.ComponentModel.DataAnnotations;

namespace Dolly.Client.Models
{
    // serves as our input model
    public class Input
    {
        [Required]
        [MinLength(1)]
        public string? prompt { get; set; }
        [Required]
        [Range(1, 10)]
        public short? n { get; set; }
        [Required]
        public string? size { get; set; }
    }

    // model for the image url
    public class Link
    {
        public string? url { get; set; }
    }

    // model for the DALL E api response
    public class ResponseModel
    {
        public long created { get; set; }
        public List<Link>? data { get; set; }
    }

    public class Result
    {
        public string? Url { get; init; }
        public string? Prompt { get; init; }
    }

}
