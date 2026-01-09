# CManager

This project is a console application written in C# and is part of a course assignment.

The assignment is to build a customer management application using a service layer,
interfaces, a repository, and basic SOLID principles.


## Project description

CManager is a console application that allows the user to manage customers stored in a JSON file.

The application supports:
creating customers,
viewing all customers,
viewing a specific customer by email,
and deleting a customer by email.

The project also includes unit tests written with xUnit and uses NSubstitute for mocking.

## GUI Application (WPF with MVVM and CommunityToolkit MVVM)

In addition to the console application, I started implementing a GUI version using WPF and MVVM.

This is my first time working with WPF with MVVM using CommunityToolkit MVVM.
So I'm still exploring concepts such as ViewModels, data binding and navigation. 
The current GUI implementation helped me understand how switching ViewModels can update the UI.

Due to limited time, the GUI does not yet include full CRUD logic.
But it demonstrates navigation, input handling and event flow in WPF.

The console application fulfills all G-requirements and the GUI
is an extra step toward the VG-requirements.
