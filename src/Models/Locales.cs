﻿using System.Collections.Generic;

namespace SourceGit.Models
{
    public class Locale
    {
        public string Name { get; set; }
        public string Key { get; set; }

        public static readonly List<Locale> Supported = new List<Locale>() {
            new Locale("English", "en_US"),
            new Locale("简体中文", "zh_CN"),
            new Locale("繁體中文", "zh_TW"),
            new Locale("Deutsch", "de_DE")
        };

        public Locale(string name, string key)
        {
            Name = name;
            Key = key;
        }
    }
}
