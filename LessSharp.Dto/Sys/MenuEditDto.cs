﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LessSharp.Dto.Sys
{
    public class MenuEditDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int Order { get; set; }
        public string Icon { get; set; }
        public int? ParentId { get; set; }
        public bool IsPage { get; set; }
        public bool CanMultipleOpen { get; set; }
        public string ParentName { get; set; }
        public bool HasRead { get; set; }
        public bool HasWrite { get; set; }
        public bool HasReview { get; set; }
        public List<MenuApiDto> MenuApis { get; set; }
    }

    public class MenuApiDto
    {
        public int MenuId { get; set; }
        public int ApiId { get; set; }
        public string ApiName { get; set; }
        public string ApiPath { get; set; }
        public bool ApiIsCommon { get; set; }
        public string ApiPermissionType { get; set; }
    }
}
