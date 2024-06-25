using System;
using System.Collections.Generic;

namespace OlimpiadasUCU.Models
{
    public class Competition
    {
        public int Id { get; set; }  // Clave primaria
        public int Round { get; set; }  // Nombre de la competencia
        public String Description { get; set; }  // Ubicación de la competencia
        public DateTime Date { get; set; }  // Fecha de la competencia
        public String JudgeNickname { get; set; }
    }
}
