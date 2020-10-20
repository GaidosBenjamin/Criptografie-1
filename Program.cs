﻿using System;

namespace Criptografie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneralizedCeasarCipher ceasarGeneralized = new GeneralizedCeasarCipher();
            CeasarCipher ceasar = new CeasarCipher();
            ROT13Cipher rot13 = new ROT13Cipher();

            string startupPath = System.IO.Directory.GetCurrentDirectory();
            var text = System.IO.File.ReadAllText(startupPath + "/input.txt");

            while(true) {
                Console.Write("1. Cifru Cezar \n2. Cifru Cezar Generalizat \n3. Cifru ROT13 (Cesar 13) \n4. Substitutie monoalfabeitca \nq. Quit \nIntroduceti optiunea: ");
                var input = Console.ReadLine();
                if(input == "q") {
                    break;
                }
                string encryptedText;
                switch(input) {
                    case "1":
                        System.IO.File.WriteAllText(startupPath + "/outputEncrypted.txt", ceasar.encryption(text));
                        encryptedText = System.IO.File.ReadAllText(startupPath + "/outputEncrypted.txt");
                        System.IO.File.WriteAllText(startupPath + "/outputDecrypted.txt", ceasar.decryption(encryptedText));
                        Console.WriteLine("\nSucces!\n");
                        break;
                    case "2":
                        Console.Write("Introduceti cheia: ");
                        var key = Console.ReadLine();
                        if(!Int32.TryParse(key, out _)) {
                            Console.WriteLine("\nCheia gresita!\n");
                            break;
                        }
                        System.IO.File.WriteAllText(startupPath + "/outputEncrypted.txt", ceasarGeneralized.encryption(text, key));
                        encryptedText = System.IO.File.ReadAllText(startupPath + "/outputEncrypted.txt");
                        System.IO.File.WriteAllText(startupPath + "/outputDecrypted.txt", ceasarGeneralized.decryption(encryptedText, key));
                        Console.WriteLine("\nSucces!\n");
                        break;
                    case "3":
                        //acelasi algoritm pentru criptare si decriptare
                        System.IO.File.WriteAllText(startupPath + "/outputEncrypted.txt", rot13.encryption(text));
                        encryptedText = System.IO.File.ReadAllText(startupPath + "/outputEncrypted.txt");
                        System.IO.File.WriteAllText(startupPath + "/outputDecrypted.txt", rot13.encryption(encryptedText));
                        Console.WriteLine("\nSucces!\n");
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Optiune gresita");
                        break;
                }
            }
        }
    }
}
