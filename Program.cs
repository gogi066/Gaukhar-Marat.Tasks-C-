Console.WriteLine("Name of product:");
string nameOfProduct = Console.ReadLine();

Console.WriteLine("Amount:");
int amount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Price of product:");
double unitPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Discount in percent:");
int discountRate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Delivery ? (true/false):");
bool expressDelivery = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("Distance in km:");
double deliveryKm = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Card or Cash:");
string paymentType = Console.ReadLine();

double baseTotal = amount * unitPrice;
double discountSum = baseTotal * discountRate / 100;
double finalTotal = baseTotal - discountSum + deliveryKm;

Console.WriteLine($"Without discount: {baseTotal}");
Console.WriteLine($"Discount: {discountSum}");
Console.WriteLine($"Total Price: {finalTotal}");