﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Models
{
    public class TipoTarefa
    {
        [Key]
        public int Id { get; set; } // Chave primária

        public string NomeTarefa { get; set; } // Nome do tipo de tarefa
    }
}
