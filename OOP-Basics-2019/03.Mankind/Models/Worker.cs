namespace _03.Mankind.Models
{
    using _03.Mankind.Errors;
    using System;
    using System.Text;

    public class Worker : Human
    {
        private const int MIN_WORK_SALARY = 10;
        private const int MIN_WORK_HOURS = 1;
        private const int MAX_WORK_HOURS = 12;
        private const int WORK_DAYS_PER_WEEK = 5;

        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
        : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                ValidateWeekSalary(value);

                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                ValidateWorkHoursPErDay(value);

                this.workHoursPerDay = value;
            }
        }

        private void ValidateWorkHoursPErDay(decimal value)
        {
            if (value < MIN_WORK_HOURS || value > MAX_WORK_HOURS)
            {
                throw new ArgumentException(
                    string.Format(ErrorMessages.InvalidWorkerArgument, nameof(this.workHoursPerDay)));
            }
        }

        private void ValidateWeekSalary(decimal value)
        {
            if (value <= MIN_WORK_SALARY)
            {
                throw new ArgumentException(
                    string.Format(ErrorMessages.InvalidWorkerArgument, nameof(this.weekSalary)));
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Week Salary: {this.WeekSalary:F2}");
            sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:F2}");
            sb.AppendLine($"Salary per hour: {CalvulateSalaryPerHour():F2}");

            return sb.ToString().TrimEnd();
        }

        private decimal CalvulateSalaryPerHour()
        {
            return this.WeekSalary / WORK_DAYS_PER_WEEK / this.WorkHoursPerDay; 
        }
    }
}
