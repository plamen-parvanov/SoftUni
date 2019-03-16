namespace AnimalCentre.Models.Procedures
{
    using Validators;
    using Animals;
    using Contracts;

    public class NailTrim : Procedure
    {
        private const int NAIL_TRIM_HAPPYNESS_DECREASE = 7;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            Validator.IsProcedureTimeEnough(animal.ProcedureTime, procedureTime);

            var currentAnimal = animal as Animal;

            currentAnimal.Happiness -= NAIL_TRIM_HAPPYNESS_DECREASE;
            currentAnimal.ProcedureTime -= procedureTime;
            base.ProcedureHistory.Add(animal);
        }
    }
}
