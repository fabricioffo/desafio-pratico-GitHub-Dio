// See https://aka.ms/new-console-template for more information
int nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0, media;


Console.WriteLine("digite a primeira nota:");
   nota1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("digite a segunda nota:");
    nota2 = Int32.Parse(Console.ReadLine());

Console.WriteLine("digite a terceira nota:");
    nota3  =Int32.Parse(Console.ReadLine());

Console.WriteLine("digite a quarta nota:");
    nota4 = Int32.Parse(Console.ReadLine());

 
    media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine("a media final é:"+ media);

if(media < 5){
    Console.WriteLine("o aluno foi reprovado");


}
else
{
    Console.WriteLine("o aluno foi aprovado");
}

