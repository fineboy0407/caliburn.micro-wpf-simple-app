using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.Tutorial.Wpf.Models
{
    public class AboutModel
    {
        public string Title { get; set; } = "Simple Caliburn.Micro WPF Tutorial";
        public string Version { get; set; } = "1.0";
        public string Author { get; set; } = "FineBoy";
        public string Url { get; set; } = "https://caliburnmicro.com";
    }
}
