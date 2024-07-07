using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public class Program
    {
        //Usamos a palavra partial, quando queremos dividir
        //uma msm classe em varios arquivos, usamos quando é uma classe mt extensa
        //em tempo de compilação ajunta todos os arquivos em um só.
        public void AcessarAlunos()
        {
            var aluno = new Aluno();
            aluno.idade = 1;
            aluno.nome = "ismael";
        }


    }
}
