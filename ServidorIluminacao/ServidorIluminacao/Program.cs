using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

class ServidorIluminacao
{
    // Dicionário atualizado com mais cômodos
    static Dictionary<string, string> estadoLuzes = new Dictionary<string, string>
    {
        { "sala", "desligada" },
        { "cozinha", "desligada" },
        { "quarto", "desligada" },
        { "banheiro", "desligada" },
        { "garagem", "desligada" }
    };

    static void Main()
    {
        // Criando um servidor TCP que escuta na porta 5005
        TcpListener servidor = new TcpListener(IPAddress.Any, 5005);
        servidor.Start();
        Console.WriteLine("Servidor de iluminação rodando na porta 5005...");

        while (true) // Mantém o servidor rodando indefinidamente
        {
            // Aguarda até que um cliente se conecte ao servidor
            TcpClient cliente = servidor.AcceptTcpClient();
            NetworkStream stream = cliente.GetStream();

            while (true) // Mantém a comunicação aberta enquanto o cliente estiver ativo
            {
                // Cria um buffer para receber os dados do cliente
                byte[] buffer = new byte[1024];
                int bytesLidos = stream.Read(buffer, 0, buffer.Length);

                if (bytesLidos == 0) break; // Se não recebeu dados, significa que o cliente se desconectou

                // Converte os bytes recebidos para uma string JSON
                string jsonRecebido = Encoding.UTF8.GetString(buffer, 0, bytesLidos);

                // Converte a string JSON para um objeto ComandoIluminacao
                var comando = JsonSerializer.Deserialize<ComandoIluminacao>(jsonRecebido);

                if (comando.Acao == "status") // Se o comando for "status", retorna o estado atual das luzes
                {
                    // Envia o estado atual das luzes de volta ao cliente sem alterar nada
                    string resposta = ObterEstadoLuzes();
                    byte[] respostaBytes = Encoding.UTF8.GetBytes(resposta);
                    stream.Write(respostaBytes, 0, respostaBytes.Length);
                }
                else // Altera o estado da luz conforme o comando
                {
                    if (estadoLuzes.ContainsKey(comando.Luz))
                    {
                        estadoLuzes[comando.Luz] = comando.Acao == "ligar" ? "ligada" : "desligada";

                        // Registrar o comando no log
                        RegistrarLog(comando.Luz, comando.Acao);

                        // Envia o estado atualizado das luzes para o cliente
                        string estadoAtualizado = ObterEstadoLuzes();
                        byte[] resposta = Encoding.UTF8.GetBytes(estadoAtualizado);
                        stream.Write(resposta, 0, resposta.Length);
                    }
                }
            }

            cliente.Close();
        }
    }

    // Função para exibir o estado das luzes de forma organizada
    static string ObterEstadoLuzes()
    {
        StringBuilder sb = new StringBuilder("Estado das lâmpadas:\n");
        foreach (var luz in estadoLuzes)
        {
            sb.AppendLine($"- {luz.Key}: {luz.Value}");
        }
        return sb.ToString();
    }

    // Função para registrar o comando no arquivo log.txt
    static void RegistrarLog(string luz, string acao)
    {
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string mensagemLog = $"[{timestamp}] Cliente alterou '{luz}' para '{acao}'";
        File.AppendAllText("log.txt", mensagemLog + Environment.NewLine);
    }
}

// Classe para representar os comandos recebidos do cliente (JSON)
class ComandoIluminacao
{
    public string Acao { get; set; } // "ligar" ou "desligar" ou "status"
    public string Luz { get; set; }  // Nome da luz ("sala", "cozinha", "quarto", etc.)
}
