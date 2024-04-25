//método Main

using HerancaCliente;

Cliente c = new Cliente();
c.Codigo = 1;
c.Nome = "Alcides";
c.Endereco = "Rua Nazir Inácio Ribeiro, 722 - Vila Alegrete";

ClienteFisico cf = new ClienteFisico();
cf.Codigo = 2;
cf.Nome = "Alcides Nogueira";
cf.Endereco = "Rua Nazir Inácio Ribeiro, 722 - Vila Alegrete, 19500-000";
cf.Rg = 545404885;
cf.Mostrar();
ClienteFisico cf2 = new ClienteFisico(4, "Carlos", "Rua José Maria Sanches, 356 - Centro, 19500-000", 45562187);
cf2.Mostrar();

ClienteJuridico cj = new ClienteJuridico();
cj.Codigo = 3;
cj.Nome = "AKZ Corp.";
cj.Endereco = "Rua Estados Unidos, 2654 - Centro, 19700-000";
cj.Cnpj = 854462652;
cj.Mostrar();
ClienteJuridico cj2 = new ClienteJuridico(5, "AKZ TI.", "Rua Estados Unidos, 2564 - Centro, 19700-000 - 2º Andar", 854462653);
cj2.Mostrar();