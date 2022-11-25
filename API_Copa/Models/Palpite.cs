using System;

namespace API_Copa.Models
{
    public class Palpite
    {
        public Palpite() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public int golsSelecaoA { get; set; }
        public int golsSelecaoB { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}