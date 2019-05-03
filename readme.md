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

**Note**: All instances of `shopAccessToken` in the examples below **do not refer to your Centra API key**.
An access token is the token returned after authenticating and authorizing a Centra app installation with a
real CentraWeb store.

**Steps to get access token for centra**
```

Open System settings for you centra store By logging into your store

```
<div align="center">
  <img href="#" src="https://raw.githubusercontent.com/PrimePenguin/PrimePenguin.CentraSharp/master/SystemSettings.PNG?s=50&v=4">
</div>

```

Open your store to access the token

```
<div align="center">
  <img href="#" src="https://raw.githubusercontent.com/PrimePenguin/PrimePenguin.CentraSharp/master/OpenStore.PNG">
</div>

```

Open your store settings to access shop token and order token

```
<div align="center">
  <img href="#" src="https://raw.githubusercontent.com/PrimePenguin/PrimePenguin.CentraSharp/master/StoreSettings.PNG">
</div>

```

Copy your store uri and  use access token for respective type

```
<div align="center">
  <img href="#" src="https://raw.githubusercontent.com/PrimePenguin/PrimePenguin.CentraSharp/master/Copysecret.PNG">
</div>

**Note**: myCentraWebUrl will be like store url-->https://PrimePenguin.com + /api/+ URI for the API type this will be different for
 Order and Shop So Kindly use respective token and Uri as per your store settings
**Final myCentraWebUrl will be likw** : https://PrimePenguin.com/api/shop

```cs
var service = new ProductService(myCentraWebUrl, shopAccessToken);
```
# APIS Token Use-Shop API Token (Obsolete)
- ProductService
- CategoryService
- BrandService
- CampaignService

# APIS Token Use-Order API Token
- OrderService
- ReturnService
- ShipmentService
- SupplierDeliveryService
- SupplierOrderService
- CustomerService

# APIS Implemented
- Customer
- Order
- Product
- Shop
