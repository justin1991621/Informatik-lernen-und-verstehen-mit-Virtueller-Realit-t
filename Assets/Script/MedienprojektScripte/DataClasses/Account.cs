using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Account : MonoBehaviour
{
    //Data class for account
    //Saves data for the account of the player

    public string AccountName = "";
    public string EmailAddress = "";
    public string Password = "";

    public string GetAccountName()
    {
        return this.AccountName;
    }

    public void SetAccountName(string AccountName)
    {
        this.AccountName = AccountName;
    }

    public string GetEmailAddress()
    {
        return this.EmailAddress;
    }

    public void SetEmailAddress(string EmailAddress)
    {
        this.EmailAddress = EmailAddress;
    }

    public string GetPassword()
    {
        return this.Password;
    }

    public void SetPassword(string Password)
    {
        this.Password = Password;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
