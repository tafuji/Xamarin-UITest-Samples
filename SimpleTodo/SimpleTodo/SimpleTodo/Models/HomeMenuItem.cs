﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTodo.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        WebView
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
