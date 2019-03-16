namespace AnimalCentre.Models.Procedures
{
    using Animals;
    using Contracts;
    using Validators;

    public class Vaccinate : Procedure
    {
        private const int VACCINATE_ENERGY_DECREASE = 8;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            Validator.IsProcedureTimeEnough(animal.ProcedureTime, procedureTime);

            var currentAnimal = animal as Animal;

            currentAnimal.Energy -= VACCINATE_ENERGY_DECREASE;
            currentAnimal.IsVaccinated = true;
            currentAnimal.ProcedureTime -= procedureTime;
            base.ProcedureHistory.Add(animal);
        }
    }
}
