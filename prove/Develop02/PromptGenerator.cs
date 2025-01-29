public class PromptGenerator{
    // list of prompts to choose from
    List<string> prompts = new List<string>
    {
        "What was the best part of my day?",
        "What was the worst part of my day?",
        "If I could go back in time, what would I want to change about today?",
        "What is something I am grateful for today?",
        "How did I help someone today?",
        "How did I see the hand of the Lord in my life today?",
        "How did I grow spiritually today?"
    };

    // method to get a random prompt
    public string GetRandomPrompt(){
        Random random = new Random(); // create a new random object to get a random number
        int index = random.Next(prompts.Count); // get a random number between 0 and the number of prompts in the list
        return prompts[index]; // return the prompt at the random number
    }
}