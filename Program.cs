using System.IO;

Console.Title = "Encryption";

Console.WriteLine("How to use this program:");
Console.WriteLine("1| Place any .txt file you want encrypted inside the 'input' folder.");
Console.WriteLine("2| Input the name of the .txt file in this program, so [insert encryption algorithm here] will do its thing.");
Console.WriteLine("3| Once encryption is completed, you'll find an encrypted copy of your .txt file in the 'output' folder.");
Console.WriteLine();
Console.WriteLine("Please be aware that the original file in the input folder will not be deleted automatically, " +
                    "and any matching filenames in the output folder will be overridden.");
Console.WriteLine();
Console.WriteLine();

// Ask for filename
string inputFilename = "";
while (true)
{
    Console.WriteLine("Please enter the name of the .txt file in the input folder that you want to encrypt:");
    inputFilename = Console.ReadLine();
    if (inputFilename == null) continue;    // Prevent null pointer exception
    if (TxtFileExists(inputFilename)) break;   // Valid name, move on
    Console.WriteLine("Sorry, that file doesn't exist or isn't a .txt file.\n");
}

// Do encryption stuff

// Tell user to look into the output folder for their encrypted .txt file



bool TxtFileExists(string filename)
{
    string pathString = @"C:\csharp-encryption-inputoutput\input\";

    if (File.Exists(pathString + filename + ".txt")) return true;
    else return false;
}