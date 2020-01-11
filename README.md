# 🥐VendorTracker🥐

#### _C#, .NET: Vendor Tracker, 01/10/2020_

## Description
Pierre's Bakery was satisfied with the great [console application](https://github.com/misakimichy/pierre-bakery) for his bakery. This time, he would like you to build him an MVC application to help him track the vendors that purchase baked goods from him and the orders belonging to those vendors.

## Application should have:
- Create a `Vendor` class. This class should include properties for the vendor's name, a description of the vendor, a `List` of `Orders` belonging to the vendor, and any other properties you would like to include.

- Create an `Order` class. This class should include properties for the title, the description, the price, the date, and any other properties you would like to include.

- The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming Pierre and providing him with a link to a Vendors page.

- The vendors page should contain a link to a page presenting Pierre with a form he can fill out to create a new `Vendor`. After the form is submitted, the new Vendor object should be saved into a static List and Pierre should be routed back to the homepage.

- Pierre should be able to click a `Vendor`'s name and go to a new page that will display all of that `Vendor`'s orders.

- Pierre should be provided with a link to a page presenting him with a form to create a new `Order` for a particular `Vendor`. 

- Pierre can delete a `Vendor` when he clicks the delete button. It will jump to the confirm screen for deleting. Once Pierre agrees deleting the `Vendor` and click the button, the selected vendor will be deleted from the new page.


## Installation:
1. Clone this repo:
```
$ git clone https://github.com/misakimichy/VendorTracker.Solution.git
```

2. Use the following codes:

a) Command to build the Vendor Tracker. Run this in VendorTracker directory:
```
$ dotnet build && $ dotnet run
```


b) Command for unit testing. Run this in VendorTracker.Tests directory:
```
$ dotnet restore && dotnet test
```

## Known Bugs
* No known bugs at this time.

## Support and contact details
 misaki.koonce@gmail.com

## Technologies Used
_Git, GitHub, CSS, Bootstrap, C# and ASP.NET Core MVC

## License
Copyright © 2020 under the MIT License
