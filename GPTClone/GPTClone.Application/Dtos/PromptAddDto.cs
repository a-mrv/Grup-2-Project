﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTClone.Application.Dtos
{
    public class PromptAddDto
    {
        public string Text { get; set; }
        public string Response { get; set; }
        public string CreatedBy { get; set; }
    }
}
