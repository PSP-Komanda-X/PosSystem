﻿namespace POS.Api.Models.DTOs.Item
{
    public class UpdateItemDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public float Price { get; set; }
    }
}
