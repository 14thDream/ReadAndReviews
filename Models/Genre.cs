﻿namespace Models
{
    public class Genre
    {
        public Genre(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }
    }
}
