namespace AnimalCentre.Models.Procedures
{
    using Validators;
    using Animals;
    using Contracts;

    public class Play : Procedure
    {
        private const int PLAY_HAPPYNESS_INCREASE = 12;
        private const int PLAY_CARE_ENERGY_DECREASE = 6;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            Validator.IsProcedureTimeEnough(animal.ProcedureTime, procedureTime);

            var currentAnimal = animal as Animal;

            currentAnimal.Happiness += PLAY_HAPPYNESS_INCREASE;
            currentAnimal.Energy -= PLAY_CARE_ENERGY_DECREASE;
            currentAnimal.ProcedureTime -= procedureTime;
            base.ProcedureHistory.Add(animal);
        }
    }
}
