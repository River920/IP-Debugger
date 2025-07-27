using System.IO;
//Hello(especially to seb :)))
///////////////////////
///////////////////////

Directory.CreateDirectory("ECODES");
File.WriteAllText(@"ECODES\E_CODES.db", "0 - Success\n1 - General Error\n(0) Database Created Successfully UTC: " + DateTime.UtcNow + "\n\n\n\n");

///////////////////////
///////////////////////

Console.WriteLine("(0)");
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
    
    File.AppendAllText(@"ECODES\E_CODES.db", "(0) IP-Debug y/n Valid Input " + Start_ID1 + "\n");
}
else if (Start_ID1 == "n")
{
    Console.WriteLine("(0)");
    
    File.AppendAllText(@"ECODES\E_CODES.db", "(0) IP-Debug y/n Soft Exit\n");
    Thread.Sleep(1500);
    Environment.Exit(0);
}
else
{
    Console.WriteLine("(1)");
    
    File.AppendAllText(@"ECODES\E_CODES.db", "(1) IP-Debug y/n Invalid Input " + Start_ID1 + "\n");
    Thread.Sleep(1500);
    
    File.AppendAllText(@"ECODES\E_CODES.db", "(0) IP-Debug y/n Soft Exit\n");
    Environment.Exit(0);
}

///////////////////////
///////////////////////

Thread.Sleep(2000);

Console.WriteLine("(0)");

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

File.AppendAllText(@"ECODES\E_CODES.db", "(0) Waiting for input on IP type\n");
Console.WriteLine("(0)");
Console.WriteLine("Enter the IP type that you want to connect to:\nIPv4 > X.X.X.X < X = 0-255\nIPv6 > XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX:XXXX < X = 0-9/A-F");
var ID_IP = Console.ReadLine();