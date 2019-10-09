namespace SENAIzinho {
    public class Sala {
        public int capacidadeAtual;
        public int capacidadeTotal;
        public int numeroSala;
        public string Alunos;

        public Sala (int numeroSala, int capacidadeTotal) {
            this.numeroSala = numeroSala;
            this.capacidadeTotal = capacidadeTotal;
        }
        public string AlocarAluno (string Alunos) {
            this.Alunos = Alunos;
            return Alunos;
        }
        public string RemoverAluno (string Alunos) {
            this.Alunos = Alunos;
            return Alunos;
        }
        public string MostrarAluno (string Alunos) {
            this.Alunos = Alunos;
            return Alunos;
        }
    }
}