namespace AnimalCentre.Models.Procedures
{
    using Validators;
    using Contracts;
    using Animals;

    public class Chip : Procedure
    {
        private const int CHIP_HAPPYNESS_DECREASE = 5;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            Validator.IsAnimalChipped(animal);
            Validator.IsProcedureTimeEnough(animal.ProcedureTime, procedureTime);

            var currentAnimal = animal as Animal;

            currentAnimal.Happiness -= CHIP_HAPPYNESS_DECREASE;
            currentAnimal.IsChipped = true;
            currentAnimal.ProcedureTime -= procedureTime;
            base.ProcedureHistory.Add(animal);
        }
    }
}
