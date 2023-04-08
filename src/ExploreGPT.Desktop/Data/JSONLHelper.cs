using System;
using System.Text.Json;
using System.Xml;

namespace ExploreGPT.Data
{

    public static class JSONLHelper
    {
        public static string ToJSON(this object obj)
        {
            return JsonSerializer.Serialize(obj, new JsonSerializerOptions() { WriteIndented = true });
        }


    }


}

