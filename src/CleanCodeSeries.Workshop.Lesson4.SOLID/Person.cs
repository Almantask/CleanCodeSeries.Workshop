/*
 * Randomly generated soldier go to war
 * They shoot at each other and get promotoed
 * Soldier->Leutenant->Commander
 * The moment a soldier reaches Commander rank, war is over.
 * And all soldiers dismiss.
 * Else, they shoot again.
 */
namespace CleanCodeSeries.Workshop.Lesson4.EasyOOP
{
    public class Person
    {
        public string Name { get; }
        public int Age { get; }
        public float Weight { set; get; }
        public float Height { set; get; }

        public Person(string name, int age, float weight, float height)
        {
            Name = name;
            Age = age;
            Height = weight;
            Weight = height;
        }
    }
}
