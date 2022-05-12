using System.IO;

const string inputFolder = @"C:\csharp-encryption-inputoutput\input\";
const string outputFolder = @"C:\csharp-encryption-inputoutput\output\";

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

// Read Input


// Do encryption stuff


// Write to output
// TEST OUTPUT //
string[] lines = { "First line", "Second line", "Third line" };

StreamWriter outputFile = new StreamWriter(Path.Combine(outputFolder, "testfile.txt"));

foreach (string line in lines) outputFile.WriteLine(line);

outputFile.Close(); // Gotta close and dispose the stream thing
outputFile.Dispose();


// Tell user to look into the output folder for their encrypted .txt file



bool TxtFileExists(string filename)
{
    if (File.Exists(inputFolder + filename + ".txt")) return true;
    else return false;
}