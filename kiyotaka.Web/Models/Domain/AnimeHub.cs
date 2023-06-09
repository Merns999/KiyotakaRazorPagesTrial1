﻿using kiyotaka.Web.Data;

namespace kiyotaka.Web.Models.Domain
{
    public class AnimeHub : IEntity
    {
        public Guid Id { get; set; }
        public string Heading { get; set; }
        public string PageTitle { get; set; }
        public string ShortDescription { get; set; }
        public string ImageUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool Visible { get; set; }
    }
}
