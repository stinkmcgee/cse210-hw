// Save - prompt-filename, store to file location
public class Save {
    private Write _write;

    public Save(Write write) {
        write = write;
    }

    // Method to save the entry to a file
    public void SaveToFile() {
        // Prompt the user for a filename and file location
        Console.Write("Enter a filename to save the entry: ");
        string filename = Console.ReadLine();
        Console.Write("Enter a file location to save the entry: ");
        string fileLocation = Console.ReadLine();

        // Create a StreamWriter object to write to the file
        // Use $ to concatenate the filename and file location
        
        using (StreamWriter sw = new StreamWriter($"{fileLocation}\\{filename}")) {
            // Write the entry and the text to the file
            sw.WriteLine(_write.GetEntry());
        }
  // Print a message indicating that the entry was saved
    string filePath = $"{fileLocation}\\{filename}";
    Console.WriteLine($"Entry saved to {filePath}.");
    
    Console.WriteLine($"{filePath}");
    }
}