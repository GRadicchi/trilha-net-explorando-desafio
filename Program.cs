
using ConsoleApp1.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Fernanda", "Rezende");
Pessoa p2 = new Pessoa("Guilherme", "Almeida");

hospedes.Add(p1);
hospedes.Add(p2);


Suite suite = new Suite("Premium", 2, 200.00m);

Reserva reserva = new Reserva(suite, diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor Diário: {reserva.CalcularValorDiaria()}");