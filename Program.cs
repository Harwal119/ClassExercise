// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//  30.Write a C# program to check two given integers and return true if one is negative and one is positive
// Console.WriteLine("Enter d first number");
// int num1 = int.Parse(Console.ReadLine());
// if(num1 > 0)
// {
//     Console.WriteLine("it is a positive number");
// }
// else
// {
//     Console.WriteLine("it is a negative number");
// }


// 29.Write a program that prints on the console the numbers from 1 to 50, 
// which are not divisible by 3 and 7 simultaneously.
// Console.Write("Enter a number:");
// int x = int.Parse(Console.ReadLine());
// for(int i = 1 ;i <= 50;i++)
// {
//     if(x % (3*7)== 0)
//     {
//         Console.WriteLine("they are divisible");
//     }
//     else
//     {
//         Console.WriteLine("they are not divisible");
//     }
// }

// 1. Write a program to count how many numbers between 1 and 100 are divisible 
// by 3 with no remainder. Display the count on the console
// Console.Write("Enter a number:");
// int num = int.Parse(Console.ReadLine());
// for(int i = 1;i < 100; i++)
// {
//     if(num % (3) == 0)
//     {
//         Console.WriteLine("They are divisible by three");
//     }
//     else
//     {
//         Console.WriteLine("they are not divisibl");
//     }
// }

// 20. Write a program that finds the smallest of three integers, using if statements.
// Console.Write("Enter the first number:");
// int firstNum = int.Parse(Console.ReadLine());
// Console.Write("Enter the second number:");
// int secondNum = int.Parse(Console.ReadLine());
// Console.Write("Enter the third number:");
// int thirdNum = int.Parse(Console.ReadLine());
// if(firstNum < secondNum && firstNum < thirdNum)
// {
//     Console.WriteLine("firstNum is smallest number");
// }
// if(secondNum < thirdNum && secondNum < firstNum)
// {
//     Console.WriteLine("secondNum is smallest number");
// }
// if(thirdNum < firstNum && thirdNum < secondNum)
// {
//     Console.WriteLine("thirdNum is smallest number");
// }

// 24.Write a program that prints on the console the numbers from 1 to N. 
// The number N should be read from the standard input.
// Console.Write("Enter a N number:");
// int n = int.Parse(Console.ReadLine());
// for(int i = 1; i <= n; i++)
// {
//     Console.Write(i + " ");
// }

// 26.Write a program that prints out the sequence -10, -4, 2, 8, 14, 20.
// for(int i = -10;i <= 20; i+=6)
// {
//     Console.Write(i + " ");
// }
// 27.Write a program that prints out the sequence 49, 40, 31, 22, 13, 4.
// for(int i = 4; i <= 49;i+=9)
// {
//     Console.Write(i + " ");
// }
// 28.Write a program that prints out the cube of all numbers between 1 and 10
// for(int i = 1; i<= 10;i +=3)
// {
//     Console.Write(i + " ");
// }
// 2. Write a program and ask the user to enter a number. Compute the factorial of 
// the number and print it on the console. For example, if the user enters 5, the 
// program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
// Console.Write("n = ");
// int n = int.Parse(Console.ReadLine());
// int factorial = 1;
// do
// {
// factorial *= n;
// n--;
// } while (n > 0);
// Console.WriteLine("n! = " + factorial);

// 4. Write a program which takes two numbers from the console and displays the maximum of the two.
// Console.Write("Enter the first number:");
// double num = double.Parse(Console.ReadLine());
// Console.Write("Enter another number:");
// double num2 = double.Parse(Console.ReadLine());
// double x = Math.Max( num,num2);
// Console.WriteLine("the biggest number is "+ x);

// 21. Write a program that asks for a digit (0-9), and depending on the input, 
// shows the digit as a word (in English)

// Console.Write("Enter a number between 0 and 9");
// int num = int.Parse(Console.ReadLine());
// switch(num)
// {
//       case 1:
//       Console.WriteLine("one");
//       break;
//       case 2:
//       Console.WriteLine("two");
//       break;
//       case 3:
//       Console.WriteLine("three");
//       break;
//       case 4:
//       Console.WriteLine("four");
//       break;
//       case 5:
//       Console.WriteLine("five");
//       break;
//       case 6:
//       Console.WriteLine("six");
//       break;
//       case 7:
//       Console.WriteLine("seven");
//       break;
//       case 8:
//       Console.WriteLine("eight");
//       break;
//       case 9:
//       Console.WriteLine("nine");
//       break;
//       default:
//       Console.WriteLine("Invalid number");
//       break;
// }

// 22. Write a program that applies bonus points to given scores in the range 
// [1…9] by the following rules:
// - If the score is between 1 and 3, the program multiplies it by 10.
// - If the score is between 4 and 6, the program multiplies it by 100.
// - If the score is between 7 and 9, the program multiplies it by 1000.
// - If the score is 0 or more than 9, the program prints an error 
// message.
// Console.WriteLine("Enter any nunber between 0 and 9");
// int kum = int.Parse(Console.ReadLine());

