namespace Course.Entities {
    class OrdinaryPerson : Person {

        public override double Bonus() {
            return Amount * 0.1;
        }
    }
}
