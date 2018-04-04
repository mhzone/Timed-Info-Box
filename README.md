# Timed-Info-Box
## Also known as just plain InfoBox.
timed info box is a small .NET WPF window designed to emulate the .NET messagebox with the addition of being self closing without any user interaction. The underlying idea was to display short notifications to a user during program execution without encumbering the user further, generally used for informative notifications. However it can also be used for warnings, and even errors, although this is probably outside of the spirit as errors should be dealt with in a more "in-depth" fashion.\
The project is a small footprint class compiled into a .dll for ease of incorporation into other projects. Even though in it's current form it is rather limited in it's features it has the potential for interesting additional features, so contributers welcome!
### The Lowdown
A WPF app created in VS2017, using c#, .NET 4.5.2. No additional dependencies or plug-ins.
### Usage
Reference the dll in your project, then simply call the class like so;
```C#
InfoBox.InfoBoxWindow i = new InfoBox.InfoBoxWindow(message, delay, mode);
```
then initialize;
```C#
i.Show();
```
Important - for proper operation include the 2 ico images in the same directory as the dll, or modify the code accordingly.
#### Parameters
message - text to be displayed in box. default value = Information.\
delay - time to live for window in milliseconds. default value = 3000 (3 seconds).\
mode - false for information box, true for warning box. default value = false

A small sample program (called starter) is included to demonstrate usage.
