using System;
using System.Collections.Generic;

namespace json
{    
    public class Rootobject
    {    
        public IList<Class1> Property1 { get; set; }
    }

    public class Class1
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public Author author { get; set; }
        public string content { get; set; }
        public object parent { get; set; }
        public string link { get; set; }
        public DateTime date { get; set; }
        public DateTime modified { get; set; }
        public string format { get; set; }
        public string slug { get; set; }
        public string guid { get; set; }
        public string excerpt { get; set; }
        public int menu_order { get; set; }
        public string comment_status { get; set; }
        public string ping_status { get; set; }
        public bool sticky { get; set; }
        public string date_tz { get; set; }
        public DateTime date_gmt { get; set; }
        public string modified_tz { get; set; }
        public DateTime modified_gmt { get; set; }
        public Meta1 meta { get; set; }
        public object featured_image { get; set; }
        public Terms terms { get; set; }
    }

    public class Author
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string nickname { get; set; }
        public string slug { get; set; }
        public string URL { get; set; }
        public string avatar { get; set; }
        public string description { get; set; }
        public DateTime registered { get; set; }
        public Meta meta { get; set; }
    }

    public class Meta
    {
        public Links links { get; set; }
    }

    public class Links
    {
        public string self { get; set; }
        public string archives { get; set; }
    }

    public class Meta1
    {
        public Links1 links { get; set; }
    }

    public class Links1
    {
        public string self { get; set; }
        public string author { get; set; }
        public string collection { get; set; }
        public string replies { get; set; }
        public string versionhistory { get; set; }
    }

    public class Terms
    {
        public Category[] category { get; set; }
    }

    public class Category
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string description { get; set; }
        public string taxonomy { get; set; }
        public Parent parent { get; set; }
        public int count { get; set; }
        public string link { get; set; }
        public Meta3 meta { get; set; }
    }

    public class Parent
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string description { get; set; }
        public string taxonomy { get; set; }
        public object parent { get; set; }
        public int count { get; set; }
        public string link { get; set; }
        public Meta2 meta { get; set; }
    }

    public class Meta2
    {
        public Links2 links { get; set; }
    }

    public class Links2
    {
        public string collection { get; set; }
        public string self { get; set; }
    }

    public class Meta3
    {
        public Links3 links { get; set; }
    }

    public class Links3
    {
        public string collection { get; set; }
        public string self { get; set; }
    }

}
