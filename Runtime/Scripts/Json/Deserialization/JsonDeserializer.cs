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
            Debug.Log(tokens);
            for (int i = 0; i < tokens.Length; i++)
            {
                Debug.Log(tokens[i]);
            }
            return JsonSyntaxAnalyzer.Parse(tokens);
        }
    }
}