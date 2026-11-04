using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Modifiers
{
    public class HttpCookies
    {
        private readonly Dictionary<String, string> _dictionary;
        public DateTime Expiry { get; set; }
        public HttpCookies()
        {
            _dictionary = new Dictionary<string, string>();
        }
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
