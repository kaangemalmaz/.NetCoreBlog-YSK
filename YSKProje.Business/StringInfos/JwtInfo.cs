﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YSKProje.Business.StringInfos
{
    public class JwtInfo
    {
        public const string Issuer = "http://localhost:60099";
        public const string Audience = "http://localhost:5000";
        public const string SecurityKey = "kaankaankaankaa1";
        public const int Expires = 40;
    }
}
