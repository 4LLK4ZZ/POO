// Função Main()

using AgregacaoConta;

Endereco end = new Endereco("Rua Fatec", 75, "PP");
// end é um atributo
// Ender é um atributo na Classe Endereco, porém ao receber a instância se torna objeto
// Endereco classe

Cliente c11 = new Cliente("Ana", "12345678-9", "123456789-12");
c11.Ender = end; //Agregando o endereço no Cli

Conta c1 = new Conta();
c1.Numero = 1;
c1.Titular = c11; // Agregando o cliente a conta c1
c1.Saldo = 100;

Console.WriteLine("Endereço: "+ c1.Titular.Ender.Logradouro + ", Nº "+c1.Titular.Ender.Numero+ "\nConta: "+c1.Numero + "\nSaldo: R$"+c1.Saldo + "\nNome, RG e CPF: "+c1.Titular.Nome+" | "+c1.Titular.Rg+" | "+c1.Titular.Cpf+ "\nCidade: "+c1.Titular.Ender.Cidade);