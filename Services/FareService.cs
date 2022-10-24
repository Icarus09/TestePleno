using System;
using System.Collections.Generic;
using System.Text;
using TestePleno.Models;
using System.Linq;
using TestePleno.Repositories;


namespace TestePleno.Services
{
    class FareService
    {
        private Repository _repository;

        public FareService(Repository repository)
        {
            _repository = repository;
        }

        public void Create(Fare fare)
        {
            var fares = GetFares();

            var operator_found = fares.FirstOrDefault(a => a.OperatorId == fare.OperatorId && a.Status == 1 && a.Value == fare.Value &&
            (fare.Period.Date - a.Period.Date).Days <= 182);

            if (operator_found != null)
            {
                Console.WriteLine("Tarifa não pode ser cadastrada! Já existe uma tarifa ");
                Environment.Exit(0);
            }
            fare.Status = 1;
            _repository.Insert(fare);
        }

        public void Update(Fare fare)
        {

            _repository.Update(fare);
        }

        public Fare GetFareById(Guid fareId)
        {
            var fare = _repository.GetById<Fare>(fareId);
            return fare;
        }

        public List<Fare> GetFares()
        {
            var fares = _repository.GetAll<Fare>();
            return fares;
        }
    }
}
