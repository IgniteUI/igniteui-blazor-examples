// this file contains events handlers and templates used in the razor page



public void WebGridExportEventMultiColumnHeaders(IgbExporterEventEventArgs args)
{
	bool exportMultiHeaders = (bool)exportHeaders.GetCurrentPrimitiveValue();
    args.Detail.Options.IgnoreMultiColumnHeaders = !exportMultiHeaders;  
}
    
