using System.Collections.Generic;
using System.Linq;

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

        public bool CompareTags(string[] tags)
        {
            return Tags.Where(x => tags.Where(x1 => StringUtils.CalculateSimilarity(x, x1) > 0.70).ToList().Count > 0).Any();
        }
    }
    public static class Answers
    {
        public static List<Question> Questions { get; set; }
        static Answers()
        {
            Questions = new List<Question>();
            Questions.Add(new Question("What type of certifications does Amadris cover?",
                "https://amdaris.sharepoint.com/:x:/r/_layouts/15/Doc.aspx?sourcedoc=%7BF2369EEE-9F5A-47C6-95D3-3A812B22C382%7D&file=Certifications%202020%20(5).xlsx&action=default&mobileredirect=true&DefaultItemOpen=1",
                "cover", "certificate", "type"));
            Questions.Add(new Question("What are the courses Amdaris covers?",
                "asp.net core, java, java, english cources",
                "course", "cover", "amdaris"));
            Questions.Add(new Question("What is the % of money Amdaris covers for certification?",
                "50%",
                "cover", "money", "certification", "%"));
            Questions.Add(new Question("What is the % of money Amdaris cover for courses?",
                "50%",
                "course", "cover"));
            Questions.Add(new Question("I need to attend a funeral,whom should Iannounce about this? Doesthe business providesome additional days for this kind of event?",
                "Tell your delivery lead",
                "attend", "annual", "emergency", "business", "event"));
            Questions.Add(new Question("What is the notice period for annual leave?",
                "2 weaks",
                "period", "annual", "leave", "what"));
            Questions.Add(new Question("What expenses are covered whenthe business trips?",
                "Business (or corporate) travel insurance covers different risks an employee might face during a business trip. The primary categories of coverage include trip cancellation, medical expenses, evacuation, and luggage or other personal loss.",
                "business trips", "trips", "cover", "insurance", "risk", "employee", "face", ));
            Questions.Add(new Question("Where can Igeta branded T-shirt/ other merch?",
                "Ask HR",
                ""));
            Questions.Add(new Question("Do we have any branded notepads/pens/umbrella?",
                "We have notepads, pens, umbrella",
                ""));
            Questions.Add(new Question("What idea incubator do we have?",
                "Idea Incubator projects are projects that are primarily intended for people to learn new skills, but are run as projects following the Amdaris SDLC in order to start forming teams ready for new projects.",
                ""));
            Questions.Add(new Question("What current projects do we have?",
                "Advance",
                ""));
            Questions.Add(new Question("What tech stacks are used in the projects?",
                "Frontend: HTML, CSS, React, JS, Typescript, Material UI, Backend: .NET Core, C#, Entity Framework, SQL, XUnit",
                ""));
            Questions.Add(new Question("How can I change the project?",
                "You need do this stages: ​Request to change the project, ​Review of request, Final approval, Replacing employee, Confirmation, Commencement, ​IT security",
                ""));
            Questions.Add(new Question("Where can I print at the office?",
                "Find printer and print",
                ""));
            Questions.Add(new Question("How to request an additional monitor?",
                "With support request",
                ""));
            Questions.Add(new Question("How to request a new chair?",
                "With support request",
                ""));
            Questions.Add(new Question("My lamp is broken, can Amdaris provide another one?",
                "No, if it isn't amdaris lamp",
                ""));
            Questions.Add(new Question("Where can I find paper for the printer?",
                "With support request",
                ""));
        }

        public static List<Question> FindAppropriateQuestion(string text)
        {
            var tags = text.Split(' ');

            return Questions.Where(x => x.CompareTags(tags)).ToList();
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
