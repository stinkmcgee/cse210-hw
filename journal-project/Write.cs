// display 
public class Write{
    private Write _write;
    public Menu(Write write){
        _write = write;
    }
    public void Display(){
        string response = "";
        string[] options = {"A","S","Q"};
        while(response!="Q"){
            while (options.Contains(response))==false;{
                Console.Write("[A]dd entry:\n[S]how entrys\n[Q]uit\n\nWhat do you want to do?");
                response = Console.ReadLine() ?? String.Empty;
                response =response.ToUpper();
            }
            switch(response){
                case "Q":
                Environment.Exit(0);
                break;
                case "A":
                // give ability to use a random prompt -mc
                    // maybe if statement? -mc
                Console.WriteLine("Please enter your entry: ");
                string entry = Console.ReadLine() ?? String.Empty;
                _write.AddEntry(new Entry(entry));
                break;
                case "S":
                _write.ShowEntrys();
                break;


                public static String Write() {
		
	}

                
            }
        }
    }
}
