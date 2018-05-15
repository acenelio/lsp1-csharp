namespace Course.Entities {
    class ElderlyPerson : Person {

        public override double Bonus() {
            return Amount * 0.2;
        }
    }
}
