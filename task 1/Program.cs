Console.WriteLine("Name of product:");
string productName = Console.ReadLine();

Console.WriteLine("Amount:");
int amount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Price of product:");
double price = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Discount in percent:");
int discountPercent = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Delivery ? (true/false):");
bool isDelivery = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("Distance in km:");
double distance = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Card or Cash:");
string paymentMethod = Console.ReadLine();

double withoutDiscount = amount * price;
double discountAmount = withoutDiscount * discountPercent / 100;
double totalPrice = withoutDiscount - discountAmount + distance;

Console.WriteLine($"Without discount: {withoutDiscount}");
Console.WriteLine($"Discount: {discountAmount}");
Console.WriteLine($"Total Price: {totalPrice}");
