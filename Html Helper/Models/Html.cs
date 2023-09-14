namespace Html_Helper.Models
{
    public class Html
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Gender { get; set; }

        public string list { get; set; }

        //Hobbies
        public bool Play { get; set; }
        public bool Music { get; set; }

        public bool Song { get; set; }

        //Image

        public IFormFile image { get; set; }

        


    }
}
