# Remote-Email-Validation-in-Csharp
This repository implements remote validation to check if an email is already registered in the system using the [Remote] annotation in ASP.NET Framework. 

Implementation Steps

**1. Add Validation to the Model**
[RemoteClientServer("CheckEmailIsValid", "User", ErrorMessage = "User already taken")]
public string Email { get; set; }

**2. Create the RemoteClientServer Class**
Create a folder named Common, and inside it, add the RemoteClientServer.cs file. Make sure to change the namespace to MySite.Common

**3. Add the Method in the Controller**
In your UserController, add the method to check if the email is already registered:

public JsonResult CheckEmailIsValid(string Email)
{
    var emailExists = _userService.EmailExists(Email); // Replace with your verification service
    return Json(!emailExists);
}

This method returns true if the email is valid (not registered) and false otherwise.

**Conclusion**

With this implementation, email validation occurs automatically before form submission, ensuring the user is informed if the email is already in use. This approach improves user experience and avoids unnecessary database queries.
