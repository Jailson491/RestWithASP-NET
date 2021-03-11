using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASP_NET5.Model
{
    [Table("person")]
    public class Person
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("First_Name")]
        public string FirstName { get; set; }

        [Column("Last_Name")]
        public string LastName { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

    }
}
