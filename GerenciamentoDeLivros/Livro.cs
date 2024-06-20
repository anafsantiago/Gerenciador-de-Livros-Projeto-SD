using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GerenciadorLivros2.Models
{
    public partial class Livro
    {
        public Item[] Items { get; set; }
    }

    public partial class Item
    {
        public VolumeInfo VolumeInfo { get; set; }
    }

    public partial class VolumeInfo
    {
        public string Title { get; set; }

        public string[] Authors { get; set; }

        public string Publisher { get; set; }

        public string Description { get; set; }

        public IndustryIdentifier[] IndustryIdentifiers { get; set; }
    }

    public partial class IndustryIdentifier
    {
        public string Type { get; set; }

        public string Identifier { get; set; }
    }

}

