using System;
using modul8_103022300143;

class Program
{
    static void Main()
    {
        BankTransferConfig config = new BankTransferConfig();
        if(config.config.lang=="en"){
            Console.WriteLine("Please insert the amount of money to transfer:");
        }else if (config.config.lang == "id")
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer:");
        }
    }
}