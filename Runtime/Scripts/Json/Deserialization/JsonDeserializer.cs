using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenAi.Json
{
    public static class JsonDeserializer
    {
        public static JsonObject FromJson(string json)
        {
            string[] tokens = JsonLexer.Lex(json);
            Debug.Log(json);
            // return tokens[-2];
            JsonObject obj = JesonSyntaxAnalyzer.Parse(tokens);
            Debug.Log(obj.ToString());
            return obj;
        }
    }
}