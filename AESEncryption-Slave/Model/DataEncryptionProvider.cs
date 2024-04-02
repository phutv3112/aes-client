using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AESEncryptionSlave.Model
{
    internal class DataEncryptionProvider
    {
        public string StringEncryptOrDecrypt { get; set; }
        public double DecrypEncryptTime { get; set; }

        public DataEncryptionProvider(string stringEncryptOrDecrypt, double decrypEncryptTime)
        {
            StringEncryptOrDecrypt = stringEncryptOrDecrypt;
            DecrypEncryptTime = decrypEncryptTime;
        }
    }
}
