using System.Collections.Generic;
using Course.Entities;

namespace Course.Services {
    class CalculationService {

        public double TotalBonus(List<Person> people) {
            double sum = 0.0;
            foreach (Person person in people) {
                sum += person.Bonus();
            }
            return sum;
        }
    }
}
