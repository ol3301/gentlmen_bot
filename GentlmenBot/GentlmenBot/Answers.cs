namespace GentlmenBot
{
    public static class Answers
    {
        public static string What_type_of_certifications_does_Amadris_cover = "https://amdaris.sharepoint.com/:x:/r/_layouts/15/Doc.aspx?sourcedoc=%7BF2369EEE-9F5A-47C6-95D3-3A812B22C382%7D&file=Certifications%202020%20(5).xlsx&action=default&mobileredirect=true&DefaultItemOpen=1";
        public static string What_are_the_courses_Amdaris_covers = "asp.net core, java, java, english cources";
        public static string What_is_the_percent_of_money_Amdaris_covers_for_certification = "50%";
        public static string What_is_the_percent_of_money_Amdaris_covers_for_cources = "50%";
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

        public static string NeedToAttendToSomewhere = @"Tell your delivery lead ";
        public static string NoticePeriodOfAnnualLeave = "2 weaks";
        public static string What_expenses_are_covered_when_the_business_trips = @"Business (or corporate) travel insurance covers different risks an employee might face during a business trip. The primary categories of coverage include trip cancellation, medical expenses, evacuation, and luggage or other personal loss.";
        public static string Where_can_I_get_a_branded_T_shirt_other_merch = @"Ask HR";
        public static string Do_we_have_any_branded_notepadspensumbrella = @"";
    }
}
