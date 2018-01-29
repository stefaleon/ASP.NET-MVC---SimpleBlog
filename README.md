# SimpleBlog

### A .NET MVC app, based on the [Comprehensive ASP.NET MVC](https://www.udemy.com/comprehensive-aspnet-mvc/) tutorial


&nbsp;
## 00 Start project

* New ASP.NET Web Application.
* MVC, No Authentication

&nbsp;
## 01 New Routes and Controllers

* *Home* route - *PostsController* controller.
* *Login* route - *AuthController* controller.


&nbsp;
## 02 New Area

* *Admin* area.
* *UsersController* controller.


&nbsp;
## 03 Linking to Routes

* Route link syntax example from the *Posts* to the *Login* view.


&nbsp;
## 04 Return Views

* Fix the routes. Reset to MVC defaults for both *RouteConfig.cs* and *AdminAreaRegistration.cs*, no necessity for use of the namespace-containing override of *MapRoute*.
* Create views that use the *Views/Shared/_Layout.cshtml* razor file.
* *Index* view for the *Posts* controller.
* *Login* view for the *Auth* controller.
* *Index* view for the *Users* from the *Admin* area.
* Move the *Navbar* code to a partial view and add the ActionLinks for the views.
