using System;

namespace AccessModifiers_Properties
{
    public class Person
    {
        //auto-implemented properties - go to the top
        public string Name { get; set; } //using "prop" shortcut
        public string Username { get; set; }    
        public DateTime BirthDate {get; private set;} //auto creates private field and implement get/set methods

        public Person(DateTime birthdate, string name, string username)
        {
            BirthDate = birthdate;
            
            if(!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(username))
            {
                Name = name;
                Username = username;
            }
            
        }
        
        //calculated property - bottom
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                return timeSpan.Days / 365;                
            }
        }
    }
}
