using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TestePleno.Models;

namespace TestePleno.Repositories
{
    public class Initializer
    {
        public static List<IModel> InitializeDatabase(List<IModel> Database)
        {
            var operators = new List<Operator>() {
                new Operator{Id = Guid.NewGuid(),Code = "OP01"},
                new Operator{Id = Guid.NewGuid(),Code = "OP02"},
                new Operator{Id = Guid.NewGuid(),Code = "OP03"},
            };

            var fares = new List<Fare>() {
                new Fare{Id = Guid.NewGuid(), OperatorId= operators.ElementAt(0).Id, Status = 1, Value = 2.6m, Period = new DateTime(2022, 4, 24)},
                new Fare{Id = Guid.NewGuid(), OperatorId= operators.ElementAt(1).Id, Status = 1, Value = 2.5m, Period = new DateTime(2022, 4, 23)},
                new Fare{Id = Guid.NewGuid(), OperatorId= operators.ElementAt(2).Id, Status = 1, Value = 2.4m, Period = new DateTime(2022, 9, 23)},
            };

            Database.AddRange(operators);
            Database.AddRange(fares);
            return Database;
        }
    }
}
