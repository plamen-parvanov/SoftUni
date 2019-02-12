namespace _03.Mankind.Factories
{
    using _03.Mankind.Models;

    public abstract class WorkerFactory
    {
        public static Worker CreateWorker(string[] workerInfoArr)
        {
            var firstName = workerInfoArr[0];
            var lastName = workerInfoArr[1];
            var weekSalary = decimal.Parse(workerInfoArr[2]);
            var workingHoursPerDay = decimal.Parse(workerInfoArr[3]);

            return new Worker(firstName, lastName, weekSalary, workingHoursPerDay);
        }
    }
}
