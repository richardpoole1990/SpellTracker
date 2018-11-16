# SpellTracker
DND 5e spell viewer and preparation tool. Reads from JSON found at: https://github.com/vorpalhex/srd_spells
Application can be run inside of Visual Studio by hitting Ctrl f5 with the solution open. Easiest way to display a spell would be to search Fireball. Currently, application is case sensitive. Saves spells that were searched to Documents folder under file name PreparedSpells.txt. Type quit to exit program.

Find a dataset of your choosing that your application will read from. 
This data can cover any topic and there are many free datasets available
 online. Here are several places to find some datasets: Google Dataset Search, Data.gov CSV's and a big list of JSON data -Reads from JSON file
 
You must use Object Oriented Programming principles and data structures to model your data in the following manner:


You must create a Class that models all or, more likely, a subset of your data
You must create at least two instances of that class, each representing a separate piece of data.
You must populate the variables of those objects from your dataset
An example of what this might look like: You decide to use United 
States Census Data on Cities. Your Class represents a city with several 
variables (ex: name, population, elevation). An object of this class 
would populate those with specific values (Louisville, 615316, 444). - I have the class Spells, which has Description, Spell Level, and Class on it


Your application must persist (write) data to a file, database, or other external location.


One method of doing this will be provided in the form of a "Data 
Layer" created by one of the mentors. This will be a separate 
project/DLL you can include in your project that will allow you to make 
method calls to and it will persist and retrieve data for you. Using 
this Data Layer is not a requirement but is encouraged
You may instead write your own method of writing data to an external file
Storing only "in memory" is not acceptable - there must be a way for the data to persist to the next run of the application



Your application must persist (write) data to a file, database, or other external location.


One method of doing this will be provided in the form of a "Data 
Layer" created by one of the mentors. This will be a separate 
project/DLL you can include in your project that will allow you to make 
method calls to and it will persist and retrieve data for you. Using 
this Data Layer is not a requirement but is encouraged
You may instead write your own method of writing data to an external file
Storing only "in memory" is not acceptable - there must be a way for the data to persist to the next run of the application

Your application must allow the user to view or manipulate this data in 
some manner. The most direct way to do this would be a console-based 
menu where the user selects from available data to view. For example, 
they view a list of cities, select Louisville, and the above Louisville 
object is used to populate the data that is displayed.

Searching for spell names will display the spell information in the command prompt window, as well as create a PreparedSpells.txt under the Documents folder.

Your code has comments


It must include a README file located at the top level directory of your project providing the following:


A brief description of your project’s purpose.  Example: "A library 
of US City data, populated from the US Census Data." Try to think of 
what would be useful to a potential employer that is looking at your 
GitHub account without any context or background about Code Louisville 
or your project.
Instructions on any special requirements to run your project.  If 
your project can be executed by opening the solution in Visual Studio 
and clicking Run, that is sufficient.  If you require any configurations
 to your connection string, environment dependencies, or special 
instruction to run it, you must include details on how to do so. - Done

Your project code is on your GitHub account in its own repository -Done

Have fun!  Your project should be something you're proud of, and that 
adequately demonstrates your base knowledge in the concepts you've 
learned. - Done
