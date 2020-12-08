using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Components.Web;

using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using Infragistics.Documents.Excel;

namespace Infragistics.Samples
{
    //public static class ExcelUtility
    //{
    //    [Inject]
    //    public static IJSRuntime Runtime { get; set; }

    //    public static void SaveFile(Infragistics.Documents.Excel.Workbook workbook, string fileNameWithoutExtension)
    //    {
    //        var ms = new System.IO.MemoryStream();
    //        workbook.Save(ms);

    //        string extension;

    //        switch (workbook.CurrentFormat)
    //        {
    //            default:
    //            case WorkbookFormat.StrictOpenXml:
    //            case WorkbookFormat.Excel2007:
    //                extension = ".xlsx";
    //                break;
    //            case WorkbookFormat.Excel2007MacroEnabled:
    //                extension = ".xlsm";
    //                break;
    //            case WorkbookFormat.Excel2007MacroEnabledTemplate:
    //                extension = ".xltm";
    //                break;
    //            case WorkbookFormat.Excel2007Template:
    //                extension = ".xltx";
    //                break;

    //            case WorkbookFormat.Excel97To2003:
    //                extension = ".xls";
    //                break;
    //            case WorkbookFormat.Excel97To2003Template:
    //                extension = ".xlt";
    //                break;
    //        }

    //        string fileName = fileNameWithoutExtension + extension;
    //        string mime;

    //        switch (workbook.CurrentFormat)
    //        {
    //            default:
    //            case WorkbookFormat.Excel2007:
    //            case WorkbookFormat.Excel2007MacroEnabled:
    //            case WorkbookFormat.Excel2007MacroEnabledTemplate:
    //            case WorkbookFormat.Excel2007Template:
    //            case WorkbookFormat.StrictOpenXml:
    //                mime = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
    //                break;
    //            case WorkbookFormat.Excel97To2003:
    //            case WorkbookFormat.Excel97To2003Template:
    //                mime = "application/vnd.ms-excel";
    //                break;
    //        }

    //        ms.Position = 0;
    //        var bytes = ms.ToArray();
    //        SaveFile(bytes, fileName, mime);
    //    }

    //    public static void SaveFile(byte[] bytes, string fileName, string mime)
    //    {
    //        if (Runtime is Microsoft.JSInterop.WebAssembly.WebAssemblyJSRuntime wasmRuntime)
    //            wasmRuntime.InvokeUnmarshalled<string, string, byte[], bool>("BlazorDownloadFileFast", fileName, mime, bytes);
    //        else if (Runtime is IJSInProcessRuntime inProc)
    //            inProc.InvokeVoid("BlazorDownloadFile", fileName, mime, bytes);
    //    }
    //}
}
