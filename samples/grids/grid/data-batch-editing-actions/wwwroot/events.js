// this file contains events handlers and templates used in the razor page



public void WebGridAddRow(IgbPropertyEditorPropertyDescriptionButtonClickEventArgs args)
{
    Console.WriteLine("test");
    //TODO
}
    

public void WebGridUndo(IgbPropertyEditorPropertyDescriptionButtonClickEventArgs args)
{
	Console.WriteLine("test");

	//TODO

	// this.grid.endEdit(true);
    // this.grid.transactions.undo();
}
    

public void WebGridRedo(IgbPropertyEditorPropertyDescriptionButtonClickEventArgs args)
{
	Console.WriteLine("test");

	//TODO

	// this.grid.endEdit(true);
    // this.grid.transactions.redo();

}
    

public void WebGridCommit(IgbPropertyEditorPropertyDescriptionButtonClickEventArgs args)
{
	Console.WriteLine("test");

	//TODO

	// this.grid.transactions.commit(this.data);
    // this.dialog.close();
}
    

public void WebGridDeleteCellTemplate(IgbGridEditEventArgs args)
{
	Console.WriteLine("TEST" + args);
    //TODO
}
    
