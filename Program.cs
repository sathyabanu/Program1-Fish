namespace Dresses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BabyDressUtility baby=new BabyDressUtility();
     
            //int choice;
            bool check=false;
            while(!check) {
                Console.WriteLine("1.Add dress to cart");
                Console.WriteLine("2.Remove dress from cart");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter your choice");
                int choice=int.Parse(Console.ReadLine());
                switch(choice) {
                    case 1:
                        {
                            Console.WriteLine("Enter the dress size");
                            int Size = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the dress color");
                            string Color = (Console.ReadLine());
                            Console.WriteLine("Enter the dress brand");
                             string Brand = Console.ReadLine();
                            Console.WriteLine("Enter the dress price");
                             double Price = Convert.ToDouble(Console.ReadLine());
                            BabyDress babydress = new BabyDress(Size,Color,Brand,Price);
                            baby.AddDressToCart(babydress);
                            break;
                        }
                         
                    case 2:
                        {
                            Console.WriteLine("enter the dress brand to remove the dress from cart");
                            string brand=Console.ReadLine();
                            if (baby.RemoveDressFromCart(brand))
                            {
                                Console.WriteLine("successfully removed from the cart");
                            }
                            else
                            {
                                Console.WriteLine("dress not found in the cart");
                            }
                            break;
                            }

                    case 3:
                        {
                            check = true;
                            Console.WriteLine("Thank you");
                            break;
                        } 
                    default:
                        {
                            Console.WriteLine("invalid choice!please try again.");
                            break;
                        }
                        

                              


                        }

            }
        }
    }
}
