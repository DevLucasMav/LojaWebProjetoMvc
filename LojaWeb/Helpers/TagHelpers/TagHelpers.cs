﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaWeb.Helpers.TagHelpers
{
    [HtmlTargetElement("nome-pessoa")]

    public class RazorTagHelpers : TagHelper
    {
        public string nome { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output) 
        {
            var span = new TagBuilder("span");
            span.AddCssClass("bagde badge-info");
            span.InnerHtml.Append(nome);
            output.Content.AppendHtml(span);
        }
    }
}
