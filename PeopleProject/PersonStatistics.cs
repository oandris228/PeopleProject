namespace PeopleProject
{
    public class PersonStatistics
    {
        private List<Person> people;

        public PersonStatistics()
        {
            this.people = new List<Person>();
        }

        public List<Person> People { set => people = value; }

        public double GetAverageAge()
        {
            return people.Average(e => e.Age);
        }

        public int GetNumberOfStudents()
        {
            return people.Count;
        }

        public Person GetPersonWithHighestScore()
        {
            return people.OrderByDescending(e => e.Score).First();
        }

        public double GetAverageScoreOfStudents()
        {
            double temp = people.Sum(e => e.Score);
            return temp / people.Count;
        }

        public Person GetOldestStudent()
        {
            return people.OrderByDescending(e => e.Age).First();
        } 

        public bool IsAnyoneFailing()
        {
            bool temp = false;
            foreach (Person person in people)
            {
                if (person.Score < 40) { temp = true; }
            }

            return temp;
        }
    }
}
