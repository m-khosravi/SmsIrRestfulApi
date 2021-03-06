﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmsIrRestful;
using System.Collections.Generic;

namespace SmsIrRestfulTest
{
    [TestClass]
    public class VerificationCodeTest
    {

        public string GetToken()
        {
            string userApikey = TokenInformation.UserApikey;
            string secretKey = TokenInformation.SecretKey;

            return new Token().GetToken(userApikey, secretKey);
        }


        [TestMethod]
        public void Send()
        {
            var token = GetToken();

            if (string.IsNullOrWhiteSpace(token))
                throw new Exception($@"{nameof(token) } is null");

            var restVerificationCode = new RestVerificationCode()
            {
                Code = "1234567890",
                MobileNumber = "09120000001"
            };

            RestVerificationCodeRespone restVerificationCodeRespone = new VerificationCode().Send(token, restVerificationCode);
            
            if (restVerificationCodeRespone == null)
                throw new Exception($@"{nameof(restVerificationCodeRespone) } is null");

            if (restVerificationCodeRespone.IsSuccessful)
            {

            }
            else
            {

            }

        }

       
    }
}
