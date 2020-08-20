using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCRUD.Context.Models
{
    public class CentroDistribuicao
    {
        string _cnpj;
        public int Id { get; set; }
        public string Cnpj 
        { 
            get => _cnpj.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-"); 
            set => _cnpj = value; 
        }
        public string RazaoSocial { get; set; }
        public string Telefone { get; set; }
        public string Tipo { get; set; }
        public string Endereco { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; } = new HashSet<Funcionario>();
        public virtual ICollection<Patrimonio> Patrimonios { get; set; } = new HashSet<Patrimonio>();

    }
}
