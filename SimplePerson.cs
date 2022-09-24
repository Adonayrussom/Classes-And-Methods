using System;

namespace sess06_ClassesAndMethods
{
    /// <summary>
    /// Class that will be used to create Person objects and later inherited
    /// from to create specialised classes.
    /// </summary>
    public class SimplePerson
    {
        protected String names;
        protected String nationality;
        protected DateTime birthDate;
        protected char gender;

        public SimplePerson()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="names">Person's name as a string</param>
        /// <param name="nationality">Person's home country</param>
        /// <param name="birthDate">Person's date of birth</param>
        /// <param name="gender">Person's gender</param>
        public SimplePerson(String names, String nationality, DateTime birthDate, char gender)
        {
            this.names = names;
            this.nationality = nationality;
            this.birthDate = birthDate;
            this.gender = gender;
        }

        
        public String getNames()
        {
            return names;
        }

        
        public void setNames(String names)
        {
            this.names = names;
        }

        
        public String getNationality()
        {
            return nationality;
        }

        
        public void setNationality(String nationality)
        {
            this.nationality = nationality;
        }

        
        public DateTime getBirthDate()
        {
            return birthDate;
        }

        
        public void setBirthDate(DateTime birthDate)
        {
            this.birthDate = birthDate;
        }

        
        public char getGender()
        {
            return gender;
        }

        
        public void setGender(char gender)
        {
            this.gender = gender;
        }


        public override String ToString()
        {
            return ($"SimplePerson Details"
                    + $"\n------------------------------"
                    + $"\nNames: {this.getNames()}"
                    + $"\nDate of Birth: {this.getBirthDate()}"
                    + $"\nGender: {(this.getGender() == 'M' ? "Male" : "Female")}"
                    + $"\nNationality: {this.getNationality()}"
                    + $"\n------------------------------\n");
        }
    }
}
