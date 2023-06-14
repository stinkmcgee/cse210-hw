public class Listing : Activity{
    //static void Main(string[] args){
    //Console.WriteLine("This activity will help you reflect on the good thing in your life");
    //Console.WriteLine("by having you list as many things as you can in a certain area.");
   // }
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"        
    };

    public override void Perform(){
        Console.WriteLine("This activity will help you reflect on the good thing in your life");
        Console.WriteLine("by having you list as many things as you can in a certain area.");
        Console.WriteLine(" ");
        Console.WriteLine("Here is your prompt: " + GetPrompt());
        Console.WriteLine("Take a few seconds to think...");
        Thread.Sleep(5000);
        Console.WriteLine("Hope that was ample time.");
        Console.WriteLine("Now it's time to list!");
        int itemCount = 0;

        while(Duration > 0){
            itemCount++;
            string item = Console.ReadLine();
            if(string.IsNullOrEmpty(item))
            break;
        }
        Console.WriteLine($"Wow, you listed {itemCount} items!");
        Console.WriteLine($"Yay! You completed the Listing Activity which took {Duration} seconds!");
    }
    private string GetPrompt(){
        Random random = new Random();
        int index = random.Next(0, prompts.Length);
        return prompts[index];
    }
}