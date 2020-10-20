using System;

namespace Criptografie_1 {

    class GeneralizedCeasarCipher : AlgoritmSimetric {

        public override string encryption(string text, string key) {
            return ceasarEncryption(text, key);
        }

        public override string decryption(string text, string key) {
            return ceasarDecryption(text, key);
        }

        
    }
}