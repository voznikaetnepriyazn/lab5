namespace lab5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Good good = new Good();
            try
            {
                good.Price = -1;
            }
            catch (PriceLessZeroExseption e)
            {
                Console.WriteLine("Цена не может быть отрицательной");
                good.Price = 0;
            }
            catch (Exception e)
            {
                Console.WriteLine("unknown error");
            }
            finally
            {
                Console.WriteLine($"Цена - {good.Price}");
            }
        }
    }
}