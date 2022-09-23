using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace PhigrosSauceFinder
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class At
    {
        public double level { get; set; }
        public int notes { get; set; }
    }

    public class Ez
    {
        public double level { get; set; }
        public int notes { get; set; }
    }

    public class Hd
    {
        public double level { get; set; }
        public int notes { get; set; }
    }

    public class In
    {
        public double level { get; set; }
        public int notes { get; set; }
    }

    public class Legacy
    {
        public double level { get; set; }
        public int notes { get; set; }
    }

    public class Root
    {
        public Ez ez { get; set; }
        public Hd hd { get; set; }
        public In @in { get; set; }
        public Legacy legacy { get; set; }
        public At at { get; set; }
        public Sp sp { get; set; }
    }

    public class Sp
    {
        public double level { get; set; }
        public int notes { get; set; }
    }

    public static class ImOutOfNameIdeas
    {
        public static void RecurseDeserialize(Dictionary<string, object> result)
        {
            //Iterate throgh key/value pairs
            foreach (var keyValuePair in result.ToArray())
            {
                //Check to see if Newtonsoft thinks this is a JArray
                var jarray = keyValuePair.Value as JArray;

                if (jarray != null)
                {
                    //We have a JArray

                    //Convert JArray back to json and deserialize to a list of dictionaries
                    var dictionaries = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jarray.ToString());

                    //Set the result as the dictionary
                    result[keyValuePair.Key] = dictionaries;

                    //Iterate throught the dictionaries
                    foreach (var dictionary in dictionaries)
                    {
                        //Recurse
                        RecurseDeserialize(dictionary);
                    }
                }
            }
        }
    }
}
