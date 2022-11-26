using System.Collections.Generic;

namespace GentlmenBot
{
    public class Question
    {
        public string Name { get; set; }
        public string Answer { get; set; }
        public string[] Tags { get; set; }

        public Question(string name, string answer, params string[] tags)
        {
            Name = name;
            Answer = answer;
            Tags = tags;    
        }
    }
    public static class Answers
    {
        public static List<Question> Questions { get; set; }
        static Answers () 
        {
            Questions = new List<Question>();
            Questions.Add(new Question("What type of certifications does Amadris cover?", 
                "https://amdaris.sharepoint.com/:x:/r/_layouts/15/Doc.aspx?sourcedoc=%7BF2369EEE-9F5A-47C6-95D3-3A812B22C382%7D&file=Certifications%202020%20(5).xlsx&action=default&mobileredirect=true&DefaultItemOpen=1", 
                "cover","certificate","type"));
            Questions.Add(new Question("What are the courses Amdaris covers?",
                "asp.net core, java, java, english cources",
                ""));
            Questions.Add(new Question("What is the % of money Amdaris coversfor certification?",
                "50%",
                ""));
            Questions.Add(new Question("What is the % of money Amdaris cover for courses?",
                "50%",
                ""));
            Questions.Add(new Question("I need to attend a funeral,whom should Iannounce about this? Doesthe business providesome additional days for this kind of event?",
                "Tell your delivery lead",
                ""));
            Questions.Add(new Question("What is the notice period for annual leave?",
                "2 weaks",
                ""));
            Questions.Add(new Question("What expenses are covered whenthe business trips?",
                "Business (or corporate) travel insurance covers different risks an employee might face during a business trip. The primary categories of coverage include trip cancellation, medical expenses, evacuation, and luggage or other personal loss.",
                ""));
            Questions.Add(new Question("Where can Igeta branded T-shirt/ other merch?",
                "Ask HR",
                ""));
            Questions.Add(new Question("Dowe have any branded notepads/pens/umbrella?",
                "We have notepads, pens, umbrella",
                ""));
        }

        public static string GetPublicHolidays(string region)
        {
            return region switch
            {
                "Ua" => PublicHolidays.Ua,
                "Romania" => PublicHolidays.Romania,
                "Moldova" => PublicHolidays.Moldova,
                "Britain" => PublicHolidays.Britain,
                "Bolgaria" => PublicHolidays.Bolgaria,
                _ => "Unknown"
            };
        }
    }
}
