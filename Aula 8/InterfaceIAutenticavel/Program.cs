using InterfaceIAutenticavel;

Cliente c = new Cliente();
c.Senha = 100;

Gerente g = new Gerente();
g.Senha = 200;

Diretor d = new Diretor();
d.Senha = 300;
//Console.WriteLine("Autenticou? " + d.Autenticar(300));

IAutenticavel ia = d;
//ia.Senha = 88 a interface n"ao tem acesso a propriedade senha, apenas ao método autenticar
Console.WriteLine("Autenticou Diretor? " + ia.Autenticar(300));
Console.WriteLine("--------------------");

ia = c;
Console.WriteLine("Autenticou Cliente? " + ia.Autenticar(100));