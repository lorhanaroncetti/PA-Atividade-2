using System;

class MainClass {

  public static int TrocaLetras(ref char[] arrMensagem, char ser_subs, char pelo_subs, ref char[]arrNovaMensagem){
    int trocas = 0;
    for( int i=0; i < arrMensagem.Length; i++){
      if( arrMensagem[i] == ser_subs ){
        arrNovaMensagem[i] = pelo_subs;
        trocas += 1;
      }
    }
    return trocas;
  }

  public static void Main (string[] args) {

    char[] arrMensagem;
    char[] arrNovaMensagem;

    string mensagem = Console.ReadLine();
    char ser_subs   = Convert.ToChar(Console.ReadLine());
    char pelo_subs  = Convert.ToChar(Console.ReadLine());
 
    arrMensagem     = mensagem.ToCharArray();
    arrNovaMensagem = mensagem.ToCharArray();

    int trocas = TrocaLetras(ref arrMensagem, ser_subs, pelo_subs, ref arrNovaMensagem);

    Console.WriteLine();

    Console.WriteLine(new string(arrNovaMensagem));
    Console.WriteLine(new string(arrMensagem));
    Console.WriteLine(trocas);

  }
}
