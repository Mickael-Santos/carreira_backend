using System.Net;
using System.Net.Sockets;
using System.Text;

class ServidorHttp
{
    private TcpListener Servidor { get; set; }

    private int porta { get; set; }

    private int QtdRequests { get; set; }

    private string HtmlExemplo { get; set; }

    public ServidorHttp(int porta = 8080)
    {
        this.porta = porta;
        this.CriarhtmlExemplo();
        try
        {
            this.Servidor = new TcpListener(IPAddress.Parse("127.0.0.1"), this.porta);
            this.Servidor.Start();
            Console.WriteLine($"Servidor HTTP está rodando na porta {this.porta}");
            Console.WriteLine($"Para acessar , digite no navegador http://localhost:{this.porta}.");
            Task servidorHttpTask = Task.Run(() => AguardarRequests());
            servidorHttpTask.GetAwaiter().GetResult();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ops, houve um erro ao tentar rodar o servidor, erro: {e.Message}.");
        }

    }

    private async Task AguardarRequests()
    {
        while (true)
        {
            Socket conexao = await this.Servidor.AcceptSocketAsync();
            this.QtdRequests++;
            Task task = Task.Run(() => ProcessarRequest(conexao, this.QtdRequests));
        }
    }

    private void ProcessarRequest(Socket conexao, int numeroRequest)
    {
        Console.WriteLine($"Processando a request #{numeroRequest}...\n");
        if (conexao.Connected)
        {
            byte[] bytesRequisicao = new byte[1024];
            conexao.Receive(bytesRequisicao, bytesRequisicao.Length, 0);
            string textoRequisicao = Encoding.UTF8.GetString(bytesRequisicao).Replace((char)0, ' ').Trim();

            if (textoRequisicao.Length > 0)
            {
                Console.WriteLine($"\n{textoRequisicao}\n");
                
                string[] linhas = textoRequisicao.Split("\r\n");
                int iPrimeiroEspaco = linhas[0].IndexOf(' ');
                int iSegundoEspaco = linhas[0].LastIndexOf(' ');
                string metodoHttp = linhas[0].Substring(0,iPrimeiroEspaco);
                string recursoBuscado = linhas[0].Substring(iPrimeiroEspaco + 1, iSegundoEspaco - iPrimeiroEspaco - 1);
                string versaoHttp = linhas[0].Substring(iSegundoEspaco + 1);
                iPrimeiroEspaco = linhas[1].IndexOf(' ');
                string nomeHost = linhas[1].Substring(iPrimeiroEspaco + 1);

                byte[] bytesCabecalho = null;
                var bytesConteudo = this.LerArquivo(recursoBuscado);
                if(bytesConteudo.Length > 0)
                {
                    bytesCabecalho = this.GerarCabecalho(versaoHttp, "text/html;charset=Utf-8", "200", bytesConteudo.Length);
                }
                else
                {
                    bytesConteudo = Encoding.UTF8.GetBytes("<h1>Erro 404 - Arquivo Não Encontrado</h1>");

                    bytesCabecalho = this.GerarCabecalho(versaoHttp, "text/html;charset=Utf-8", "404", bytesConteudo.Length);
                }
                
                var bytesEnviados = conexao.Send(bytesCabecalho, bytesCabecalho.Length, 0);
                bytesEnviados += conexao.Send(bytesConteudo, bytesConteudo.Length, 0);
                Thread.Sleep(500);
                conexao.Close();
                Console.WriteLine($"\n{bytesEnviados} bytes enviados em resposta à requisição #{numeroRequest}");
            }

        }
        Console.WriteLine($"O processamento do request {numeroRequest} foi finalizado!");
    }

    public byte[] GerarCabecalho(string versaoHttp, string tipoMime, string codigoHttp, int qtdBytes = 0)
    {
        StringBuilder texto = new StringBuilder();
        texto.Append($"{versaoHttp} {codigoHttp} {Environment.NewLine}");
        texto.Append($"Server: Servidor Http Simples 1.0{Environment.NewLine}");
        texto.Append($"Content-Type: {tipoMime}{Environment.NewLine}");
        texto.Append($"Content-Length: {qtdBytes}{Environment.NewLine}");
        return Encoding.UTF8.GetBytes(texto.ToString());
    }

    private void CriarhtmlExemplo()
    {
        StringBuilder html = new StringBuilder();
        html.Append("<!DOCTYPE html><html lang=\"pt-br\"><head><meta charset=\"UTF-8\">");
        html.Append("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
        html.Append("<title>Página Estática</title></head><body>");
        html.Append("<h1>Página Estática</h1></body></html>");
        this.HtmlExemplo = html.ToString();
        
    }

    public byte[] LerArquivo(string recurso)
    {
        string diretorio = "C:\\dev\\ServidorHTTP\\www";
        string filePath = diretorio + recurso.Replace("/", "\\");
        if(File.Exists(filePath))
        {
            return File.ReadAllBytes(filePath);
        }
        return new byte[0];
    }

}