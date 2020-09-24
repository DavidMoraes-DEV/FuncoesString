using System;
using System.Security.Cryptography;

namespace FuncoesInteressantesParaStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";
            Console.WriteLine("Original: -" + original + "-");

            string s1 = original.ToUpper();/*O comando ToUpper converte todos os caracteres da string para letras MAIÚSCULAS*/
            Console.WriteLine("ToUpper: -" + s1 + "-"); 

            string s2 = original.ToLower();/*O comando ToLower converte todos os caracteres da string em letras minúsculas*/
            Console.WriteLine("ToLower: -" + s2 + "-");

            string s3 = original.Trim(); /*O comando Trim apaga todos os espaços em branco tanto depois quanto na frente das strings*/
            Console.WriteLine("Trim: -" + s3+"-");

            int s4 = original.IndexOf("bc"); /*O comando IndexOf é uma função de procura, podendo procurar um valor ou uma string*/
            Console.WriteLine("IndexOf('bc'): " + s4); /*O resultado da "1" pois o bc na string começa na posição 1 da string*/

            int s5 = original.LastIndexOf("bc"); /*O comando LastIndexOf tem a mesma função do IndexOf porém procura a última ocorrência do "bc"*/
            Console.WriteLine("IndexOf('bc'): " + s5); /*O resultado da "17" pois a última ocorrência do bc esta na posição 17 da string*/

            string s6 = original.Substring(3); /*O Substring é uma função para cortar uma strings e possui duas sobrecargas, ou voce coloca apenas o Indice inicial ou coloca o indice inicial + o tamanho que deseja cortar, no exemplo acima colocamos apenas o indice inicial*/
            Console.WriteLine("Substring(3): -" + s6 + "-"); /*Aqui corta apartir da letra"d" pois ele esta na posição 3 que foi declarada*/

            string s7 = original.Substring(3, 5); /*Aqui é utilizado a segunda sobrecarga utilizando o indice inicial mais o tamanho que quero cortar*/
            Console.WriteLine("Substring(3, 5): -"+ s7 + "-"); /*Recortou apenas os 5 caracteres que foi definido como parâmetro*/

            string s8 = original.Replace('a', 'x'); /*O comando Replace substitui uma parte da string por outra, possui 4 sobrecargas suas principais são a de cubstituir apenas um caracter ou subtituir uma string, no exemplo acima substituimos apenas um caracter 'a' por outro caracter 'x'*/
            Console.WriteLine("Replace('a', 'x': -" + s8 + "-");

            string s9 = original.Replace("abc", "xy"); /*Aqui utilizamos a segunda sobrecarga de substituir uma string por outra*/
            Console.WriteLine("Replace('abc', 'xy': -"+ s9+"-");

            bool b1 = string.IsNullOrEmpty(original);/*O comando IsNullOrEmpty é uma função que testa se uma string é vazia ou não e retorna verdadeiro ou falso(valor booleano)(muito útil para testar um cadastro de usuario)*/
            Console.WriteLine("IsNullOrEmpry: " + b1); /*Resultado é false pois essa string não é esta vazia*/

            bool b2 = string.IsNullOrWhiteSpace(original); /*Essa função testa se a variavel é nula ou um monte de espaços em branco*/
            Console.WriteLine("IsNullOrWhiteEmpry: " + b2);

            /*Existe outras funções de string sendo:
             str.Split(' ') serve para recortar uma string com base no parâmetro que colocar entra parenteses, nesse caso foi o espaço em branco
             int.Parse() ou Convert.Toint32() converte o valor da variável para numeros inteiros
             str = x.ToString
             str = x.ToString("C")
             str = x.Tostring("C3")
            str = x.ToString("F2") define a quantidade de casas decimais
            */
        }
    }
}
