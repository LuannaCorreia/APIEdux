﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIEdux.Domains
{
    public class ProfessorTurma : BaseDomains
    {
        //Atributos
        public string Descricao { get; set; }

        //Foreign Keys
        public Guid IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        public Guid IdTurma { get; set; }
        [ForeignKey("IdTurma")]
        public Turma Turma { get; set; }
    }
}
