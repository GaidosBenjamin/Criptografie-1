using System;

namespace Criptografie_1 {

    class CeasarCipher : AlgoritmSimetric {

        public string encryption(string text) {
            return encryption(text, "3");
        }

        public string decryption(string text) {
            return decryption(text, "3");
        }

        public override string encryption(string text, string key) {
            return ceasarEncryption(text, key);
        }

        public override string decryption(string text, string key) {
            return ceasarDecryption(text, key);
        }
    }
}