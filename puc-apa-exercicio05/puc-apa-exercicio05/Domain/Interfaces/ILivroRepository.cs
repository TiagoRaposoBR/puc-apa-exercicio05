﻿using puc_apa_exercicio05.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace puc_apa_exercicio05.Domain.Interfaces
{
	public interface ILivroRepository
	{
		void Add(LivroEntity livro);
	}
}
