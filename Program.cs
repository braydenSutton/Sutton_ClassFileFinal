using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.Serialization;
/*
 * Program Name: Cat Dog list
 * Programmer: Brayden Sutton
 * Date: 12/19/2022
 *
 * Description: What does your program do? This program creates 
 * cats and dogs using their Name and Breed
 */
bool isLooping = true;
List<User> users = new List<User>();
List<Cat> cats = new List<Cat>();
List<Dog> dogs = new List<Dog>();


CreateUsers();



void CreateUsers()
{
    while (isLooping)
    {

        Console.WriteLine("Enter a breed" );
        string animalName = Console.ReadLine();

        Console.WriteLine("enter a Color");
        string breed = Console.ReadLine();

        Console.WriteLine("Please enter an animal");
        Console.WriteLine("1 is Cat");
        Console.WriteLine("2 is Dog");
        string selection = Console.ReadLine();


        Console.Clear();


        if (selection == "1")
        {
            cats.Add(new Cat(animalName, breed));
            Console.WriteLine("Cat " + animalName + "color" + breed + " has been created");

        }
     

        else if (selection == "2")
        {
            dogs.Add(new Dog(animalName, breed));
            Console.WriteLine("Dog " + animalName + "color" +  breed + "has been created");
        }

        Console.WriteLine("All users:");
        foreach (User usr in users)
        {
            Console.WriteLine(usr.username);
        }
        Console.WriteLine("All Cats");
        foreach (Cat ct in cats)
        {
            Console.WriteLine("Cat"+ animalName);
        }

        }

        Console.WriteLine("All Dogs");
        foreach (Dog dg in dogs)
        {
            Console.WriteLine(dg.username);
        }


    }
