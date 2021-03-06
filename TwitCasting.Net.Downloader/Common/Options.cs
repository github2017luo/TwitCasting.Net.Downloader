using CommandLine;

namespace TwitCasting.Net.Downloader.Common
{
    public class Options
    {
        [Option('o', "output", Default = "out")]
        public string FileName { get; set; }

        public string TemporaryFile { get; set; }

        [Option('u', "user", Required = true)]
        public string TwitCaster { get; set; }

        [Option('l', "live", Default = null)]
        public string LiveId { get; set; }

        [Option('r', "record", Default = false)]
        public bool IsRecording { get; set; }
    }
}