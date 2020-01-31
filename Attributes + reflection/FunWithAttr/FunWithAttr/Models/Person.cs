namespace FunWithAttr.Models
{
    public class Person
    {
        public Person()
        {

        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Sex = (UserSex)1;
        }

        public Person(string firstName, string lastName, UserSex sex)
        {
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
        }

        private string PrivateProperty { set; get; } = "test";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserSex Sex { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Sex.ToString()}";
        }
    }
}