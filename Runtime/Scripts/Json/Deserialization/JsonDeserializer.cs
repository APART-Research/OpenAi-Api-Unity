using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenAi.Json
{
    public static class JsonDeserializer
    {
        public static string FromJson(string json, bool hack = false)
        {
            string[] tokens = JsonLexer.Lex(json);
            Debug.Log(json);
            if (hack) return tokens[-2];

            JsonObject obj = JsonSyntaxAnalyzer.Parse(tokens);
            Debug.Log(obj.ToString());
            return obj.ToString();
        }
    }
}