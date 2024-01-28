string[] animals = ["Cat", "Dog", "Fish", "Bird", "other"];

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
		case 2:
			animalID = "3";
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
	Console.WriteLine("2. Pick your animal type");
	Console.WriteLine("3. What is your animal's name?");
	Console.WriteLine("4. How old is your animal?");
	Console.WriteLine("5. What is the color(s) of your animal?");
	Console.WriteLine("6. What does your animal like to do?");
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
				if (yourAnimal[i,0] != "ID #: "){ 
				Console.WriteLine(yourAnimal[i, 0]);
				for ( int j = 0; j < 6; j++); 
				}
			}
			Console.WriteLine("Press Enter to continue."); 
			readResults = Console.ReadLine(); 
			break;
		case "2":
			Console.WriteLine("Errorss");
			readResults = Console.ReadLine();
			Console.WriteLine("Press Enter to continue."); 
			break;
		case "3":
			Console.WriteLine("Error");
			readResults = Console.ReadLine();
			Console.WriteLine("Press Enter to continue."); 
			break;
		case "4":
			Console.WriteLine("Error");
			Console.WriteLine("Press Enter to continue."); 
			readResults = Console.ReadLine();
			break;
		case "5":
			Console.WriteLine("Error");
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




