//using System;

namespace _19_09_23
{
	class Prodotto
	{
		private string nome;
		private float prezzo;

		public Prodotto()
		{
			nome = "nessun prodotto";
			prezzo = 0.0f;
		}

		public Prodotto(string nome, float prezzo)
		{
			/*
			this.nome = nome;
			this.prezzo = prezzo;
			*/
			if(!SetProdotto(nome, prezzo))
			{
				this.nome = "inserimento non valido, [throw]";
				this.prezzo = 0.0f;
			}
		}

		public bool SetNome(string nome)
		{
			if(string.IsNullOrEmpty(nome)) return false;
			this.nome = nome;
			return true;
		}

		public bool SetPrezzo(float prezzo)
		{
			if(prezzo <= 0.0f) return false;
			this.prezzo = prezzo;
			return true;
		}

		public bool SetPrezzo(string prezzo_stringa)
		{
			if(float.TryParse(prezzo_stringa, out float prezzo) || prezzo <= 0.0f)
			{
				this.prezzo = prezzo;
				return true;
			}
			else
				return false;
		}

		public bool SetProdotto(string nome, float prezzo)
		{
			return SetNome(nome) & SetPrezzo(prezzo);
		}

		public string GetNome()
		{
			return nome;
		}

		public float GetPrezzo()
		{
			return prezzo;
		}

	}
}
