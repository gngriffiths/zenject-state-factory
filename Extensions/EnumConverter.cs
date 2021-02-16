using System;

namespace app.extension
{
    public class EnumConverter
    {
        public TEnum GetEnumStringEnumType<TEnum>(string newState) where TEnum : struct
        {
            TEnum resultInputType = default;
            bool enumParseResult = false;

            while (!enumParseResult)
            {
                enumParseResult = Enum.TryParse(newState, true, out resultInputType);
            }
            return resultInputType;
        }
    }
}