﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Adopt1Dev_V2.Tools
{
    public class Security
    {
        public static byte[] HashMe(string passwordIn)
        {
            //Je transforme le password en tableau de bytes
            byte[] data = Encoding.UTF8.GetBytes(passwordIn);
            byte[] result;
            //J'instancie la classe qui permet de hasher
            SHA512 shaM = new SHA512Managed();
            //Je calcule le sha (Miaouw)
            result = shaM.ComputeHash(data);
            return result;
        }
    }
}
