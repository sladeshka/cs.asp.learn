﻿namespace WebMVCR1.Models
{
    public class PersonRepository
    {
        private List<Person> persons = new List<Person>();
        public int NumberOfPerson { get { return persons.Count(); } }
        public IEnumerable<Person> GetAllResponses { get { return persons; } }
        public void AddResponse(Person person) { persons.Add(person); }
    }
}
