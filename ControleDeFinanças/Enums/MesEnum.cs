﻿using System.Text.Json.Serialization;

namespace ControleDeFinanças.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MesEnum
    {

        Janeiro = 1,
        Fevereiro,
        Marco,
        Abril,
        Maio,
        Junho,
        Julho,
        Agosto,
        Setembro,
        Outubro,
        Novembro,
        Dezembro
    }
}
