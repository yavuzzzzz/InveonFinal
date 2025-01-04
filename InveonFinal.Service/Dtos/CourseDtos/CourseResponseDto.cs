﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonFinal.Service.Dtos.CourseDtos
{
    public class CourseResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public decimal Price { get; set; }
        public string Category { get; set; } = default!;
        public string Description { get; set; } = default!;
    }
}
