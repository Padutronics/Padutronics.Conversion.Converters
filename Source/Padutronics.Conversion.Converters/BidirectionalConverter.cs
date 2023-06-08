namespace Padutronics.Conversion.Converters;

public sealed class BidirectionalConverter<T1, T2> : IBidirectionalConverter<T1, T2>
{
    private readonly IConverter<T1, T2> fromConverter;
    private readonly IConverter<T2, T1> toConverter;

    public BidirectionalConverter(IConverter<T1, T2> fromConverter, IConverter<T2, T1> toConverter)
    {
        this.fromConverter = fromConverter;
        this.toConverter = toConverter;
    }

    public T2 Convert(T1 value)
    {
        return fromConverter.Convert(value);
    }

    public T1 Convert(T2 value)
    {
        return toConverter.Convert(value);
    }
}