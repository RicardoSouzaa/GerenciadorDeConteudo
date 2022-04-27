using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel;

namespace Business
{
    public class Pagina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }

        public List<Pagina> Lista()
        {
            var lista = new List<Pagina>();
            var paginaDb = new Database.Pagina();

            foreach (DataRow row in paginaDb.Lista().Rows)
            {
                var data = (DateTime)row["data"];
                var pagina = new Pagina
                {
                    Id = Convert.ToInt32(row["id"]),
                    Nome = row["nome"].ToString(),
                    Conteudo = row["conteudo"].ToString(),
                    Data = data
                };
                lista.Add(pagina);
            }
            return lista;
        }

        public void Save()
        {
            new Database.Pagina().Salvar(this.Id, this.Nome, this.Conteudo, this.Data);
        }
    }
}