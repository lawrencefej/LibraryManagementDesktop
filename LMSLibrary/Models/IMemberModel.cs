namespace LMSLibrary.Models
{
    public interface IMemberModel
    {
        string Address { get; set; }
        string City { get; set; }
        string DateRegistered { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int MemberID { get; set; }
        string Password { get; set; }
        string PhoneNumber { get; set; }
        string State { get; set; }
        string StatusName { get; set; }
        string Zipcode { get; set; }
    }
}