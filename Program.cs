using Hotel.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa pessoa1 = new Pessoa("Geovan", "Baranowski");
Pessoa pessoa2 = new Pessoa("Gesica", "Baranowski");
Pessoa pessoa3 = new Pessoa("Glauco", "Baranowski");

hospedes.Add(pessoa1);
hospedes.Add(pessoa2);
hospedes.Add(pessoa3);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

Reserva reserva = new Reserva(diasReservados: 8);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diaria: {reserva.CalcularDiaria()}");
