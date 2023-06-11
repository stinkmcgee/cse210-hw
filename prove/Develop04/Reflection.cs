public class Reflection : Activity{
    // static void Main(string[] args){
    
    private string[] prompt = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"

    };
    public override void Perform(){
        Console.WriteLine("This activity will help you reflect on times in your life");
        Console.WriteLine("when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize the power you have");
        Console.WriteLine("and how you can use it in other aspects of your life.");
        Thread.Sleep(3000);
        Console.WriteLine(" ");
        Console.WriteLine("Your prompt: " + GetPrompt());
        foreach(string question in questions){
            Console.WriteLine(question);
            Console.WriteLine(" ");
            Thread.Sleep(5000);
            Console.Write("\b \b");
        }
        Console.Write("+");
        Thread.Sleep(500);
        Console.Write("\b");
        Console.Write("|");

        Console.Write("+");
        Thread.Sleep(500);
        Console.Write("\b");
        Console.Write("/");

        Console.Write("+");
        Thread.Sleep(500);
        Console.Write("\b");
        Console.Write("-");

        Console.Write("+");
        Thread.Sleep(500);
        Console.Write("\b");
        Console.Write("\\");

        Console.Write("+");
        Thread.Sleep(500);
        Console.Write("\b");
        Console.Write("|");

        Console.Write("+");
        Thread.Sleep(500);
        Console.Write("\b");
        Console.Write("/");

        Console.Write("+");
        Thread.Sleep(500);
        Console.Write("\b");
        Console.Write("-");
        
        Console.Write("+");
        Thread.Sleep(500);
        Console.Write("\b");
        Console.Write("\\");
       // Countdown(Duration);
        Console.WriteLine($"Horray! You've finished the Reflection Activity in {Duration} seconds!");
    }
    private string GetPrompt(){
        Random random = new Random();
        int index = random.Next(0, prompt.Length);
        return prompt[index];
    }
}