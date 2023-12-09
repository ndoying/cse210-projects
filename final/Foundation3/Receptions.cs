using System;

public class Receptions : Events
{
    //Define the Receptions class properties
    private string _email;

    //Constructor to set the Receptions class properties
    public Receptions(string title, string description, DateTime date, string address, string type, string email) : base(title, description, date, address, type)
    {
        _email = email;
    }
    
    //Getters
    public string GetEmail()
    {
        return _email;
    }
    
    //Override method for specific FullMessage details
    public override string GetSpecificDetails()
    {
        string details = $"Please RSVP by sending an email to: {GetEmail()}";
        return details;
    }

}