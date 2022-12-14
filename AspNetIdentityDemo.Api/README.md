## Video
https://www.youtube.com/watch?v=lEI9kKJaMRo&list=PLFJQnCcZXWjuHP03Kgf46FrX5L2fRzDsx&index=2

### Issues
when errors using Add-Migration: 
a connection was successfully established with the server, but then an error occurred during the login process. (provider: ssl provider, error: 0 - the certificate chain was issued by an authority that is not trusted.)
Búsqueda con cámara
Then please add Encrypt=false to the DefaultConnection string
https://stackoverflow.com/questions/17615260/the-certificate-chain-was-issued-by-an-authority-that-is-not-trusted-when-conn