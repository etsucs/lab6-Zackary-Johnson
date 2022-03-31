/**       
 *--------------------------------------------------------------------
 * 	   File name: Lab6
 * 	Project name: Homework6
 *--------------------------------------------------------------------
 * Author’s name and email:	 Zackary Johnson, johnsonza@etsu.edu				
 *          Course-Section: CSCI 1250-002
 *           Creation Date:	 3/24/22		
 * -------------------------------------------------------------------
 */

// Declaring Methods

static void ShowCharacter(string name, int num)
{
    System.Console.WriteLine(name[num-1]);
}

static double CalculateRetail(double wholesale, double markup)
{
    double percentage = markup / 100;
    double retailPrice = wholesale + (wholesale*percentage);
    return Math.Round(retailPrice,2);
}

var calculatedRetail = CalculateRetail(5.00, 35);
System.Console.WriteLine(calculatedRetail);

static void CelsiusTable()
{
    System.Console.WriteLine("Write the starting temperature: ");
    int low = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Write the stoping temperature: ");
    int max = Convert.ToInt32(Console.ReadLine());

    for(int tempF = low; tempF <= max; tempF++)
    {
        double tempC = (5.0/9.0)*(tempF-32.0);
        System.Console.WriteLine(tempC);
    }
}

static double Celsius(double tempF)
{
    return (5.0/9.0)*(tempF-32.0);
}

static bool IsPrime(int prime)
{
    if(prime <= 1) return false;
    if(prime == 2) return true;
    if(prime % 2 == 0) return false;

    for (int i = 3; i <= prime; i+=2)
    {
        if(prime % i == 0) return false;
        if(!(prime % i == 0)) return true;
    }

    return false;
}

// Calling Methods
ShowCharacter("New York", 2);

CalculateRetail(10,2);

CelsiusTable();

for(int i = 80; i <= 100; i++)
{
    System.Console.WriteLine(Celsius(i));
}

var prime = IsPrime(234);
System.Console.WriteLine($"The number 234 is prime: {prime}");