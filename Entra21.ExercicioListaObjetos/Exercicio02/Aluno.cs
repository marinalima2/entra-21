namespace Entra21.ExercicioListaObjetos.Exercicio02
{
    internal class Aluno
    {
        public string Nome;
        public int CodigoMatricula;
        public int Idade;
        public string MateriaFavorita;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalcularMedia()
        {
            var media = (Nota1 + Nota2+ Nota3)/3;
            return media;
        }

        public AlunoStatus ObterStatus()
        {
            AlunoStatus status = new AlunoStatus();
             
            if(CalcularMedia() < 6)
            {
                status = AlunoStatus.Reprovado;
                
            } else if (CalcularMedia() < 7)
            {
                status = AlunoStatus.Em_Exame;

            } else if (CalcularMedia() > 7)
            {
                status = AlunoStatus.Aprovado;
            }
                    
            return status;
        }








    }
}
