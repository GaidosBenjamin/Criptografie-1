using System;
using System.IO;

namespace Criptografie_1 {

    class Cryptanalysis {
        
        public static void ceasarAnalysis(string text) {
            GeneralizedCeasarCipher generalized = new GeneralizedCeasarCipher();

            string path = System.IO.Directory.GetCurrentDirectory() + "/outputAnalysis.txt";
            System.IO.File.WriteAllText(path, String.Empty);
            using(StreamWriter sw = File.AppendText(path)) {
                for(int i = 1; i < 26; i++) {
                    sw.WriteLine(generalized.decryption(text, i.ToString()) + "\n");
                }    
            }
        }
    }
}