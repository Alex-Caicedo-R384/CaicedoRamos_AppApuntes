using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaicedoRamos_AppApuntes.Models
{
    internal class AcercaDe
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://aka.ms/maui";
        public string Message => "Esta aplicacion esta hecha en XAML y C# con .NET MAUI.";
    }
}
