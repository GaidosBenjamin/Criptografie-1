using System;

namespace Criptografie_1 {
    abstract class AlgoritmSimetric {
        private static string alphabet = "abcdefghijklmnopqrstuvwxyz";
        public abstract string encryption(string text, string key);

        public abstract string decryption(string text, string key);

        protected static string ceasarEncryption(string text, string key) {
            string newText = "";
            foreach (char ch in text) {
                if(alphabet.IndexOf(Char.ToLower(ch)) != -1) {
                    if(alphabet.IndexOf(Char.ToLower(ch)) >= alphabet.Length - Int32.Parse(key)) {
                        newText +=(char)(ch - ('z' - 'a' + 1) + Int32.Parse(key));
                    }
                    else {
                        newText += (char)(ch + Int32.Parse(key));
                    }
                }
                else {
                    newText += ch;
                }
            }
            return newText;
        }

        protected static string ceasarDecryption(string text, string key) {
            string newText = "";
            foreach(char ch in text) {
                if(alphabet.IndexOf(Char.ToLower(ch)) != -1) {
                    if(alphabet.IndexOf(Char.ToLower(ch)) < Int32.Parse(key)) {
                        newText += (char)(ch + ('z' - 'a' + 1) - Int32.Parse(key));
                    }
                    else {
                        newText += (char)(ch - Int32.Parse(key));
                    }
                }
                else {
                    newText += ch;
                }
            }
            return newText;
        }
    }
}