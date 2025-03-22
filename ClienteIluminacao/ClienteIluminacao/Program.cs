using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

class ClienteIluminacao
{
    static void Main()
    {
        // Conecta-se ao servidor na porta 5005
        TcpClient cliente = new TcpClient("127.0.0.1", 5005);
        NetworkStream stream = cliente.GetStream();
        Console.WriteLine("Digite 'sair' para encerrar.");

        while (true)
        {
            // Pergunta ao usuário qual luz ele deseja controlar
            Console.Write("Luz (sala, cozinha, quarto, banheiro, garagem): ");
            string luz = Console.ReadLine().ToLower();

            if (luz == "sair") break;

            if (luz == "status") // Se o usuário digitar "status", pede o status das luzes
            {
                EnviarComando(cliente, "status", "");
                continue;
            }

            // Pergunta ao usuário se deseja ligar ou desligar a luz
            Console.Write("Ação (ligar/desligar): ");
            string acao = Console.ReadLine().ToLower();

            // Cria um objeto ComandoIluminacao com os dados do usuário
            var comando = new ComandoIluminacao { Acao = acao, Luz = luz };

            // Converte o objeto para JSON e transforma em bytes
            byte[] bufferEnvio = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(comando));
            stream.Write(bufferEnvio, 0, bufferEnvio.Length);

            // Aguarda a resposta do servidor
            byte[] bufferRecebimento = new byte[1024];
            int bytesLidos = stream.Read(bufferRecebimento, 0, bufferRecebimento.Length);

            // Exibe o estado das luzes de maneira mais organizada
            string resposta = Encoding.UTF8.GetString(bufferRecebimento, 0, bytesLidos);
            Console.WriteLine(resposta);
        }

        cliente.Close();
    }

    // Função que envia o comando de iluminação para o servidor
    static void EnviarComando(TcpClient cliente, string acao, string luz)
    {
        var comando = new ComandoIluminacao { Acao = acao, Luz = luz };
        byte[] bufferEnvio = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(comando));
        NetworkStream stream = cliente.GetStream();
        stream.Write(bufferEnvio, 0, bufferEnvio.Length);

        // Aguarda a resposta do servidor
        byte[] bufferRecebimento = new byte[1024];
        int bytesLidos = stream.Read(bufferRecebimento, 0, bufferRecebimento.Length);
        string resposta = Encoding.UTF8.GetString(bufferRecebimento, 0, bytesLidos);
        Console.WriteLine(resposta);
    }
}

// Classe para representar os comandos recebidos do cliente (JSON)
class ComandoIluminacao
{
    public string Acao { get; set; } // "ligar", "desligar" ou "status"
    public string Luz { get; set; }  // Nome da luz ("sala", "cozinha", etc.)
}
