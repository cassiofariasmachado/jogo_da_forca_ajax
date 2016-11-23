﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca.Dominio.Repositorios
{
    public interface IPalavraRepositorio
    {
        Palavra Buscar(int id);
        Palavra BuscarPalavraAleatoria(int qtdCaracteresMinima = 0);
    }
}
