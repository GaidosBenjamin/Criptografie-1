using System;

namespace Criptografie_1 {

    class ROT13Cipher : AlgoritmSimetric {

        public string encryption(string text) {
            return encryption(text, "13");
        }

        public string decryption(string text) {
            return decryption(text, "13");
        }

        public override string encryption(string text, string key) {
            return ceasarEncryption(text, key);
        }

        public override string decryption(string text, string key) {
            return ceasarDecryption(text, key);
        }
    }
}