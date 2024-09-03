namespace Introduction.WebAPI
{
    public class Dog
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string? FurColor { get; set; }
        public bool? IsTrained { get; set; }



        public Dog() { }

        public Dog(string name, DateTime birthDate, int age, string furColor)
        {
            Name = name;
            BirthDate = birthDate;
            Age = age;
            FurColor = furColor;
        }
    }
}
