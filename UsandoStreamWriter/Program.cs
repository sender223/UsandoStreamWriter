using System;
using System.IO;

namespace UsandoStreamWriter {
    class Program {
        static void Main(string[] args) {            
                                                  
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try {
                //aqui vemos todo o conteúdo do arquivo e armazenamos
                //no vetor de strings "lines" usando a função File.ReadAllLines
                //com o argumento "sourcePath"
                string[] lines = File.ReadAllLines(sourcePath);
                //instanciamos o StreamWriter para escrever no arquivo de saída.
                //com o argumento targetPath
                using (StreamWriter sw = File.AppendText(targetPath)) {
                    //para cada string line no vetor lines 
                    foreach (string line in lines) {
                        //escreva no final do arquivo(no caso o novo arquivo)
                        //todo o conteúdo do primeiro arquivo em letra maiúscula.
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error Ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}

