﻿namespace Portfolio_Core.DataAccessLayer.Entities
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
