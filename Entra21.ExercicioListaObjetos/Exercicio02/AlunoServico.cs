namespace Entra21.ExercicioListaObjetos.Exercicio02
{
    internal class AlunoServico
    {
        private List<Aluno> alunos = new List<Aluno>();


        private int codigoNovo = 1;
        public void Adicionar(string nome,int codigoMatricula, int Idade, string materiaFavorita, double nota1, double nota2, double nota3)
        {
            Aluno aluno = new Aluno();

            aluno.Nome = nome;
            aluno.Idade = Idade;    
            aluno.MateriaFavorita = materiaFavorita;
            aluno.Nota1 = nota1;
            aluno.Nota2 = nota2;
            aluno.Nota3 = nota3;
            aluno.CodigoMatricula = codigoMatricula;
            aluno.CodigoMatricula = codigoNovo;

            codigoNovo++;
            alunos.Add(aluno);
        }

        public bool RemoverAluno(string nome)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                Aluno aluno = alunos[i];

                if(aluno.Nome == nome)
                {
                    alunos.Remove(aluno);
                    return true;
                }
            }
            return false;
        }

        public Aluno ObterPorMatricula(int codigoMatricula)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                if(alunoAtual.CodigoMatricula == codigoMatricula)
                {
                    return alunoAtual;
                }
            }
            return null;
        }

        public bool EditarDadosCadastrais (int codigoMatricula, string nome, int idade, string materiaFavorita)
        {
            Aluno alunoParaAlterar = ObterPorMatricula(codigoMatricula);

            if (alunoParaAlterar == null)
            {
                return false;
            }

            alunoParaAlterar.Nome = nome;
            alunoParaAlterar.Idade = idade;
            alunoParaAlterar.MateriaFavorita = materiaFavorita;

            return true;
        }

        public bool EditarNotasAlunos(int codigoMatricula, double nota1, double nota2, double nota3)
        {
            Aluno notasParaAlterar = ObterPorMatricula(codigoMatricula);

            if(notasParaAlterar == null)
            {
                return false;
            }  

            notasParaAlterar.Nota1 = nota1;
            notasParaAlterar.Nota2 = nota2;
            notasParaAlterar.Nota3 = nota3;
            return true;
        }

        public List<string> ObterNomes()
        {

        var nomes = new List<string>(); 

            for (int i = 0; i< alunos.Count; i++)
            {
                var aluno = alunos[i];
            }
            
            return nomes;
        }

        public List<double> ObterMedias()
        {
            var medias = new List<double>();    
            for( int i = 0; i < alunos.Count; i++)
            {
               var media = alunos[i].CalcularMedia();
                medias.Add(media);  
            }
            return medias;
        }

        public List<string> ObterAprovados()
        {
            var aprovados = new List<string>();

            for(int i = 0; alunos.Count > 0; i++)
            {
                var aluno = alunos[i];

                if(aluno.ObterStatus() == AlunoStatus.Aprovado)
                {
                    aprovados.Add(aluno.Nome);
               
                }     
            }
            return aprovados;
        }
       
  






    }
}
