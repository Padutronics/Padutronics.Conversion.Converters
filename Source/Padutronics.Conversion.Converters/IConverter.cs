namespace Padutronics.Conversion.Converters;

public interface IConverter<in TFrom, out TTo>
{
    TTo Convert(TFrom value);
}