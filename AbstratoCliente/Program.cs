// Método main()

using AbstratoCliente;

//Cliente c = new Cliente();//TODO:Não instanciará

ClienteFisico cf = new ClienteFisico(1, "Ana", "Rua 2", 1111);
cf.Mostrar();
ClienteJuridico cj = new ClienteJuridico(100, "Empresa", "Rua 2", 10000);
cj.Mostrar();