﻿namespace CodeFirstBasic.Entities
{
    public class MovieEntity : BaseEntity
    {
       
        public string Title { get; set; }

        [RegularExpression("^(Action|Comedy|Drama)$", ErrorMessage = "Gecerli bir film turu degil")]
        public string Genre { get; set; }

        public int ReleaseYear { get; set; }
    }
}
