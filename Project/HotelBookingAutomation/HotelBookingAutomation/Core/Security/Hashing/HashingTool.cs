﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Core.Security.Hashing
{
    public class HashingTool
    {
        public static void CreatePasswordHash(string password,out byte[]passwordHash,out byte[]passwordSalt)
        {
            using var hmac =new System.Security.Cryptography.HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using var hmac=new System.Security.Cryptography.HMACSHA512(passwordSalt);
            var hash=hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            for(int i=0;i<passwordHash.Length;i++)
            {
                if (hash[i] != passwordHash[i])
                    return false;
            }
            return true;
        } 
    }
}
