# _hairsalon.Solution_

#### _MVC web application to manage stylists and clients_

#### By **Sage Paden**

## Technologies Used

* _MS EntityFrameworkCore v6.0.0_
* _Pomelo EntityFrameworkCore MySQL v6.0.0_
* _C#_
* _.NET v6.0_
* _MySQLWorkbench_
* _SQL Designer_
* _Git_
* _VSCode_

## Description

_This project demonstrates how to use EFCore and MySQL to create and connect database schemas to the application models. The application leverages HTML helper methods, LINQ commands, and navigation properties to enable the salon owner to add stylists and associate clients with each stylist using one-to-many relationships._

## SQL Designer Database




## Setup/Installation Requirements

**Installing MySQL Workbench**
1. Launch MySQL Workbench and click "Local Instance 3306" 
2. Select "Administration" tab and click "Data Import/Restore"
3. Click "import from self-contained file" and select "..." to navigate to the file titled "sage_paden.sql" in the top level of this project
4. Under "Default Schema to be Imported to" select the button labeled "New..." and enter a new name.
5. Click "Start Import"

**Project Set-Up**
* _Clone "hairsalon.solution“ to your desktop_
* _Navigate to "hairsalon.solution" directory_
* _Create ".gitignore" in the "hairsalon.solution" directory_
```
$ touch .gitignore
```
* _Add the three items below to your .gitignore file:_
```
obj
bin
appsettings.json
```
* _Navigate to the "HairSalon" directory_
* _create "appsettings.json" inside of the "HairSalon" directory_
```
$ touch appsettings.json
```
* _Add the following text within the file:_
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[DB_NAME];uid=[USER-ID];pwd=[USER-PW];"
  }
}
```
* _Replace DB_NAME, USER-ID, and USER-PW with your own database, ID, and password_
* _Navigate to "HairSalon" and execute command "dotnet build"_
* _To initialize and update the migrations database, type the following commands in the terminal:_
```
$ dotnet ef migrations add Initial 
$ dotnet ef database update
```
* _Add the following packages through your command line:_
```
$ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
$ dotnet tool install --global dotnet-ef --version 6.0.0
$ dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
```
* _Execute "dotnet watch run" - this should automatically open a browser to the web app_

## Known Bugs

* _No known bugs as of 08/05/23_

## License

MIT License

Copyright (c) [2023] [Sage Paden]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

_If you run into any issues or have questions, ideas or concerns, please reach out to me via email: sagepaden@gmail.com _