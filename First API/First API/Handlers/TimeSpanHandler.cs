﻿using Dapper;
using System;
using System.Data;

namespace First_API.Handlers
{
    public class TimeSpanHandler:SqlMapper.TypeHandler<TimeSpan>
    {
        public override TimeSpan Parse(object value)
            => TimeSpan.FromSeconds((int)value);

        public override void SetValue(IDbDataParameter parameter, 
                                      TimeSpan value)
            => parameter.Value = value;
    }
}