namespace MentoringAppAPI.Entities
{
    public class Mentor
    {
        public Guid MentorId { get; set; } = Guid.NewGuid();

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string JobTitle { get; set; }

        public string LinkedInLink { get; set; }

        public string Email { get; set; }

        public string MentoringFocus { get; set; }

        public string Experience { get; set; }

        public string AboutMe { get; set; }

        public string PictureLink { get; set; }

        public string RoleAndCareer { get; set; }

       
          
           
    }
}
