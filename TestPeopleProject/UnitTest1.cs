using System.Globalization;
using PeopleProject;
using NUnit.Framework;

namespace TestPeopleProject
{
    [TestFixture]
    public class Tests
    {

        [TestCase]
        public void AvgAgeTest()
        {
            PeopleProject.PersonStatistics peeps = new PersonStatistics();
            List<Person> yes = new List<Person>();
            yes.Add(new Person(0, "Bence", 27, false, 11));
            yes.Add(new Person(1, "gamer", 12, true, 100));
            yes.Add(new Person(1, "Jayce from Arcane", 23, true, 68));
            peeps.People = yes;

            Assert.That(peeps.GetAverageAge() == yes.Average(e => e.Age));
        }

        [Test]
        public void NumOfStudentsTest()
        {
            PeopleProject.PersonStatistics peeps = new PersonStatistics();
            List<Person> yes = new List<Person>();
            yes.Add(new Person(0, "Bence", 27, false, 11));
            yes.Add(new Person(1, "gamer", 12, true, 100));
            yes.Add(new Person(1, "Jayce from Arcane", 23, true, 68));
            peeps.People = yes;

            Assert.That(peeps.GetNumberOfStudents() == 3);
        }

        [Test]
        public void HighestScoreTest()
        {
            PeopleProject.PersonStatistics peeps = new PersonStatistics();
            List<Person> yes = new List<Person>();
            yes.Add(new Person(0, "Bence", 27, false, 11));
            yes.Add(new Person(1, "gamer", 12, true, 100));
            yes.Add(new Person(1, "Jayce from Arcane", 23, true, 68));
            peeps.People = yes;

            Assert.That(peeps.GetPersonWithHighestScore() == yes.OrderByDescending(e => e.Score).First());
        }

        [Test]
        public void AvgScoreTest()
        {
            PeopleProject.PersonStatistics peeps = new PersonStatistics();
            List<Person> yes = new List<Person>();
            yes.Add(new Person(0, "Bence", 27, false, 11));
            yes.Add(new Person(1, "gamer", 12, true, 100));
            yes.Add(new Person(1, "Jayce from Arcane", 23, true, 68));
            peeps.People = yes;

            Assert.That(peeps.GetAverageScoreOfStudents() == yes.Average(e => e.Score));
        }

        [Test]
        public void OldestStudentTest()
        {
            PeopleProject.PersonStatistics peeps = new PersonStatistics();
            List<Person> yes = new List<Person>();
            yes.Add(new Person(0, "Bence", 27, false, 11));
            yes.Add(new Person(1, "gamer", 12, true, 100));
            yes.Add(new Person(1, "Jayce from Arcane", 23, true, 68));
            peeps.People = yes;

            Assert.That(peeps.GetOldestStudent() == yes.OrderByDescending(e => e.Age).First());
        }

        [Test]
        public void FailTest()
        {
            PersonStatistics peeps = new PersonStatistics();
            List<Person> yes = new List<Person>();
            yes.Add(new Person(0, "Bence", 27, false, 11));
            yes.Add(new Person(1, "gamer", 12, true, 100));
            yes.Add(new Person(1, "Jayce from Arcane", 23, true, 68));
            peeps.People = yes;

            Assert.That(peeps.IsAnyoneFailing() == true);
        }
    }
}