using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _77Diamonds.API.Model
{
    public class TokenResponse
    {
        public bool Success { get; set; }
        public string UserEmail { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}
