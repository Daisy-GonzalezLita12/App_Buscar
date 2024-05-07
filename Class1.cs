using System;
using Libreria_TecDesing;

public class Class1
{
	public Class1()
	{
        static void Main(string[] args)
        {
            string accountSid = "8AL15GAVHDAWB6FDTATAHYYZ";
            string authToken = "f8907ff6e8e59454bf416c44e82efc75";
            string twilioPhoneNumber = "+529531494222";

            SMSSender sender = new SMSSender(accountSid, authToken, twilioPhoneNumber);

            string toPhoneNumber = "+529531494222";
            string message = "Hello, this is a test message from your C# application!";

            bool result = sender.SendSMS(toPhoneNumber, message);

            if (result)
            {
                Console.WriteLine("Mensaje enviado exitosamente.");
            }
            else
            {
                Console.WriteLine("Error al enviar el mensaje.");
            }
        }
    }
}
