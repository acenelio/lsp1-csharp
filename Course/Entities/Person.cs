namespace Course.Entities {
    abstract class Person {

        public string Name { get; set; }
        public double Amount { get; set; }

        public abstract double Bonus();
    }
}
