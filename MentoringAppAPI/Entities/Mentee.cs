namespace MentoringAppAPI.Entities
{
    public class Mentee
    {
        public Guid MenteeId { get; set; } = Guid.NewGuid();

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string JobTitle { get; set; }

        public string LinkedInLink { get; set; }

        public string Email { get; set; }

        public string MentoringRequired { get; set; }

        public string FocusAreas { get; set; }

        public string MyGoals { get; set; }    

        public string AboutMe { get; set; }

        public string PictureLink { get; set; }

        public string RoleAndCareer { get; set; }

        
       
    }
}
