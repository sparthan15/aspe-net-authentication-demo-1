## Video
https://www.youtube.com/watch?v=lEI9kKJaMRo&list=PLFJQnCcZXWjuHP03Kgf46FrX5L2fRzDsx&index=2

##Valuable lessons learned
- It happened something rare, suddenly the IIS started to fail, the endpoint didn'n get well deployed, i saw in the browser a 500.0 error. I was looking and hiting the keyboard without a solution.
Since I add the Library project(Universal window) as reference for the API project, an error was
issuing in the IDE, i completely ignored it. It turns out that, its occurred to me that, i decided to 
remove that dependency, and the error... has gone. Conclusion: WebAPI projects dont fit well with
windows libraries... 
- MOcking
https://softchris.github.io/pages/dotnet-moq.html#creating-our-first-mock

### Issues
when errors using Add-Migration: 
a connection was successfully established with the server, but then an error occurred during the login process. (provider: ssl provider, error: 0 - the certificate chain was issued by an authority that is not trusted.)
B�squeda con c�mara
Then please add Encrypt=false to the DefaultConnection string
https://stackoverflow.com/questions/17615260/the-certificate-chain-was-issued-by-an-authority-that-is-not-trusted-when-conn

In order to make things works, the AspNetIdentityDemo.Share was created as Class Library(Universal..)

- It was not able to reference the library for some issues, one is that the Shared libraries to be referenced
in the UWP was needed to be Library(Universal), not a .NET standar library, so that it could not be
referenced in .Api due to incompatibilities issue. So, it was needed to duplicate the request/response objects
into a Dtos folder

- remove un-necessary dependencies
https://learn.microsoft.com/en-us/visualstudio/ide/reference/remove-unused-references?view=vs-2022

- Onnce i pressed Build/Clean XXXXX.Api ISS started to fail...

### Others commands
sql terminal:
 sqlcmd -S DESKTOP-PKJ7OKM\SQLEXPRESS01 -E
sql express local connection string Server=localhost\SQLEXPRESS01;Database=master;Trusted_Connection=True;