using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogosDeGuerraModel
{
    class FactoryExercitoFenicio : AbstractFactoryExercito
    {
        public override Arqueiro CriarArqueiro()
        {
            return new ArqueiroFenicio();
        }

        public override Cavaleiro CriarCavalaria()
        {
            return new CavaleiroFenicio();
        }

        public override Guerreiro CriarGuerreiro()
        {
            return new GuerreiroFenicio();
        }

        public override Mago CriarMago()
        {
            return new MagoFenicio();
        }
    }
}
