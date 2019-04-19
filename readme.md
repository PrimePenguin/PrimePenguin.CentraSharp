#  PrimePenguin.CentraSharp: A .NET library for CentraWeb.

[![NuGet](https://img.shields.io/nuget/v/PrimePenguin.CentraSharp.svg?maxAge=3600)](https://www.nuget.org/packages/PrimePenguin.CentraSharp/)
[![Build status](https://ci.appveyor.com/api/projects/status/xcepplviqd92aepp/branch/master?svg=true)](https://ci.appveyor.com/project/souravthakur1992/primepenguin-centrasharp/branch/master)
[![license](https://img.shields.io/github/license/mashape/apistatus.svg?maxAge=3600)](https://raw.githubusercontent.com/PrimePenguin/PrimePenguin.CentraSharp/master/LICENSE)

PrimePenguin.CentraSharp is a .NET library that enables you to authenticate and make API calls to Starweb. It's great for 
building custom Centra Apps using C# and .NET. You can quickly and easily get up and running with CentraWeb
using this library.

# Installation

```
Install-Package PrimePenguin.CentraSharp
```

If you're using .NET Core, you can use the `dotnet` command from your favorite shell:

```
dotnet add package PrimePenguin.CentraSharp
```

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
