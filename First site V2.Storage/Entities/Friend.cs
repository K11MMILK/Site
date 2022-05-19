﻿using System.ComponentModel.DataAnnotations;

namespace First_site_V2.Storage.Entities
{
    public class Friend
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int  FriendId { get; set; }
        public string FriendName { get; set; }
        public string FriendSurname { get; set; }
    }
}
