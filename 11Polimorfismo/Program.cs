using _11Polimorfismo;

Imposto objetoEst = new Estagiario();
objetoEst.ValeAlimentacao(1000);
objetoEst.ValeTransporte(1000);
Console.WriteLine("--------------");

Imposto objetoGer = new Gerente();
objetoGer.ValeAlimentacao(5000);
objetoGer.ValeTransporte(5000);
Console.WriteLine("--------------");

Imposto objetoAte = new Atendente();
objetoAte.ValeAlimentacao(2000);
objetoAte.ValeTransporte(2000);
Console.WriteLine("--------------");