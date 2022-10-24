using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TestePleno.Models;
using TestePleno.Services;
using TestePleno.Repositories;

namespace TestePleno.Controllers
{
    class FareController
    {
        private OperatorService _operatorService;
        private FareService FareService;
        private Repository _repository = new Repository();

        public FareController()
        {
            _operatorService = new OperatorService(_repository);
            FareService = new FareService(_repository);
        }

        public void CreateFare(Fare fare, string operatorCode)
        {
            var selectedOperator = _operatorService.GetOperatorByCode(operatorCode);
            if (selectedOperator == null)
            {
                Console.WriteLine("Não existe operadora!");
                Environment.Exit(0);
            }
            fare.OperatorId = selectedOperator.Id;

            FareService.Create(fare);
        }
    }
}
