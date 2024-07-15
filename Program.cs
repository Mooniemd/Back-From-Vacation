bool ganhou = false;

Console.WriteLine("Vamos jogar um jogo de de portas?");
string? mainResposta = Console.ReadLine()!.ToLower();
if ( mainResposta == "sim"){
  ganhou = false;
} else{
  ganhou = true;
  Console.WriteLine("Aff, que chato!");
}

while (!ganhou){
  Console.WriteLine("Beleza! Escolha uma das portas a seguir: Porta 1, Porta 2 ou Porta 3? (Só digite os números!)");
  int portas = int.Parse(Console.ReadLine()!);
    Console.Clear();


switch(portas){
  case 1:
  Console.WriteLine("Você entra numa porta escura e... acaba caindo numa piscina de tubarões! Que pena, os tubarões te comeram.");
  Console.WriteLine("Deseja continuar jogando?");
  string? continuarJogando = Console.ReadLine()!.ToLower();
  switch(continuarJogando){
    case "sim":
    ganhou = false;
    break;
    case "nao":
    ganhou = true;
    Console.WriteLine("Nem todo mundo consegue ir até o final.. que pena!");
    break;
  }
  break;

  case 2:
  Console.WriteLine("Você entra numa porta escura e... acaba tocando num fio sem proteção! Que pena, você foi eletrocutado.");
  Console.WriteLine("Deseja continuar jogando?");
  string? jogarDenovo = Console.ReadLine()!.ToLower();
  switch(jogarDenovo){
    case "sim":
    ganhou = false;
    break;
    case "nao":
    ganhou = true;
    Console.WriteLine("Nem todo mundo consegue ir até o final.. que pena!");
    break;
  }

  break;

  case 3:
    Console.WriteLine("Você entra numa porta escura e... Eba! Você achou vário computadores novos pra pegar e levar pra casa.");
  Console.WriteLine("Agora, qual computador irá escolher?");
  int computadores = int.Parse(Console.ReadLine()!);

  for(int i = 0; i <= 3; i++){
    Console.WriteLine("Se seu número foi " + i + ", você ganhou!");
    if ( computadores == i){
    ganhou = true;
    Console.WriteLine("Parabéns, o computador que você escolheu era o melhor! Pode ir embora com ele pra casa.");
  } else{
    ganhou = false;
    Console.WriteLine("Quer jogar outro jogo?");
   string? outroJogo = Console.ReadLine()!.ToLower();
    switch(outroJogo){
    case "sim":
    ganhou = false;
    break;
    case "nao":
    ganhou = true;
    Console.WriteLine("Nem todo mundo consegue ir até o final.. que pena!");
    break;
    }
  }
}
  break;
  }
}

/*
                    __
         .,-;-;-,. /'_\
       _/_/_/_|_\_\) /
     '-<_><_><_><_>=/\
      `/_/====/_/-'\_\
        ""     ""    ""
        noted by: moonie */