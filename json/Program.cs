using System;
using System.IO;
using System.Text;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace json
{
    class Program
    {
        /// <summary>
        /// Json data acquisition using the WP REST API
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string url = "http://blog/wp-json/posts?filter[category_name]=未分類";
            var json = (new WebClient() { Encoding = Encoding.UTF8 }).DownloadString(url);
            var wordpress = JsonConvert.DeserializeObject<IList<Class1>>(json);
            string saveJson = JsonConvert.SerializeObject(wordpress, Formatting.Indented);
            File.WriteAllText(@"D:\json.json", json);
        }
    }
}
