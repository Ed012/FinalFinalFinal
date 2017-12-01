using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final1_Colegio.Services
{
    public class NoteService : INoteService
    {
        public int promedy(int nota1, int nota2)
        {
            int promedio;
                return promedio = (nota1 + nota2) / 2;
        }
    }
}