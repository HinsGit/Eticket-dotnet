using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        public string Logo { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        //Relationship 一个cinema可以有很多个movie

        public List<Movie> Movies { get; set; } // cinema can buy multiple movies so 1 to many relationship
    }
}
