using System;

namespace OpenAi.Api
{
    public enum EEngineName
    {
        gpt_neo_20b,
        gpt_j_6b,
        gpt_neo_2_7b,
        gpt_neo_1_3b,
        gpt_neo_125m,
        fairseq_13b,
        fairseq_6_7b,
        fairseq_2_7b,
        fairseq_1_3b,
        fairseq_125m
    }

    public static class UTEEngineName
    {
        public static string GetEngineName(EEngineName name)
        {
            switch (name)
            {
                case EEngineName.gpt_neo_20b:
                    return UTEngineNames.gpt_neo_20b;
                case EEngineName.gpt_j_6b:
                    return UTEngineNames.gpt_j_6b;
                case EEngineName.gpt_neo_2_7b:
                    return UTEngineNames.gpt_neo_2_7b;
                case EEngineName.gpt_neo_1_3b:
                    return UTEngineNames.gpt_neo_1_3b;
                case EEngineName.gpt_neo_125m:
                    return UTEngineNames.gpt_neo_125m;
                case EEngineName.fairseq_13b:
                    return UTEngineNames.fairseq_13b;
                case EEngineName.fairseq_6_7b:
                    return UTEngineNames.fairseq_6_7b;
                case EEngineName.fairseq_2_7b:
                    return UTEngineNames.fairseq_2_7b;
                case EEngineName.fairseq_1_3b:
                    return UTEngineNames.fairseq_1_3b;
                case EEngineName.fairseq_125m:
                    return UTEngineNames.fairseq_125m;
            }

            throw new ArgumentException($"Invalid enum value provided when getting engine name. Value provided: {name}");
        }
    }
}