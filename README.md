# YogNatomy
Source code for YogNatomy Web application. YogNatomy is an application which seeks to make Yoga 
practice fun, intuitive, and effective for practitioners of all skill levels. Yognatomy is built using ASP.NET MVC 5, 
is based on an Azure SQL Server database, and is hosted in the Azure cloud at: https://yognatomy.azurewebsites.net

## YogNatomy Homepage
![homepage](https://github.com/cadedillon/YogNatomy/blob/master/YogNatomy%20Annotated%20Homepage.jpg?raw=true)

Above is the current build version of the YogNatomy landing page.

### SideBar
On the lefthand side of the screen I built a navigation sidebar using a repurposed bootstrap component. This sidebar features hover detection, and collapsible submenus for a variety of pages. At the bottom of the sidebar you can see the "Register" button and the "Log In" button. These controls are fixed, meaning that no matter how long the page is they will always be at the same relative position in the sidebar. Some of the buttons of the sidebar pass control of the application from the Home controller to other controllers, and the Portfolio button takes the user to my GitHub profile page.

### JumboTron / Image Mapping
In the JumboTron I have placed a warm welcome for the user, because it's important to be a good (web)host. The bottom portion of the JumboTron is dominated by a 500 X 500 image of the human muscular anatomy. Using a <map> html construction, I have mapped hyperlinks on to the image that will take you to Yoga exercises that will target the muscle that you clicked on. In order to get the map shapes the correct placement and dimension, I used the Google Development tools available on Google Chrome to highlight and slowly change the coordinate values. The page that the hyperlinks will take you to is actually the Index View for YogNatomy's PoseController. It filters the result via URL filtering.
  
## YogNatomy Pose Index
![poseindex](https://github.com/cadedillon/YogNatomy/blob/master/YogNatomy%20Annotated%20PoseIndex.jpg?raw=true)

This is the View for the Pose Controller Index method.

### How It Works
YogNatomy pulls its data from a SQL Server database that I have built and then deployed onto the Azure cloud platform. I also built the Model Classes myself, rather than taking a data first approach that would use the Entity Framework (great technology) to automatically build the models for me. However, I did use the Entity Framework to build the controllers and views for a few of my Models, this gave me a list of data from my database and Views that had some standard CRUD (create, read, update, delete) functionality. 

### Searching by Keyword and Ordering
Now that I had my basic CRUD functionality, I decided to expand upon that with some more complex operations. The column headers that I have circled in the diagram, are actually controls that will sort the data by that column value! Clicking the control more than once will alternate between ascending and descending. In an upcoming update of YogNatomy, I am going to add additional column controls, and add styling to make it more obvious that they are controls rather than standard text headings. Above the column headings, you can see the search bar control, which can be used to filter the poses index either by name of the pose, or by the muscle groups that the poses will help you target. The code works by assigning the user entered text to a string variable and searching the Name, PrimaryMuscle, and SecondaryMuscle properties to see if they contain the substring. Only if there is a match are they added to the List that the View displays.
