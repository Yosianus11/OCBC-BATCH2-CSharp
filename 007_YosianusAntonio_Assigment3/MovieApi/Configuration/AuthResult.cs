using System.Collections.Generic;

namespace MovieApi.Configuration{
    public class AuthResult{
        public string Token { get; set; }
        public bool success { get; set; }
        public List<string> Errors{ get; set; }
    }
}