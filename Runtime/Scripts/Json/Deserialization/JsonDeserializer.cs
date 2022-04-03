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
            return tokens[-2];
            return JsonSyntaxAnalyzer.Parse(tokens);
        }
    }
}