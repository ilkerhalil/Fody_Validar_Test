using System;

namespace Fody_Validar_Test
{
    class Program
    {
        static void Main()
        {
            var webRequest = new WebRequest
            {
                Name = string.Empty,
                SurName = string.Empty
                ,EMail = ""
                ,IpAddress = ""
                ,PhoneNumber = ""
            };
            Console.WriteLine((webRequest as System.ComponentModel.IDataErrorInfo).Error);
            Console.ReadKey();
        }
    }
}
