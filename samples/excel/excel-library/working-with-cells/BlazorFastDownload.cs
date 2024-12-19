using System.Runtime.InteropServices.JavaScript;

namespace Infragistics.Samples
{
    public partial class BlazorFastDownload
    {
        [JSImport("BlazorDownloadFileFast", "BlazorFastDownload")]
        internal static partial void DownloadFile(string name, string contentType, byte[] content);

    }
}
