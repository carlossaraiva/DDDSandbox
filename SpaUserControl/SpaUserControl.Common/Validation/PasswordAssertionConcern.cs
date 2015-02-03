﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SpaUserControl.Common.Validation
{
    public class PasswordAssertionConcern
    {
        public static void AssertIsValid(string password)
        {
            AssertionConcern.AssertArgumentNotNull(password, "");
        }

        public static string Encrypt(string password)
        {
            password += "|2d331cca-f6c0-40c0-bb43-6e32989c2881";
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] data = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(password));
            System.Text.StringBuilder sbString = new System.Text.StringBuilder();
            foreach (byte t in data)
            {
                sbString.Append(t.ToString("x2"));
            }
            return sbString.ToString();
        }

    }
}