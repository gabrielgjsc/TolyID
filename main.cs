using System;
using System.Collections.Generic;
using System.Globalization;

// Definição das classes de dados
public class AnimalIdentification
{
    public int Id { get; set; }
    public double Peso { get; set; }
    public string NumeroIdentificacao { get; set; }
    public string NumeroMicrochip { get; set; }
    public string LocalCaptura { get; set; }
    public DateTime DataCaptura { get; set; }
    public TimeSpan HorarioCaptura { get; set; }
    public string EquipeResponsavel { get; set; }
    public string Instituicao { get; set; }
    public string ContatoResponsavel { get; set; }
    public string Observacoes { get; set; }
}

public class FichaAnestesica
{
    public string TipoAnestesicoDose { get; set; }
    public string ViaAdministracao { get; set; }
    public TimeSpan TempoAnestesia { get; set; }
    public string Aplicacao { get; set; }
    public TimeSpan Inducao { get; set; }
    public TimeSpan Retorno { get; set; }
    public int FC { get; set; } // Frequência Cardíaca
    public List<ParametrosFisiologicos> Parametros { get; set; } = new List<ParametrosFisiologicos>();
    public List<Amostra> Amostras { get; set; } = new List<Amostra>();
}

public class ParametrosFisiologicos
{
    public int FR { get; set; } // Frequência Respiratória
    public double Oximetria { get; set; }
    public double Temperatura { get; set; }
    public string Observacoes { get; set; }
}

public class Amostra
{
    public bool Sangue { get; set; }
    public bool Fezes { get; set; }
    public bool Pelo { get; set; }
    public bool Ectoparasitos { get; set; }
    public bool Sawb { get; set; }
    public string Local { get; set; }
    public string Outros { get; set; }
}

