using System.Collections;
using System.Runtime.Serialization;

string[] animals = new string[4];

animals[0] = "cat";
animals[1] = "dog";
animals[2] = "fish";
animals[3] = "other";

string animalID = "";
string animalType = "";
string animalName = "";
string animalAge = "";
string animalColor = "";
string animalHobby = "";

int maxPets = 5;
string? readResults;
string menuSelection = "";

string[,] yourAnimal = new string[maxPets, 6];

for (int i = 0; i < maxPets; i++)
{


	switch (i)

	{
		case 0:
			animalID = "1";
			animalType = "";
			animalName = "";
			animalAge = "";
			animalColor = "";
			animalHobby = "";
			break;

		case 1:
			animalID = "2";
			animalType = "";
			animalName = "";
			animalAge = "";
			animalColor = "";
			animalHobby = "";
			break;
		case 3:
			animalID = "";
			animalType = "";
			animalName = "";
			animalAge = "";
			animalColor = "";
			animalHobby = "";
			break;
		case 4:
			animalID = "";
			animalType = "";
			animalName = "";
			animalAge = "";
			animalColor = "";
			animalHobby = "";
			break;
		default:
			animalID = "4";
			animalType = "Cat";
			animalName = "Kitty";
			animalAge = "12";
			animalColor = "Brown";
			animalHobby = "Sleep";
			break;

	}

	yourAnimal[i, 0] = "ID #: " + animalID;
	yourAnimal[i, 1] = "Type:" + animalType;
	yourAnimal[i, 2] = "Name:" + animalName;
	yourAnimal[i, 3] = "Age:" + animalAge;
	yourAnimal[i, 4] = "Color:" + animalColor;
	yourAnimal[i, 5] = "Hobby:" + animalHobby;
}






do
{

	Console.Clear();
	Console.WriteLine("Tell us about your animal");
	Console.WriteLine("1. See all Animals");
	Console.WriteLine("2. Add another animal");
	// Console.WriteLine("2. Pick your animal type");
	// Console.WriteLine("3. What is your animal's name?");
	// Console.WriteLine("4. How old is your animal?");
	// Console.WriteLine("5. What is the color(s) of your animal?");
	// Console.WriteLine("6. What does your animal like to do?");
	Console.WriteLine("Type 'Exit to end console");

	readResults = Console.ReadLine();


	if (readResults != null)
	{
		menuSelection = readResults.ToLower();
	}
	switch (menuSelection)
	{
		case "1":
			for (int i = 0; i < maxPets; i++)
			{
				if (yourAnimal[i, 0] != "ID #: ")
				{
					Console.WriteLine(yourAnimal[i, 0]);
					for (int j = 0; j < 6; j++) ;
				}
			}
			Console.WriteLine("Press Enter to continue.");
			readResults = Console.ReadLine();
			break;
		case "2":
			string createPet = "y";
			int petCount = 0;
			for (int i = 0; i < maxPets; i++)

			{
				// checks the number of pets 
				if (yourAnimal[i, 0] != "ID #: ")
				{
					petCount += 1;
				}
			}


			if (petCount < maxPets)
			{
				Console.WriteLine($"We have {petCount} on file. We can add {(maxPets - petCount)}");

			}
			while (createPet == "y" && petCount < maxPets)

				/// Picks Animal Type
				do
				{
					Console.WriteLine("Pick your animal:");


						for (int i = 0; i < animals.Length; i++)
						{
							Console.WriteLine($"{i + 1}." + animals[i]);
						}
					
						readResults = Console.ReadLine();
						if (readResults != null)
						{
							int.TryParse(readResults, out int UserChoice);

							if (UserChoice >= 1 && UserChoice <= 3)
							{
								animalType = animals[UserChoice - 1];
							}
							else if (UserChoice == 4)
							{
								Console.WriteLine("Enter an animal:"); 
								readResults = Console.ReadLine(); 
								if (readResults != null) { 
									animalType = readResults; 
								}
								
							}				
							else Console.WriteLine("Not a valid selection. Press Enter to try again.");  
							
					}
						Console.WriteLine($"You Select {animalType}, Press Enter to continue.");
						readResults = Console.ReadLine();	

				} while (animalType == "");


			/// assigns animal ID once type of animal is picked
			animalID = animalType.Substring(0, 1) + (petCount + 1).ToString();

		do { 
			Console.WriteLine("What is the name of your animal?"); 
			readResults = Console.ReadLine(); 

			if (readResults != null) { 
				animalName = readResults; 
			} 

		} while (animalName == ""); 


			yourAnimal[petCount, 0] = "ID #: " + animalID;
			yourAnimal[petCount, 1] = "Type: " + animalType;
			yourAnimal[petCount, 5] = "Name: " + animalName;
			yourAnimal[petCount, 2] = "Age: " + animalAge;
			yourAnimal[petCount, 4] = "Color: " + animalColor;
			yourAnimal[petCount, 3] = "Hobby: " + animalHobby;


			petCount = petCount + 1;

			if (petCount >= maxPets)
			{
				Console.WriteLine($"Sorry, we cannot add anymore pets. They are {(petCount - maxPets)}");
				readResults = Console.ReadLine();

			}


			Console.WriteLine("Press Enter to continue.");
			readResults = Console.ReadLine();
			break;



		default:
			Console.WriteLine("Default Error");
			Console.WriteLine("Press Enter to continue.");
			readResults = Console.ReadLine();
			break;
	}

} while (menuSelection != "exit");
