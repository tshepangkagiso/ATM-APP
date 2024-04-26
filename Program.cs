using ATM_APP;

// Get user Details
Console.Write("Please enter your Full Names:");
string fullnames = Console.ReadLine();
Console.Write("Please create a new pin code:");
int pincode = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the value you want to deposit into your account:");
double accountvalue = Convert.ToDouble(Console.ReadLine());

// Create new User
UserRegistration Client1 = new UserRegistration( fullnames, pincode, accountvalue);


// Display user details
Console.WriteLine($"Your full name is: {Client1._FullName}");
AddSpace();
Console.WriteLine($"Your pincode is: {Client1._Pincode}");
AddSpace();
Console.WriteLine($"Your account value is: {Client1._AccountValue}");

//populating users
UserRegistration Client2 = new UserRegistration("John Blake", 2468, 3000);
UserRegistration Client3 = new UserRegistration("Blake John", 3692, 10000);
UserRegistration Client4 = new UserRegistration("Cyril Ramaphosa", 1234, 65841);
UserRegistration Client5 = new UserRegistration("Leyora Nyora", 1122, 54651);
UserRegistration Client6 = new UserRegistration("Baby Girl", 3344, 1500);
UserRegistration Client7 = new UserRegistration("Bra Yaka", 1458, 45654);

List<UserRegistration> list1 = new List<UserRegistration>
{
    Client1, Client2, Client3, Client4, Client5, Client6, Client7
};


//Login
AddSpace();

Console.Write("Enter your Full Name:");
string nameSearch = Console.ReadLine();
Console.Write("Enter your Pin");
int pincodeTry = Convert.ToInt32(Console.ReadLine());
bool login = false;


foreach (UserRegistration item in list1)
{
    if(item._FullName == nameSearch)
    {
        if(item._Pincode == pincodeTry)
        {
            Console.WriteLine("Successful Login");
            login = true;
        }
        else
        {
            Console.WriteLine("Incorrect Pincode");
            login = false; 
        }
    }
    else
    {
        Console.WriteLine("That name is not found");
        login = false;
    }
}













Console.ReadLine();
void AddSpace()
{
    Console.WriteLine("");
    Console.WriteLine("");
}


