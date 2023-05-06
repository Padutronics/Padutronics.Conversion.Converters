using System;

namespace Padutronics.Conversion.Converters;

public sealed class ToStringConverter<T> : IConverter<T, string>
{
    private readonly ToStringConverterOptions options;

    public ToStringConverter() :
        this(new ToStringConverterOptions())
    {
    }

    public ToStringConverter(ToStringConverterOptions options)
    {
        this.options = options;
    }

    public string Convert(T value)
    {
        return value is null
            ? options.NullString
            : value.ToString()
                ?? throw new InvalidOperationException("ToString returned null.");
    }
}