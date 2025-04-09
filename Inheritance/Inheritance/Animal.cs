namespace Inheritance
{
    public class Animal
    {
       public string habitat;
       public string name;
        public void Details()
        {
            
            Console.WriteLine("ENter the name of the animal");
            name= Console.ReadLine();
            Console.WriteLine("Enter the age of the animal");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the habitat");
            habitat = Console.ReadLine();
        } 
        public class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine($"{name} is barking ");
            }
        }

        public static void Run() 
        {
            Dog dog = new Dog();
            dog.Details();
            dog.Bark();
            
        }

    }
}