# Sophisticated Object Oriented Factory Pattern

Here we have maintainable code. To add a new OS, like the Mac OS, we just add a new class and add its registration to the factory.
To change the functionality we change the OS classes. To add new functionality, we either modify the OS classes, or extend them.
Note that there is NO ad-hoc polymorphism here except the single test for null in the factory.

Note that the OS objects have been turned into singletons, so there can be only one such object in each of these classes.
This may be desirable or not. If it is not, then the factory wouldn't return the objects in the hash table,
but would return clones of them instead.

## To run the application

This application was built on DotNet Core 3.1 and uses nothing more than just `System` references so you should be good
to run this application on Dotnet Frameworks higher than Core 3.1.1. If you're wanting to run this application on a 
different version of the DotNet framework you will need to modify or remove the `UnderstandOOP.csproj` file. 

You should be able to download or fork this repository and run the application via Visual Studio, VS Code or using a non-Microsoft tool such as JetBrains Rider.

## Runtime operations

If you would like to test out the different return messages, just adjust the which `OperationSystems` `Options`
you would like to have set during the execution of the application. 
