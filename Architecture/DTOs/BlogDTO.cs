﻿using DataModeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.DTOs
{
    public class BlogDTO
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string AuthorEmail { get; set; }
        public string Title { get; set; }
        public string Subheading { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public int BlogStatusTypeID { get; set; }
        public DateTime? PublishDate { get; set; }
        public int UserID { get; set; }
        public BlogDTO() { }
        public BlogDTO(Blog x)
        {
            if(x != null)
            {
                ID = x.ID;
                Author = x.User?.Username;
                AuthorEmail = x.User?.Email;
                Title = x.Title;
                Subheading = x.Subheading;
                Content = x.Content;
                ImageUrl = x.ImageUrl;
                BlogStatusTypeID = x.BlogStatusTypeID;
                PublishDate = x.PublishDate;
                UserID = x.UserID;
            }
        }
    }
}
