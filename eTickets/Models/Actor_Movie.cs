namespace eTickets.Models
{
    public class Actor_Movie
    {

        //因为actor跟movie是many to many 所以我们用 Actor movie分成两个one-many
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }



    }
}