// switch(kum)
// {
//       case 1:
//     case 2:
//     case 3:
//     Console.WriteLine("the bonus score " + (kum * 10));
//     break;
//     case 4:
//     case 5:
//     case 6:
//     Console.WriteLine("the bonus score " + (kum * 100));
//     break;
//     case 7:
//     case 8:
//     case 9:
//     Console.WriteLine("the bonus score " + (kum * 1000));
//     break;
//     default:
//     Console.WriteLine("Invalid number");
//     break;

// }

  
// 8. Write a C# program to print multiple of 7 from 1 to 1000. Prints one number per line.
// for(int i = 7; i <= 1000; i+=7)
// {
//     Console.Write(i + " ");
// }

// 9. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying 
// and dividing of two numbers which will be entered by the user. Create a method for each 
// operation.
// static int Add(int a, int b)
// {
//     return a+ b;
// }

// static int Subtraction(int a, int b)
// {
//     return a - b;
// }

// static int Multiplication(int a, int b)
// {
//     return a * b;
// }



// 10. (Convert Celsius to Fahrenheit) Write a program that reads a Celsius degree in a
// double value from the console, then converts it to Fahrenheit and displays the
// result. The formula for the conversion is as follows:
// fahrenheit = (9 / 5) * celsius + 32
// Console.WriteLine("Enter a number to calculate  Celcius:");
// double celcius = double.Parse(Console.ReadLine());
// double fahrenheit = (9 / 5) * celcius + 32;
// Console.WriteLine(fahrenheit);

// 12.(Convert feet into meters) Write a program that reads a number in feet, converts it
// to meters, and displays the result. One foot is 0.305 meter
// Console.WriteLine("Enter a number for feet:");
// int feet = int.Parse(Console.ReadLine());
// int meter = 


// 17. (Physics: acceleration) Average acceleration is defined as the change of velocity
// divided by the time taken to make the change, as shown in the following formula:
// Write a program that prompts the user to enter the starting velocity in
// meters/second, the ending velocity in meters/second, and the time span t in
// seconds, and displays the average acceleration.
// Console.WriteLine("Enter the starting velocity: ");
// double velocity = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter the Ending velocity: ");
// double velocityEnd = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter the time span: ");
// double timeSpan = double.Parse(Console.ReadLine());
// double averageAcceleration = 


// 11. (Compute the volume of a cylinder) Write a program that reads in the radius and
// length of a cylinder and computes the area and volume using the following formulas:
// area = radius * radius pie
// volume = area * length
// Console.Write("Enter the radius of a cylinder:");
// double radius = double.Parse(Console.ReadLine());
// Console.Write("Enter the radius pie of a cylinder:");
// double radiusPie = double.Parse(Console.ReadLine());
// Console.Write("Enter the length of a cylinder:");
// double length = double.Parse(Console.ReadLine());
// double area = radius * radiusPie;
// Console.WriteLine("the area is " + area);
// double volume = area * length;
// Console.WriteLine("the volume is " + volume);





// 3. Write a program and ask the user to enter a number. The number should be 
// between 1 to 10. If the user enters a valid number, display "Valid" on the console. 
// Otherwise, display "Invalid". (This logic is used a lot in applications where values 
// entered into input boxes need to be validated.)
// Console.Write("Enter a number:");
// int num = int.Parse(Console.ReadLine());
// if(num >= 1 && num <= 10)
// {
//     Console.WriteLine("Valid");
// }
// else{
//     Console.WriteLine("Invalid");
// }



// 5. Write a program and ask the user to enter the width and height of an image. Then tell if the 
// image is landscape or portrait.if width is bigeer than hieght that landscape
// Console.Write("Enter your choice for Wigth:");
// int width = int.Parse(Console.ReadLine());
// Console.Write("Enter your choice for height:");
// int height = int.Parse(Console.ReadLine());
// if(width > height)
// {
//     Console.WriteLine("This   image is Landscape ");
// }
// else
// {
//     Console.WriteLine("the image is portrate ");
// }

// 6. Your job is to write a program for a speed camera. For simplicity, ignore the details such as 
// camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the 
// speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than 
// the speed limit, program should display Ok on the console. If the value is above the speed limit, 
// the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 
// 1 demerit points should be incurred and displayed on the console. If the number of demerit points is 
// above 12, the program should display License Suspended.
// Console.WriteLine("Enter a speed of a camera:");
// int speed = int.Parse(Console.ReadLine());
// if(speed == speed)
// {
//     Console.WriteLine("Ok");
// }
// else
// {

// }

// 25.Write a program that prints on the console multiples of 5 less than
// 1000 (i.e 5,10, 15......995)

// for(int i = 5; i < 1000;i+=5)
// {
//     Console.Write(i + " ");
// }

// 7. (Compute the perimeter of a triangle) Write a program that reads three edges for a
// triangle and computes the perimeter if the input is valid. Otherwise, display that
// the input is invalid. The input is valid if the sum of every pair of two edges is
// greater than the remaining edge.
// Console.WriteLine("Enter the first edge:");
// int edge1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter the second edge:");
// int edge2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter the third edge:");
// int edge3 = int.Parse(Console.ReadLine());
// if()
// {
//     Console.WriteLine()
// }




