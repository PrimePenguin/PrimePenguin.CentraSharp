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

<div align="center">
	<a  href="https://docs.centra.com/reference/stable/index">
	 <svg width="75" height="25" viewBox="0 0 60 20" xmlns="http://www.w3.org/2000/svg"><g fill="#000" fill-rule="evenodd"><ellipse cx="2.119" cy="16.953" rx="2.041" ry="2.041"></ellipse><path d="M8.87 13.404c1.35 0 2.389-.907 2.764-1.805l1.761 1.142c-.907 1.587-2.511 2.704-4.648 2.704-2.843 0-5.433-2.259-5.433-5.555 0-3.28 2.59-5.556 5.433-5.556 2.163 0 3.75 1.143 4.63 2.73l-1.76 1.142c-.358-.907-1.379-1.805-2.748-1.805-2.154 0-3.331 1.587-3.331 3.515 0 1.927 1.177 3.488 3.331 3.488zM15.994 10.456c0 1.588 1.143 2.948 3.061 2.948 1.352 0 2.294-.689 2.625-1.587l1.901.907c-.907 1.587-2.494 2.73-4.648 2.73-2.825 0-5.224-2.26-5.224-5.556 0-3.279 2.259-5.555 5.224-5.555 2.73 0 4.98 2.163 4.98 5.433l-.236.69h-7.683v-.01zm.114-1.98h5.433c-.122-1.177-1.256-2.075-2.608-2.075-1.587 0-2.485.898-2.825 2.076zM25.177 4.57h2.041l.235.898.123.113.122-.113c.453-.689 1.587-1.142 2.494-1.142 2.73 0 4.3 1.805 4.3 4.299v6.576h-2.26V8.642c-.06-1.456-.767-2.258-2.258-2.258-1.334 0-2.45 1.081-2.494 2.398v6.436h-2.26V4.561h-.043v.009zM35.023 4.57h2.058V2.31L38.87.052h.428v4.535h2.293V6.61h-2.293v5.434c0 .689.47 1.133 1.16 1.133l1.351-.235v2.04l-1.256.236c-2.258 0-3.497-1.142-3.497-3.183V6.602h-2.058V4.56h.026v.009zM43.186 4.57h2.04l.236 1.133.122.114.122-.114c.69-.898 1.588-1.351 2.495-1.351.453 0 .689 0 1.133.235V6.61h-1.351c-1.335 0-2.451 1.082-2.495 2.399v6.2H43.23V4.58h-.044v-.01zM59.948 15.227h-2.041l-.235-.907-.123-.122-.122.122c-.689.689-1.805 1.142-2.947 1.142-2.948 0-5.433-2.259-5.433-5.555 0-3.28 2.494-5.555 5.433-5.555 1.133 0 2.258.453 2.947 1.142l.122.114.123-.114.235-.898h2.04v10.63zM54.628 6.4c-2.163 0-3.314 1.587-3.314 3.515 0 1.927 1.16 3.514 3.314 3.514 1.919 0 3.279-1.587 3.279-3.514 0-1.945-1.352-3.515-3.28-3.515z"></path></g></svg>
	</a>
</div>

# APIS Implemented 
- Customer
- Order
- Product
- Shop
