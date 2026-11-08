namespace OnlineShopOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Clients> clients = new List<Clients>();
            List<Clothes> clothes = new List<Clothes>();
            List<Order> orders = new List<Order>();

            Clients client1 = new Clients(1, "Adrian", "Alexandur Street 15", "0889294921", "adrian.tsivkaroski@gmail.com", "1234", 1500);
            clients.Add(client1);

            clothes.Add(new Clothes(1, 150, 0, 1, "Jacket"));
            clothes.Add(new Clothes(2, 60, 5, 3, "Nike T-shirt"));
            clothes.Add(new Clothes(3, 35, 0, 1, "KPOP T-shirt"));
            clothes.Add(new Clothes(4, 60, 25, 3, "SnsaWear Jeans"));

            while (true)
            {
                Console.WriteLine("Select an Account");
                foreach (Clients client in clients)
                {
                    client.PrintInfo();
                }
                Console.Write("Input the ID of the Client: ");
                int inputClientId = int.Parse(Console.ReadLine());
                if (inputClientId > clients.Count || inputClientId < 0)
                {
                    Console.WriteLine("Please input an existing ID.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Welcome, " + clients.ElementAt(inputClientId - 1));
                    foreach (Clothes clothing in clothes)
                    {
                        clothing.PrintInfo();
                    }
                    Console.Write("Input the IDs of the clothes seperated with intervals: ");
                    List<string> productsId = Console.ReadLine().Split(" ").ToList();
                    List<Clothes> pickedClothes = new List<Clothes>();
                    foreach (var id in productsId)
                    {
                        int INTID = int.Parse(id) - 1;
                        pickedClothes.Add(clothes.ElementAt(INTID));
                    }
                    orders.Add(new Order(1, inputClientId, pickedClothes, 0, 0, "Pavlova Ulica 4"));
                    orders.ElementAt(0).PrintInfo();
                    //orders.ElementAt(0).PrintInfo();
                }
            }
        }
    }
}
