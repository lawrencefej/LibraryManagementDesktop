namespace LMSLibrary.Models
{
    public interface IItemModel
    {
        string Author { get; set; }
        string CategoryName { get; set; }
        int CategoryID { get;  set; }
        string DateAdded { get; }
        string Description { get; set; }
        string ISBN { get; set; }
        int ItemID { get; set; }
        string ItemTypeName { get; set; }
        int ItemTypeID { get; set; }
        string Location { get; set; }
        int Quantity { get; set; }
        int Stock { get; set; }
        string Title { get; set; }
        string Year { get; set; }
    }
}