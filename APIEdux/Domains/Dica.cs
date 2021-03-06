﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIEdux.Domains
{
    public class Dica : BaseDomains
    {
        //Atributos
        public string Texto { get; set; }
        [NotMapped]
        [JsonIgnore]
        public IFormFile Imagem { get; set; }
        public string UrlImagem { get; set; }


        //Foreign Keys
        public Guid IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        public List<Curtida> Curtidas { get; set; }
    }
}
