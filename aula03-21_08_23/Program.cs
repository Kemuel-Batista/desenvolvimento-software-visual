using aula03_21_08_23;

Carro carro1 = new Carro();

carro1.Placa = "ABC1234";
carro1.Descricao = "FIAT Argo";
carro1.CorExterna = Carro.Cor.Branca;

Carro carro2 = new Carro();

carro2.Placa = "CBA4321";
carro2.Descricao = "GOLF R";
carro2.CorExterna = Carro.Cor.Preta;

Veiculo v = new("CDA1234", "CARRO DO TEIXAS SOBAIXO", Veiculo.Cor.Branca);

Modelo modVolks = new("VOLKS", "TURBO");

Carro c = new("ASD1234", "GOLFAO 1000HP", Veiculo.Cor.Preta, 4, modVolks);

c.Mostrar();