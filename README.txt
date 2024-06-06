
Anjali Nayak
2024-05-16
1335 UCT 

MvcMovies Site
Its just a practice tutorial followed using "https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-7.0&tabs=visual-studio"

1340 UCT
PART 1 
I have test the site just after creating 

1345 UCT
PART 2
New controller is added as "HelloWorld.cs"
In this controller it defines functionalities:

1.Index - This is the default action method for controller also known as user requests the root URL of application.
Default Welcome Message: When user visit the main page of the website "https://localhost:7203/ it shows messege " Welcome"

2.Message on specific URL - This action method is called when a user requests the URL 
When user visit a specific URL "https://localhost:7203/HelloWorld" it shows a different message " This is my default action.."

3..Message on specific URL - This action method is called when a user requests the URL 
When user visit a specific URL "https://localhost:7203/HelloWorld/Welcome "it shows a different message "This is the welcome action method..."

3.In this third action method HtmlEncoder.Default.Encode($"Hello {name: {ID}")"  URL segment matched the route parameter id.
The Welcome method contains a parameter id that matched the URL template in the MapControllerRoute method.


2024-05-23
1301 UCT
part 3

1.views: I created one folder (helloworld) .

2.In HelloWorld folder i add one index file.

3.Index.- This is the default action method for controller also known as user requests the root URL of application.
Default  Message: When user visit the main page of the website "https://localhost:7203/HelloWorld"it shows messege " Hello from our View Template!"
As well as i added one image from the root sourse by creating a folder .

4.Layout - In this file i changed the title and change the action to the privacy.
When user visit a specific URL:"https://localhost:7203/Home/Privacy" it will display the message:Use this page to detail your site's privacy policy"


5.Passing data from the controller to view:In HelloWorldController.cs,Ichange the Welcome method to add a Message and NumTimes value to the ViewData dictionary.Then it will
automatically maps the named parameters name and numTimes from the query string to parameters in the method."https://localhost:7203/HelloWorld/Welcome?name=Rick&numtimes=4"
It will display the welcome messsage with hello Rick .

6.I added one class in model and create a Movie.cs file.The Movie class contains an Id field,A unique number for each movie used as the primary key in the database.
It will display only date.

7.In the movie app link I added class as well as database context class in the controller.
and examine the code .
I  install NuGet Package Manager and console it by Package Manager Console .



2024-05-23
1329 UCT
part 4

1329UCT
MoviesController.cs -I created in  MoviesController.c query string such as ?searchString=3 idiots to the URL.
The filtered movies are displayed.

Part 5
 
 1425 UTC
 I Check the data is available in SQL Server Express LocalDB
 And here found data of the movies which I add through the Index code

 1435 UTC
 After that I Add SeedData on the Model Folder replacing with code
 
 1443
added seed initializer and  Open link with  https://localhost:7125/Movies

 Part 6
 
 In this section I Edited  the movies link 
 1450


2024-05-30
1440 UTC

 Part 7
 
In these part i updated the index  MoviesController.cs
The var movies in _context.Movie creates the LINQ query and I changed all parameter to ID and changes all the occurences of searchstring.
I updated  commands .
ch information.
I added the command to add search by genre.
Again i updated the Index.cshtml file for adding search by genre to index view.
I examined by running it.



1455 UCT
I create a form into Views/Movies/Index.cshtml file, and add the <form> and added the new field 
for the Title.

 PART 8
1500 UCT
Index.- This is the default action method for controller also known as user requests the root URL of application.I update the index method by adding search string.
When user visit the main page of the website "https://localhost:7203/"it shows the title of movies.
As well as i added the new rating field.

1510 UCT
create -I added the form group and intelliSense help to update the fields.here IntelliSense works with Tag Helpers.

1520 UCT
I update the package manager by ading migration rating and upadating database.

1550 UCT
Movies.cs - I added the Rating into the movie class to check the rating .



2024-06-06
1429 UCT

I created a github account.
I push and pull  the mvcmovie file into the github.
successfully created the new Repositorie.

1521 UCT 
I edited the seedData.ca and added new movies into the file .
After that I deleted all the data from the running application and run it again it shows new added movies.


