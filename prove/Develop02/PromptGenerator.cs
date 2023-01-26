using System;

public class PromptGenerator
{
    List<string> _prompt = new List<string>(){
        "What made you happy today?",
        "What would you change about your day?",
        "What are you grateful for today?",
        "Who have you talked to today?",
        "What have you learned today?",
        "Who have you helped today?",
        "Where did you go today?",
        "What you wish you had done different today?",
        "What new things you want to accomplish?",
        "How have you seen the Lords' hand in your life today?"
    };
    public string ReturnPrompt(int number)
    {
        return _prompt[number];
    }
}