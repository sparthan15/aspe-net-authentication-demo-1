## Video
https://www.youtube.com/watch?v=lEI9kKJaMRo&list=PLFJQnCcZXWjuHP03Kgf46FrX5L2fRzDsx&index=2

### Issues
when errors using Add-Migration: 
a connection was successfully established with the server, but then an error occurred during the login process. (provider: ssl provider, error: 0 - the certificate chain was issued by an authority that is not trusted.)
Búsqueda con cámara
Then please add Encrypt=false to the DefaultConnection string
https://stackoverflow.com/questions/17615260/the-certificate-chain-was-issued-by-an-authority-that-is-not-trusted-when-conn

In order to make things works, the AspNetIdentityDemo.Share was created as Class Library(Universal..)

- It was not able to reference the library for some issues, one is that the Shared libraries to be referenced
in the UWP was needed to be Library(Universal), not a .NET standar library, so that it could not be
referenced in .Api due to incompatibilities issue. So, it was needed to duplicate the request/response objects
into a Dtos folder

- remove un-necessary dependencies
https://learn.microsoft.com/en-us/visualstudio/ide/reference/remove-unused-references?view=vs-2022