using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Lesson_5
{
    public class TimeSpanHandler : SqlMapper.TypeHandler<TimeSpan>
    {
        public override TimeSpan Parse(object value)
            => TimeSpan.FromSeconds((long)value);

        public override void SetValue(IDbDataParameter parameter, TimeSpan value)
            => parameter.Value = value;
    }
}