public class Biometria
{
    public double ComprimentoTotal { get; set; }
    public double ComprimentoOrelha { get; set; }
    public int NumeroCintas { get; set; }
    public double ComprimentoCabeca { get; set; }
    public double ComprimentoCauda { get; set; }
    public double ComprimentoMaoSemUnha { get; set; }
    public double LarguraCabeca { get; set; }
    public double LarguraCauda { get; set; }
    public double ComprimentoUnhaMao { get; set; }
    public string PadraoEscudoCefalico { get; set; }
    public double ComprimentoEscudoEscapular { get; set; }
    public double ComprimentoPeSemUnha { get; set; }
    public double ComprimentoEscudoCefalico { get; set; }
    public double SemicircunferenciaEscudoEscapular { get; set; }
    public double ComprimentoUnhaPe { get; set; }
    public double LarguraEscudoCefalico { get; set; }
    public double ComprimentoEscudoPelvico { get; set; }
    public double ComprimentoPenis { get; set; }
    public double LarguraInterOrbital { get; set; }
    public double SemicircunferenciaEscudoPelvico { get; set; }
    public double LarguraBasePenis { get; set; }
    public double LarguraInterLacrimal { get; set; }
    public double LarguraSegundaCinta { get; set; }
    public double ComprimentoClitorios { get; set; }
    public string Observacoes { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Coleta dos dados de identificação do animal
        Console.WriteLine("Registro de Animal");

        var animalIdentification = new AnimalIdentification();

        Console.Write("Peso (KG): ");
        animalIdentification.Peso = double.Parse(Console.ReadLine());

        Console.Write("Número de Identificação: ");
        animalIdentification.NumeroIdentificacao = Console.ReadLine();

        Console.Write("Número do Microchip: ");
        animalIdentification.NumeroMicrochip = Console.ReadLine();

        Console.Write("Local de Captura: ");
        animalIdentification.LocalCaptura = Console.ReadLine();

        while (true)
        {
            try
            {
                Console.Write("Data de Captura (dd/MM/yyyy): ");
                animalIdentification.DataCaptura = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Data inválida. Tente novamente.");
            }
        }

        while (true)
        {
            try
            {
                Console.Write("Horário de Captura (HH:mm): ");
                animalIdentification.HorarioCaptura = TimeSpan.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Hora inválida. Tente novamente.");
            }
        }

        Console.Write("Equipe Responsável: ");
        animalIdentification.EquipeResponsavel = Console.ReadLine();

        Console.Write("Instituição: ");
        animalIdentification.Instituicao = Console.ReadLine();

        Console.Write("Contato do Responsável: ");
        animalIdentification.ContatoResponsavel = Console.ReadLine();

        Console.Write("Observações: ");
        animalIdentification.Observacoes = Console.ReadLine();

        // Coleta dos dados da ficha anestésica
        Console.WriteLine("\nFicha Anestésica");

        var fichaAnestesica = new FichaAnestesica();

        Console.Write("Tipo de Anestésico/Dose: ");
        fichaAnestesica.TipoAnestesicoDose = Console.ReadLine();

        Console.Write("Via de Administração: ");
        fichaAnestesica.ViaAdministracao = Console.ReadLine();

        Console.Write("Tempo de Anestesia (HH:mm): ");
        fichaAnestesica.TempoAnestesia = TimeSpan.Parse(Console.ReadLine());

        Console.Write("Aplicação: ");
        fichaAnestesica.Aplicacao = Console.ReadLine();

        Console.Write("Indução (HH:mm): ");
        fichaAnestesica.Inducao = TimeSpan.Parse(Console.ReadLine());

        Console.Write("Retorno (HH:mm): ");
        fichaAnestesica.Retorno = TimeSpan.Parse(Console.ReadLine());

        Console.Write("FC (Frequência Cardíaca): ");
        fichaAnestesica.FC = int.Parse(Console.ReadLine());

        // Coleta dos parâmetros fisiológicos
        Console.WriteLine("\nParâmetros Fisiológicos (serão registrados a cada 10 minutos):");

        while (true)
        {
            var parametros = new ParametrosFisiologicos();

            Console.Write("FR (Frequência Respiratória): ");
            parametros.FR = int.Parse(Console.ReadLine());

            Console.Write("Oximetria (%): ");
            parametros.Oximetria = double.Parse(Console.ReadLine());

            Console.Write("Temperatura (°C): ");
            parametros.Temperatura = double.Parse(Console.ReadLine());

            Console.Write("Observações: ");
            parametros.Observacoes = Console.ReadLine();

            fichaAnestesica.Parametros.Add(parametros);

            Console.Write("Deseja adicionar mais parâmetros fisiológicos? (s/n): ");
            string resposta = Console.ReadLine().ToLower();
            if (resposta != "s")
            {
                break;
            }
        }

        // Coleta dos dados das amostras
        Console.WriteLine("\nAmostras Coletadas:");

        var amostras = new Amostra();

        Console.Write("Sangue (s/n): ");
        amostras.Sangue = Console.ReadLine().ToLower() == "s";

        Console.Write("Fezes (s/n): ");
        amostras.Fezes = Console.ReadLine().ToLower() == "s";

        Console.Write("Pelo (s/n): ");
        amostras.Pelo = Console.ReadLine().ToLower() == "s";

        Console.Write("Ectoparasitos (s/n): ");
        amostras.Ectoparasitos = Console.ReadLine().ToLower() == "s";

        Console.Write("Sawb (s/n): ");
        amostras.Sawb = Console.ReadLine().ToLower() == "s";

        Console.Write("Local: ");
        amostras.Local = Console.ReadLine();

        Console.Write("Outros: ");
        amostras.Outros = Console.ReadLine();

        fichaAnestesica.Amostras.Add(amostras);

        // Coleta dos dados de biometria
        Console.WriteLine("\nBiometria:");

        var biometria = new Biometria();

        Console.Write("Comprimento total: ");
        biometria.ComprimentoTotal = double.Parse(Console.ReadLine());

        Console.Write("Comprimento de orelha: ");
        biometria.ComprimentoOrelha = double.Parse(Console.ReadLine());

        Console.Write("Número de cintas: ");
        biometria.NumeroCintas = int.Parse(Console.ReadLine());

        Console.Write("Comprimento cabeça: ");
        biometria.ComprimentoCabeca = double.Parse(Console.ReadLine());

        Console.Write("Comprimento cauda: ");
        biometria.ComprimentoCauda = double.Parse(Console.ReadLine());

        Console.Write("Comprimento mão sem unha: ");
        biometria.ComprimentoMaoSemUnha = double.Parse(Console.ReadLine());

        Console.Write("Largura cabeça: ");
        biometria.LarguraCabeca = double.Parse(Console.ReadLine());

        Console.Write("Largura cauda: ");
        biometria.LarguraCauda = double.Parse(Console.ReadLine());

        Console.Write("Comprimento unha da mão: ");
        biometria.ComprimentoUnhaMao = double.Parse(Console.ReadLine());

        Console.Write("Padrão escudo cefálico: ");
        biometria.PadraoEscudoCefalico = Console.ReadLine();

        Console.Write("Comprimento escudo escapular: ");
        biometria.ComprimentoEscudoEscapular = double.Parse(Console.ReadLine());

        Console.Write("Comprimento pé sem unha: ");
        biometria.ComprimentoPeSemUnha = double.Parse(Console.ReadLine());

        Console.Write("Comprimento escudo cefálico: ");
        biometria.ComprimentoEscudoCefalico = double.Parse(Console.ReadLine());

        Console.Write("Semicircunferência escudo escapular: ");
        biometria.SemicircunferenciaEscudoEscapular = double.Parse(Console.ReadLine());

        Console.Write("Comprimento unha do pé: ");
        biometria.ComprimentoUnhaPe = double.Parse(Console.ReadLine());

        Console.Write("Largura escudo cefálico: ");
        biometria.LarguraEscudoCefalico = double.Parse(Console.ReadLine());

        Console.Write("Comprimento escudo pélvico: ");
        biometria.ComprimentoEscudoPelvico = double.Parse(Console.ReadLine());

        Console.Write("Comprimento do pênis: ");
        biometria.ComprimentoPenis = double.Parse(Console.ReadLine());

        Console.Write("Largura inter-orbital: ");
        biometria.LarguraInterOrbital = double.Parse(Console.ReadLine());

        Console.Write("Semicircunferência escudo pélvico: ");
        biometria.SemicircunferenciaEscudoPelvico = double.Parse(Console.ReadLine());

        Console.Write("Largura base do pênis: ");
        biometria.LarguraBasePenis = double.Parse(Console.ReadLine());

        Console.Write("Largura inter-lacrimal: ");
        biometria.LarguraInterLacrimal = double.Parse(Console.ReadLine());

        Console.Write("Largura na 2ª cinta: ");
        biometria.LarguraSegundaCinta = double.Parse(Console.ReadLine());

        Console.Write("Comprimento do clitórios: ");
        biometria.ComprimentoClitorios = double.Parse(Console.ReadLine());

        Console.Write("Observações: ");
        biometria.Observacoes = Console.ReadLine();

        // Exibição dos dados coletados
        Console.WriteLine("\nDados do Animal Registrado:");
        Console.WriteLine($"Peso (KG): {animalIdentification.Peso}");
        Console.WriteLine($"Número de Identificação: {animalIdentification.NumeroIdentificacao}");
        Console.WriteLine($"Número do Microchip: {animalIdentification.NumeroMicrochip}");
        Console.WriteLine($"Local de Captura: {animalIdentification.LocalCaptura}");
        Console.WriteLine($"Data de Captura: {animalIdentification.DataCaptura:dd/MM/yyyy}");
        Console.WriteLine($"Horário de Captura: {animalIdentification.HorarioCaptura}");

        // Exibição dos dados da ficha anestésica
        Console.WriteLine("\nFicha Anestésica:");
        Console.WriteLine($"Tipo de Anestésico/Dose: {fichaAnestesica.TipoAnestesicoDose}");
        Console.WriteLine($"Via de Administração: {fichaAnestesica.ViaAdministracao}");
        Console.WriteLine($"Tempo de Anestesia: {fichaAnestesica.TempoAnestesia}");
        Console.WriteLine($"Aplicação: {fichaAnestesica.Aplicacao}");
        Console.WriteLine($"Indução: {fichaAnestesica.Inducao}");
        Console.WriteLine($"Retorno: {fichaAnestesica.Retorno}");
        Console.WriteLine($"FC (Frequência Cardíaca): {fichaAnestesica.FC}");

        // Exibição dos parâmetros fisiológicos
        Console.WriteLine("\nParâmetros Fisiológicos:");
        foreach (var parametros in fichaAnestesica.Parametros)
        {
            Console.WriteLine($"FR (Frequência Respiratória): {parametros.FR}");
            Console.WriteLine($"Oximetria (%): {parametros.Oximetria}");
            Console.WriteLine($"Temperatura (°C): {parametros.Temperatura}");
            Console.WriteLine($"Observações: {parametros.Observacoes}");
        }

        // Exibição dos dados das amostras
        Console.WriteLine("\nAmostras Coletadas:");
        foreach (var amostra in fichaAnestesica.Amostras)
        {
            Console.WriteLine($"Sangue: {(amostra.Sangue ? "Sim" : "Não")}");
            Console.WriteLine($"Fezes: {(amostra.Fezes ? "Sim" : "Não")}");
            Console.WriteLine($"Pelo: {(amostra.Pelo ? "Sim" : "Não")}");
            Console.WriteLine($"Ectoparasitos: {(amostra.Ectoparasitos ? "Sim" : "Não")}");
            Console.WriteLine($"Sawb: {(amostra.Sawb ? "Sim" : "Não")}");
            Console.WriteLine($"Local: {amostra.Local}");
            Console.WriteLine($"Outros: {amostra.Outros}");
        }

        // Exibição dos dados de biometria
        Console.WriteLine("\nBiometria:");
        Console.WriteLine($"Comprimento total: {biometria.ComprimentoTotal} cm");
        Console.WriteLine($"Comprimento de orelha: {biometria.ComprimentoOrelha} cm");
        Console.WriteLine($"Número de cintas: {biometria.NumeroCintas}");
        Console.WriteLine($"Comprimento cabeça: {biometria.ComprimentoCabeca} cm");
        Console.WriteLine($"Comprimento cauda: {biometria.ComprimentoCauda} cm");
        Console.WriteLine($"Comprimento mão sem unha: {biometria.ComprimentoMaoSemUnha} cm");
        Console.WriteLine($"Largura cabeça: {biometria.LarguraCabeca} cm");
        Console.WriteLine($"Largura cauda: {biometria.LarguraCauda} cm");
        Console.WriteLine($"Comprimento unha da mão: {biometria.ComprimentoUnhaMao} cm");
        Console.WriteLine($"Padrão escudo cefálico: {biometria.PadraoEscudoCefalico}");
        Console.WriteLine($"Comprimento escudo escapular: {biometria.ComprimentoEscudoEscapular} cm");
        Console.WriteLine($"Comprimento pé sem unha: {biometria.ComprimentoPeSemUnha} cm");
        Console.WriteLine($"Comprimento escudo cefálico: {biometria.ComprimentoEscudoCefalico} cm");
        Console.WriteLine($"Semicircunferência escudo escapular: {biometria.SemicircunferenciaEscudoEscapular} cm");
        Console.WriteLine($"Comprimento unha do pé: {biometria.ComprimentoUnhaPe} cm");
        Console.WriteLine($"Largura escudo cefálico: {biometria.LarguraEscudoCefalico} cm");
        Console.WriteLine($"Comprimento escudo pélvico: {biometria.ComprimentoEscudoPelvico} cm");
        Console.WriteLine($"Comprimento do pênis: {biometria.ComprimentoPenis} cm");
        Console.WriteLine($"Largura inter-orbital: {biometria.LarguraInterOrbital} cm");
        Console.WriteLine($"Semicircunferência escudo pélvico: {biometria.SemicircunferenciaEscudoPelvico} cm");
        Console.WriteLine($"Largura base do pênis: {biometria.LarguraBasePenis} cm");
        Console.WriteLine($"Largura inter-lacrimal: {biometria.LarguraInterLacrimal} cm");
        Console.WriteLine($"Largura na 2ª cinta: {biometria.LarguraSegundaCinta} cm");
        Console.WriteLine($"Comprimento do clitórios: {biometria.ComprimentoClitorios} cm");
        Console.WriteLine($"Observações: {biometria.Observacoes}");
    }
