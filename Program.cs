namespace Exeptions.conway.david
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float myFloat = 65.4f;
            float myOtherFloat = 0.0f;
            float result = 0f;

            Random rand = new Random();
            int myInt = rand.Next(2, 30);

            try
            {
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
               Console.Write("Please enter a number other than zero.");
               myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());


                try
                {
                result = Divide(myFloat, myOtherFloat);

                }
                catch (Exception e2)
                {
                  Console.WriteLine(e2.Message);
                }
            
            }  
            finally 
            {
             Console.WriteLine("Calculations completed with a result of" + result);
            }
            
            try
            {
                CheckAge(myInt);
            } catch
            { 
             Console.WriteLine("You are not old enough be gone!");
            }




        }

        static float Divide(float X, float Y) 
        {

            if (Y == 0)
            {

             throw new DivideByZeroException();
            
            }
            else
            {
                return X / Y;
            }
        
        }

        static void CheckAge(int age) 
        { 
         if(age >= 17)
            {
                Console.WriteLine($"You are {age}, you can play mature games!");
            }
         else
            {
                throw new ArgumentException();
            }
        
        
        
        }
    }
}