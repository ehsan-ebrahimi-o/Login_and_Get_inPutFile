namespace Login_and_Get_inPutFile.Models
{
    public class PersonViewModel
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Age { get; set; }

        public string CityBurn { get; set; }

        public string Aboutself { get; set; }

        public string Mobile { get; set; }

        public string Password { get; set; }

        public IFormFile File { get; set; }

        public string ImageName { get; set; }
    }
}
