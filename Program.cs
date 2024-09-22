using DesafioPOO.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Telefone Nokia");
        Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo1", imei: "114353rjdgjd", memoria: 134);
        nokia.Ligar();
        nokia.InstalarAplicativo("Whatsapp");

        Console.WriteLine("Telefone Iphone");
        Smartphone iphone = new Iphone(numero: "86865040", modelo: "X PRO", imei: "DIAFOLFSOFNS", memoria: 14);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Tiktok");
    }
}
