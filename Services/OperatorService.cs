using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TestePleno.Models;
using TestePleno.Repositories;


namespace TestePleno.Services
{
    class OperatorService
    {
        public Repository _repository;

        public OperatorService(Repository repository)
        {
            _repository = repository;
        }


        public Operator GetOperatorByCode(string code)
        {
            var operators = _repository.GetAll<Operator>();
            var selectedOperator = operators.FirstOrDefault(o => o.Code == code);
            return selectedOperator;
        }

        public Operator GetOperatorById(Guid id)
        {
            var selectedOperator = _repository.GetById<Operator>(id);
            return selectedOperator;
        }

        public List<Operator> GetOperators()
        {
            var operators = _repository.GetAll<Operator>();
            return operators;
        }

        public void Create(Operator insertingOperator)
        {
            _repository.Insert(insertingOperator);
        }

        public void Update(Operator updatingOperator)
        {
            _repository.Update(updatingOperator);
        }

 
    }
}
