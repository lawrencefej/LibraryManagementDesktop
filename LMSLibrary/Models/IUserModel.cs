namespace LMSLibrary.Models
{
    public interface IUserModel
    {
        string Address1 { get; set; }
        string Address2 { get; set; }
        string City { get; set; }
        string DateRegistered { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Password { get; set; }
        string PhoneNumber { get; set; }
        int RoleID { get; set; }
        string State { get; set; }
        int StatusID { get; set; }
        int UserID { get; set; }
        string Zipcode { get; set; }
    }
}