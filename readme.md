#  PrimePenguin.CentraSharp: A .NET library for CentraWeb.


PrimePenguin.CentraSharp is a .NET library that enables you to authenticate and make API calls to Starweb. It's great for 
building custom Centra Apps using C# and .NET. You can quickly and easily get up and running with CentraWeb
using this library.

# Installation


# Using PrimePenguin.CentraSharp

**Note**: All instances of `shopAccessToken` in the examples below **do not refer to your Starweb API key**.
An access token is the token returned after authenticating and authorizing a Starweb app installation with a
real CentraWeb store.


```cs
var service = new ProductService(myCentraWebUrl, shopAccessToken);
```

# APIS Implemented
- Customer
- Order
- Product
- Shop
