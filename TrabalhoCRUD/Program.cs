using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoCRUD.Context;
using TrabalhoCRUD.Menu;

namespace TrabalhoCRUD
{
    class Program
    {
        static void Main()
        {
            /*para criar o banco
            var context = new DistribuicaoContext();

            foreach (var patrimonio in context.Patrimonios)
            {
                Console.WriteLine(patrimonio.Equipamento);
            }*/
            ListarGeral.Executar(4);
            Console.ReadKey();
        }
    }
}
