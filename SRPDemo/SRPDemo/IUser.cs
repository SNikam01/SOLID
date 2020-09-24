using System;
using System.Collections.Generic;
using System.Text;

namespace SRPDemo
{
    //You can see here every interface has his one responsiblity.
    //Insted of creating one generic interface, we have created single responsiblity Interfaces here.
    interface IUser
    {
        bool LogUser(string UserId, string Password);
        bool RegisterUser(string UserId, string UserName, string Email);
        
    }
    interface IError
    {
        void LogError(string ErrorMessage);
    }
    interface IMail
    {
        bool SentMail(string Body);
    }
}
