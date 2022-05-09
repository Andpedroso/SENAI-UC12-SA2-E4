// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using SenaiBack2.Classes;

// PessoaFisica metodoPf = new PessoaFisica();

// PessoaFisica novaPf = new PessoaFisica();

// Endereco novoEnd = new Endereco();

// //novaPf.nome = "André";

// //Console.WriteLine( "Nome: " + novaPf.nome );

// //Console.WriteLine( $"Nome: {novaPf.nome}" );

// novaPf.nome = "André";

// novaPf.dataNascimento = "01/01/2000";

// novaPf.cpf = "123456789";

// novaPf.rendimento = 15000.5f;

// novoEnd.logradouro = "Alameda Barão de Limeira";

// novoEnd.numero = 539;

// novoEnd.complemento = "SENAI Informática";

// novoEnd.endComercial = true;

// novaPf.endereco = novoEnd;

// //Console.WriteLine($"Nome: {novaPf.nome}");
// //Console.WriteLine($"Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}");

// Console.WriteLine(@$"
// Nome: {novaPf.nome}
// Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
// Maior de idade: {metodoPf.ValidarDataNascimento( novaPf.dataNascimento )}
// ");

PessoaJuridica metodoPj = new PessoaJuridica();

PessoaJuridica novaPj = new PessoaJuridica();

Endereco novoEndPj = new Endereco();


novaPj.nome = "Nome Pj";

novaPj.cnpj = "00.000.000/0001-00";

novaPj.razaoSocial = "Razão Social Pj";

novaPj.rendimento = 8000.5f;


novoEndPj.logradouro = "Alameda Barão de Limeira";

novoEndPj.numero = 539;

novoEndPj.complemento = "SENAI Informática";

novoEndPj.endComercial = true;


novaPj.endereco = novoEndPj;


Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ Válido: {metodoPj.validarCnpj(novaPj.cnpj)}");