﻿using System.ComponentModel;

namespace Web.Extensions;

public static class EnumExtensions
{
    public static string ObterDescricao(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());

        var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);

        return attributes.Length > 0 ? attributes[0].Description : value.ToString();
    }
}