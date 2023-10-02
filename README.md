# [Selenium](https://www.selenium.dev/documentation/ 'Selenium documentation') в C# с .NET

### Use Selenium WebDriver for browser automation using C# and .NET
### [Used Visual Studio Code - code editor](https://code.visualstudio.com/ 'VScode')

## Project creating and Installing packages

To start working with the project, make sure that you have the necessary packages installed. You can install them using the .NET CLI tool by running the following commands in a terminal (cmd):

```bash
mkdir SeleniumExample
cd SeleniumExample
code .
dotnet new console --framework net7.0 (tthk - net6.0)
dotnet add package Selenium.WebDriver
dotnet add package Selenium.WebDriver.ChromeDriver
dotnet add package Selenium.Support
dotnet add package SeleniumExtras.WaitHelpers
```
### if launch is blocked, then take chromedriver from the specified (example C:\Users\opilane\.cache\selenium\chromedriver\win64\117.0.5938.92\) folder and place it in the project folder 
### To launch project

```bash
dotnet run
```
