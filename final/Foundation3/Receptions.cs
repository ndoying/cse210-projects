using System;

public class Receptions : Events
{
    //Define the Receptions class properties
    private string _email;
    
    //Getters and Setters
    public string GetEmail()
    {
        return _email;
    }
    public void SetEmail(string email)
    {
        _email = email;
    }
    //Override method for specific FullMessage details
    public override string GetSpecificDetails()
    {
        string details = $"Please RSVP by sending an email to: {GetEmail()}";
        return details;
    }

}