namespace AnimalCentre.Models.Procedures
{
    using Validators;
    using Animals;
    using Contracts;

    public class DentalCare : Procedure
    {
        private const int DENTAL_CARE_HAPPYNESS_INCREASE = 12;
        private const int DENTAL_CARE_ENERGY_INCREASE = 10;

        public override void DoService(IAnimal animal, int procedureTime)
        {
            Validator.IsProcedureTimeEnough(animal.ProcedureTime, procedureTime);

            var currentAnimal = animal as Animal;

            currentAnimal.Happiness += DENTAL_CARE_HAPPYNESS_INCREASE;
            currentAnimal.Energy += DENTAL_CARE_ENERGY_INCREASE;
            currentAnimal.ProcedureTime -= procedureTime;
            base.ProcedureHistory.Add(animal);
        }
    }
}
