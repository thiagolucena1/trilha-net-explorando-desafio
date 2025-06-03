namespace DesafioProjetoHospedagem.Models;
using DesafioProjetoHospedagem.Models;
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
        
        if (Suite.Capacidade >= hospedes.Count) //Implementação da verificação de capacidade, pois deve ser maior ou igual ao número de hóspedes recebidos.
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new Exception("Capacidade insuficiente para o número de hóspedes."); // Neste trecho estamos lançando uma exceção caso a capacidade da suíte seja menor que o número de hóspedes recebidos.
            // Implementado Thiago.
        }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {

            Console.WriteLine("Quantidade de hóspedes: " + Hospedes.Count); // Exibe a quantidade de hóspedes cadastrados - Thiago.
            return Hospedes.Count; // Retorna a quantidade de hóspedes cadastrados./
        }

        public decimal CalcularValorDiaria()
        {
            
        decimal valor = DiasReservados * Suite.ValorDiaria; // A variável Valor recebe o valor da diária multiplicado pelos dias reservados.

        // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
       
        if (DiasReservados >= 10)
        {
            decimal desconto = valor * 0.10m; // Calcula 10% de desconto
            valor = valor - desconto;

            Console.WriteLine($"Valor com desconto: {valor:C}");
            Console.WriteLine($"Valor sem desconto: {DiasReservados * Suite.ValorDiaria:C}");
            return valor;
        }
        else
        {
            valor = DiasReservados * Suite.ValorDiaria;
            Console.WriteLine($"{valor:C}");

            return valor;
        }

            return valor;
        }
    }
