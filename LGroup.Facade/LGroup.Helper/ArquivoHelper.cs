using System;
using System.IO;

namespace LGroup.Helper
{
    public sealed class ArquivoHelper
    {
        public static void Gerar(String  conteudo_)
        {
            var pathFile = @"E:\NetCodes\Padrão de Projetos\FileCreateByProgram\Pedido.txt";

            if (File.Exists(pathFile))
                File.Delete(pathFile);

            using (var arquivo = new StreamWriter(pathFile))
            {
                arquivo.WriteLine(conteudo_);
                arquivo.Close();
            }
        }
    }
}
