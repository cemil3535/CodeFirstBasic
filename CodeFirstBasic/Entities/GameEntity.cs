﻿namespace CodeFirstBasic.Entities
{
    public class GameEntity : BaseEntity
    {
        
        public string Name { get; set; }

        
        public string Platform {  get; set; }

        [Range(0, 10, ErrorMessage = "Oyun Puani 0 ile 10 arasinda olmalidir.")]
        public decimal Rating { get; set; }
    }
}
