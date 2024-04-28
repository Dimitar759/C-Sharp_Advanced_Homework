namespace Class_9_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"C:\Users\dimit\OneDrive\Documents\GitHub\C-Sharp_Advanced_Homework\Homework5";
            // Folder name
            string folderName = "Files";
            // File name
            string fileName = "names.txt";

            try
            {
                // Combine folder path with folder name to get the full folder path
                string fullFolderPath = Path.Combine(folderPath, folderName);

                // Combine full folder path with file name to get the full file path
                string filePath = Path.Combine(fullFolderPath, fileName);

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Read the existing names from the file
                    string[] existingNames = File.ReadAllLines(filePath);

                    // Display the existing names
                    Console.WriteLine("Existing names:");
                    foreach (string name in existingNames)
                    {
                        Console.WriteLine(name);
                    }

                    // Ask the user to enter new names
                    Console.WriteLine("\nEnter new names (one per line). Enter 'done' when finished:");

                    // Create a list to store the new names
                    var newNames = new List<string>();

                    // Read names from the user until they enter 'done'
                    string input;
                    while ((input = Console.ReadLine()) != "done")
                    {
                        newNames.Add(input);
                    }

                    // Append the new names to the file
                    File.AppendAllLines(filePath, newNames);

                    Console.WriteLine("Names added successfully.");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"An error occurred: {exception.Message}");
            }


            try
            {
                string fullFolderPath = Path.Combine(folderPath, folderName);
                string filePath = Path.Combine(fullFolderPath, fileName);

                if (File.Exists(filePath))
                {
                    string[] existingNames = File.ReadAllLines(filePath);

                    // Go through each letter of the alphabet
                    for (char letter = 'A'; letter <= 'Z'; letter++)
                    {
                        // Filter names starting with the current letter using LINQ
                        var filteredNames = existingNames.Where(name => name.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase));

                        // If there are filtered names, create a new file for them
                        if (filteredNames.Any())
                        {
                            string filteredFileName = $"namesStartingWith_{letter}.txt";
                            string filteredFilePath = Path.Combine(fullFolderPath, filteredFileName);
                            File.WriteAllLines(filteredFilePath, filteredNames);
                            Console.WriteLine($"File '{filteredFileName}' created successfully.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"An error occurred: {exception.Message}");
            }
        }
    }
}
