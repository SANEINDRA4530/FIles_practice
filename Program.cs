// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using FIles_practice;
using System.ComponentModel;

Console.WriteLine("Enter the UserName");
string name= Console.ReadLine();
Console.WriteLine("Enter the password");
int pass_ = Convert.ToInt32(Console.ReadLine());

Login obj = new Login() { NAME = name, Password = pass_ };  //only for setting
obj.Check();

