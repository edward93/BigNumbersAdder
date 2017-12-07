using System;
using System.Threading.Tasks;
using BigNumbersAdder.Entities;
using BigNumbersAdder.Services;

namespace BigNumbersAdder.Controller
{
    public class MainController
    {
        private readonly IBigWholeNumberAdderService _adderService;

        public MainController(IBigWholeNumberAdderService adderService)
        {
            _adderService = adderService;
        }

        public async Task Run(string[] args)
        {
            Console.WriteLine("Enter first number");
            var first = Console.ReadLine();
            Console.WriteLine("Enter second number");
            var second = Console.ReadLine();

            var firstNumber = new BigWholeNumber(first);
            var secondNumber = new BigWholeNumber(second);
            var result = _adderService.Add(firstNumber, secondNumber);

            Console.WriteLine($"Result is: {result}");
        }
    }
}