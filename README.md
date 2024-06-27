# FurnitureHub
Fully Responsive E-commerce Website for Selling Furniture
FurnitureHub: An Innovative E-Commerce Platform for Furniture

The Technologies used:
- Front-End: HTML5, CSS3, Javascript, jQuery, Ajax, Bootstrap 5.
- Backend: ASP.NET Core, ASP.NET Core MVC, Entity Framework Core, Microsoft SQL Server.

1-Dependency Injection and Repository Pattern:
-Utilized dependency injection for managing dependencies and promoting loose coupling.
-Used the repository pattern for data access, enhancing code reusability and maintainability.

2-Generic Repository Pattern:
-Implemented a generic repository pattern for data access, reducing redundancy by consolidating common data operations into a single, reusable repository.

3-Using Areas:
-Divided the large application into smaller, logical groups using Areas.
-Each Area has its own MVC structure (Models, Views, Controllers), aiding in better management of the application by separating functional aspects into distinct sections.


Features Provided:

Admins:
1-CRUD operations: allow the admins to create ,edit , delete ,view details in categories,products,users,roles and orders. 
2-Search Functionality:Enables admins to search for products, categories, and users easily.

Users:
1-Shopping Cart:
-Easy Product Addition: Users can effortlessly add products to their cart.
-Quantity Management: Users can adjust quantities, view per-item prices, subtotals, and the total price. They can also remove items and save products for later.
-Responsive Updates: The cart updates in real-time, showing the total number of items. After a purchase, the cart resets to zero.

2-Checkout:
-Order Summary:Displays a summary of the total price of products in the cart, including the shipping cost and the calculated total price.
-Cart Details:Shows each product in the cart along with the quantity of each item.
-Shop Navigation:Allows users to return to the shop to add or remove items before finalizing the purchase.

3-Shop:
- Displays all products in the store.
-Filters and Search: Allows users to filter products by category, price range, and use the search function for easy interaction.
-Pagination: Manages product listings with a limit of 9 products per page, automatically creating additional pages as needed.


4-User Interactivity :
4.1 Forget Password:
-Users can reset their password by providing their email address.
-Upon clicking the reset option, an email containing a reset link is sent to the user's inbox.
-The link directs the user to a page where they can reset their password securely.

4.2-Contact us through email 
Provided an email in the home page that by clicking on it directs the user to our email to send us any complaints , suggestions or inquiries about our products 

