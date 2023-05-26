﻿using System;
using System.Collections.Generic;

namespace WebAPIWithASP.NETCoreTutorial.Models;

public partial class Categorium
{
    public int CategoriaId { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
