# YogNatomy

Source code and presentation for YogNatomy Web application. Yognatomy is built using ASP.NET MVC 5, 
is based on an Azure SQL Server database, and is hosted in the Azure cloud at: https://yognatomy.azurewebsites.net

## In-Class Video Presentation

[![YogNatomy Video Presentation](http://img.youtube.com/vi/73zXgcp3t9Q/0.jpg)](https://youtu.be/73zXgcp3t9Q)

<a name="toc"></a>
# Table of Contents
1. [What is YogNatomy?](#introduction)
2. [Requirements](#requirements)
3. [Database Diagram](#diagram)
4. [Wireframes](#mocks)
5. [Homepage](#homepage)
6. [Poses Browse](#poses)
7. [Account Registration](#registration)
8. [Upcoming Features](#features)

<a name="introduction"></a>
## What is YogNatomy? 

*YogNatomy is an application which seeks to make Yoga practice fun, intuitive, and effective for practitioners of all skill levels.*

First and foremost, YogNatomy is a tool to aid the user in performing maintenance on their bodies.
* We all can become rundown after periods of intense physical activity, injury, or as a result of the aging process.
* If we don’t maintain our bodies correctly, they can fall into a state of disrepair.

Yoga is a form of exercise that has been used for thousands of years to correct muscular imbalances, postural deficiencies, and aid in recovery.
* Ultimately, YogNatomy brings the knowledge and power to maintain and potentially rehabilitate muscular integrity and health to anyone with a smartphone and a mat!


# Design Documentation

<a name="requirements"></a>
## Requirements 
![requiremnts 3.1](https://github.com/cadedillon/YogNatomy/blob/master/Requirements%203.1.PNG?raw=true)

![requirements 3.2 - 3.5](https://github.com/cadedillon/YogNatomy/blob/master/Requirements%203.2%20-%203.5.PNG?raw=true)

Above are the System Software Requirements, which I wrote at the end of the project's design phase. 

<a name="diagram"></a>
## Database Diagram 

![database diagram](https://github.com/cadedillon/YogNatomy/blob/master/YogNatomy%20Database%20Diagram.PNG?raw=true)

Database Diagram that would become the foundation of the SQL Server Database that YogNatomy is built upon. The tables in this diagram represent the Model Entities that I have built to read and write data to and from the database.

<a name="mocks"></a>
## Wireframe Mock Ups 

![homepagemock](https://github.com/cadedillon/YogNatomy/blob/master/YogNatomy%20Landing%20UI.png?raw=true)

Original Wireframe design for YogNatomy homepage. 

![registrationmock](https://github.com/cadedillon/YogNatomy/blob/master/User%20Registration%20Page.PNG?raw=true)

Original Wireframe design for user registration page. The tidal wave has been done away with in the live version for the sake of cohesion.

![posedetailsmock](https://github.com/cadedillon/YogNatomy/blob/master/YogNatomy%20Pose%20Information.PNG?raw=true)

Original Wireframe for the pose details page. This page has yet to be implemented other than the standard CRUD details page, but will feature dynamic image rendering and Bootstrap components.

<a name="homepage"></a>
## YogNatomy Homepage 
![homepage](https://github.com/cadedillon/YogNatomy/blob/master/YogNatomy%20Annotated%20Homepage.jpg?raw=true)

Above is the current build version of the YogNatomy landing page.

### SideBar
On the lefthand side of the screen I built a navigation sidebar using a repurposed bootstrap component. This sidebar features hover detection, and collapsible submenus for a variety of pages. At the bottom of the sidebar you can see the "Register" button and the "Log In" button. These controls are fixed, meaning that no matter how long the page is they will always be at the same relative position in the sidebar. Some of the buttons of the sidebar pass control of the application from the Home controller to other controllers, and the Portfolio button takes the user to my GitHub profile page.

### JumboTron / Image Mapping
In the JumboTron I have placed a warm welcome for the user, because it's important to be a good (web)host. The bottom portion of the JumboTron is dominated by a 500 X 500 image of the human muscular anatomy. Using a <map> html construction, I have mapped hyperlinks on to the image that will take you to Yoga exercises that will target the muscle that you clicked on. In order to get the map shapes the correct placement and dimension, I used the Google Development tools available on Google Chrome to highlight and slowly change the coordinate values. The page that the hyperlinks will take you to is actually the Index View for YogNatomy's PoseController. It filters the result via URL filtering.

<a name="poses"></a>
## YogNatomy Pose Index 
![poseindex](https://github.com/cadedillon/YogNatomy/blob/master/YogNatomy%20Annotated%20PoseIndex.jpg?raw=true)

This is the View for the Pose Controller Index method.

### How It Works
YogNatomy pulls its data from a SQL Server database that I have built and then deployed onto the Azure cloud platform. I also built the Model Classes myself, rather than taking a data first approach that would use the Entity Framework (great technology) to automatically build the models for me. However, I did use the Entity Framework to build the controllers and views for a few of my Models, this gave me a list of data from my database and Views that had some standard CRUD (create, read, update, delete) functionality. 

### Searching by Keyword and Ordering
Now that I had my basic CRUD functionality, I decided to expand upon that with some more complex operations. The column headers that I have circled in the diagram, are actually controls that will sort the data by that column value! Clicking the control more than once will alternate between ascending and descending. In an upcoming update of YogNatomy, I am going to add additional column controls, and add styling to make it more obvious that they are controls rather than standard text headings. Above the column headings, you can see the search bar control, which can be used to filter the poses index either by name of the pose, or by the muscle groups that the poses will help you target. The code works by assigning the user entered text to a string variable and searching the Name, PrimaryMuscle, and SecondaryMuscle properties to see if they contain the substring. Only if there is a match are they added to the List that the View displays.

<a name="registration"></a>
## YogNatomy Account Registration 
![accountregistration](https://github.com/cadedillon/YogNatomy/blob/master/YogNatomy%20Annotated%20AccountRegistration.jpg?raw=true)

This is the view for the Account Registration controller's create method.

### Creating a YogNatomy Account
This is the view that is returned by the "Register" button control, at the bottom of the sidebar. Here, the user can register an account on YogNatomy. In a future update, I wish to provide functionality that will allow users to track the exercises they have completed, design their own custom workouts, and share with other users (and trainers) exercises. For now, the Windows form shown above will simply take information that the user has entered, authenticate it, and then write it to the YogNatomy database.

### Authentication and Security
I have implemented Authentication on the Model Class "UserAccount" in order to place constraints on the data that the Windows Form will accept. I did this by using the System.Data.Annotations namespace. As you can see in the screen capture, the user input for the password is masked, which I accomplished by specifying the form input type as "password" in the form-group class. Right now, unfortunately, the password is just stored as plain-text in my database, but very soon I will be implementing a one-way hash function that will encrypt the user's password before it writes it to the database in order to increase security.  

<a name="features"></a>
# Upcoming Features

| Feature          | Description         | ETC               |
|:----------------:|:-------------------:|:-----------------:|
|One-way Password Hashing | I will implement a form of password hashing in order to help protect my clients in the event of a data breach. The encryption function will take the user's text password and encrypt it, so that only the encrypted version of the password will be stored in the database. | Approximately 6 hours| 
User Login | To comply with System Requirement 3.2, the user must be able to login to their created accounts. I will accomplish this by creating a windows form page in which the user can enter their username and password, which will then be ran through the hash function, and matched against the encrypted password stored in the database. If successful, the user will be able to access their account information. | Approximately 12 hours |
Pose Details Page | The pose details page, as laid out in the Wireframe section, will contain all of the information relevant to the pose being detailed. This page will include dynamic image rendering, pose description information (pulled from the database), and hyperlinks to related poses. In order to implement this feature I will need to modify the existing pose create view, pose model entity, and pose database table. | Approximately 20 hours |

**All time estimates are based on the Mythical Man Hour.**

## Thank you for taking the time to ReadMe!

[Return](#toc)
