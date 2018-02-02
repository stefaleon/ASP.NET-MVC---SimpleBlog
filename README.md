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



&nbsp;
## 08 The returnUrl key

* Add a string parameter to the HttpPost Login method and name it *returnUrl* since this is the name of the key in the query parameter that the framework creates on unauthorized attempts to access certain pages (such as *Users*).
* After an anauthorized attempt to navigate to the *Users* page, on successful admin login (that is if username is *asdf*), the user will be redirected to the page defined by *returnUrl* (the *Users* page).



&nbsp;
## 09 Show Logged User and Sign Out

* Configure the *NavBar* view including a conditional that checks for authenticated users. Display links accordingly.
* Configure the *ShowLoggedUser* action in the *Home* controller and redirect to it from specific returns in *AuthController*.
* Configure the *Logout* action in *AuthController*.


&nbsp;
## 10 Add Migrations

* Add - New Item - Data - ADO.NET Entity Data Model -> *SimpleBlogModel*, Empty Code-First Model. A connection string pointing at the  *SimpleBlog.SimpleBlogModel* database is added to *Web.config*.
* Enable migrations, add initial and update database.
