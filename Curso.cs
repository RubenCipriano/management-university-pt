﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI
{
    public class Curso
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public ICollection<Disciplina> Disciplinas { get; set; }
        
        public double getNota() {
            return this.Disciplinas.Average((disciplina) => disciplina.getNota());
        }
    }
}