using BigNumbersAdder.Entities;

namespace BigNumbersAdder.Services
{
    public interface IBigWholeNumberAdderService
    {
        string Add(BigWholeNumber a, BigWholeNumber b);
    }
}