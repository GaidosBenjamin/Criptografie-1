using System;
using System.Linq;

namespace Criptografie_1 {

    class SubstitutionCipher : AlgoritmSimetric {

        public override string encryption(string text, string key)
        {
            string newAlphabet = createAlphabet(key);
            return cripting(text, alphabet, newAlphabet);
        }

        public override string decryption(string text, string key)
        {
            string newAlphabet = createAlphabet(key);
            return cripting(text, newAlphabet, alphabet);
        }

        private string cripting(string text, string alphabet, string newAlphabet) {
            string newText = "";
            foreach(char ch in text) {
                bool isUpper = isAlphabetUpper(ch);
                var index = alphabet.IndexOf(Char.ToLower(ch));
                if(index == -1) {
                    newText += ch;
                }
                else {
                    if(isUpper) {
                        newText += Char.ToUpper(newAlphabet[index]);
                    }
                    else {
                        newText += newAlphabet[index];
                    }
                }
            }
            return newText;
        }

        private bool isAlphabetUpper(Char ch) {
            if(Char.ToLower(ch) != ch && alphabet.IndexOf(Char.ToLower(ch)) != -1) {
                return true;
            }
            return false;
        }

        private string removeDuplicates(string key) {
            return new string(key.Distinct().ToArray());
        }

        private string createAlphabet(string key) {
            string newAlphabet = removeDuplicates(key);
            foreach(char ch in alphabet) {
                if(newAlphabet.IndexOf(ch) == -1) {
                    newAlphabet += ch;
                }
            }
            return newAlphabet; 
        }
    }
}