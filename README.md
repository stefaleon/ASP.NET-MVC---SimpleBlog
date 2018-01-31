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


&nbsp;
## 05 Return data from View with a ViewModel

* Add a route for the *login* url so that the route becomes */login* instead of */auth/login*.
* Add the *ViewModels* folder in order to bind models to the views.
* Add the *Auth* view model which includes the *AuthLogin* class.
* In *AuthController*, add an overload for the *Login* method which takes an *AuthLogin* parameter. Give it the *HttpPost* attribute.



&nbsp;
## 06 Bind the model, add Annotations and Validation

* In *Login.cshtml*, bind the *AuthLogin* model.
* Recreate the form using the framework helper methods.
* Add attributes to the *Auth* ViewModel with data annotations.
* Add framework validation with messages and summary.
* Add custom validation with additional logic to the method in the controller.



&nbsp;
## 07 Authorization

* Restrict the access to the *Users* page to admins only with an annotation in *UsersController*.
* Specify the *Forms* authentication mode type and define the role provider with roleManager in Web.config.
* Using System.Web.Security, create a persistent authentication cookie in the login method.
* Add the *Infrastructure* folder and the *RoleProvider* class.
* Implement a demo version of *GetRolesForUser* which returns the admin role when the username is *asdf*. The user session persists since a session cookie is being set at login and now the *Users* page is accessible by the *asdf* user.
