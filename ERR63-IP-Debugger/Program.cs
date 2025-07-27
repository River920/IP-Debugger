//usings go here
using System.IO;

//log db area
Directory.CreateDirectory("ECODES");
File.WriteAllText(@"ECODES\E_CODES.db", "0 - Success\n1 - General Error\n(0) Database Created Successfully UTC: " + DateTime.UtcNow + "\n\n\n\n");



//log db area

///////////////////////
///////////////////////

Console.WriteLine("(0)");
//log
File.AppendAllText(@"ECODES\E_CODES.db", "(0) Application Running\n");
Thread.Sleep(2000);

///////////////////////
///////////////////////

Console.WriteLine("Welcome to ERR63, Start IP-Debug? \n y/n...");
string Start_ID1 = Console.ReadLine();

///////////////////////
///////////////////////

if (Start_ID1 == "y")
{
    //log
    File.AppendAllText(@"ECODES\E_CODES.db", "(0) IP-Debug y/n Valid Input " + Start_ID1 + "\n");
}
else if (Start_ID1 == "n")
{
    Console.WriteLine("(0)");
    //log
    File.AppendAllText(@"ECODES\E_CODES.db", "(0) IP-Debug y/n Soft Exit\n");
    Thread.Sleep(1500);
    Environment.Exit(0);
}
else
{
    Console.WriteLine("(1)");
    //log
    File.AppendAllText(@"ECODES\E_CODES.db", "(1) IP-Debug y/n Invalid Input " + Start_ID1 + "\n");
    Thread.Sleep(1500);
    //log
    File.AppendAllText(@"ECODES\E_CODES.db", "(0) IP-Debug y/n Soft Exit\n");
    Environment.Exit(0);
}

///////////////////////
///////////////////////

Thread.Sleep(2000);

Console.WriteLine("(0)");
//log
File.AppendAllText(@"ECODES\E_CODES.db", "(0) IP-Debug On\n");
Console.ForegroundColor = ConsoleColor.Red;

///////////////////////
///////////////////////

Console.WriteLine("### WARNING ### \n!!YOU ARE ENTER THE DANGER ZONE!!");
Thread.Sleep(2000);

///////////////////////
///////////////////////

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("COUNTINUING PROCESS...");
Thread.Sleep(1000);

///////////////////////
///////////////////////

Console.ForegroundColor = ConsoleColor.White;
//log
File.AppendAllText(@"ECODES\E_CODES.db", "(0) Waiting for input on IP type\n");
Console.WriteLine("(0)");
Console.WriteLine("Enter the IP type that you want to connect to:\n1 > Device IP < IPv4 > 123.456.7.89\n2 > Server IP < IPv4 > 1.2.3.4\n3 > Network IP < IPv4 > 123.456.7.8");
var ID_IP = Console.ReadLine();