namespace RestWithASPNET9Jorge.Data.Converter.Contract;

public interface IParser<O, D>
{
    D Parse(O origin);
    List<D> ParseList(List<O> originList);
 }
