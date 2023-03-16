namespace Padutronics.Conversion.Converters;

public interface IBidirectionalConverter<T1, T2>
{
    T2 Convert(T1 value);
    T1 Convert(T2 value);
}