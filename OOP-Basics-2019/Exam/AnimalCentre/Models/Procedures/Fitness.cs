namespace AnimalCentre.Models.Procedures
{
    using Validators;
    using Animals;
    using Contracts;

    public class Fitness : Procedure
    {
        private const int FITNESS_HAPPYNESS_DECREASE = 3;
        private const int FITNESS_ENERGY_INCREASE = 10;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            Validator.IsProcedureTimeEnough(animal.ProcedureTime, procedureTime);

            var currentAnimal = animal as Animal;

            currentAnimal.Happiness -= FITNESS_HAPPYNESS_DECREASE;
            currentAnimal.Energy += FITNESS_ENERGY_INCREASE;
            currentAnimal.ProcedureTime -= procedureTime;
            base.ProcedureHistory.Add(animal);
        }
    }
}
