using System.Text;

namespace Rubrica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Contatto> contatti = new List<Contatto>();

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Rubrica.csv");

            StreamReader reader = null;

            if (!File.Exists(path))
            {
                Console.WriteLine("Il file "+path+" non esiste, verrà creato un nuovo file.");
                File.WriteAllText(path, "");
            }

            using (reader = new StreamReader(path)) {

            while(!reader.EndOfStream)
            {
                var riga = reader.ReadLine();
                var valori = riga.Split(',');
                contatti.Add(new Contatto(valori[0], valori[1], valori[2], valori[3]));
            }
            }

            StampaMessaggio();

            bool again = true;
            do
            {

                int opzione = Convert.ToInt32(Console.ReadLine());
                switch (opzione)
                {
                    case 1:
                        Console.Write("Inserisci nome: ");
                        string tName = Console.ReadLine();
                        Console.Write("Inserisci cognome: ");
                        string tSurn = Console.ReadLine();
                        Console.Write("Inserisci numero: ");
                        string tNum = Console.ReadLine();
                        Console.Write("Inserisci email: ");
                        string tMail = Console.ReadLine();

                        contatti.Add(new Contatto(tName, tSurn, tNum, tMail));
                        Console.Write("Contatto inserito! vuoi fare altro? (Y = si    N = no) ");
                        
                        break;
                    case 2:
                        Console.WriteLine("Chi vuoi cercare?");
                        string personaDaCercare = Console.ReadLine();
                        List<Contatto> contattiTrovati = contatti.FindAll(contatti => contatti.nome.Equals(personaDaCercare, StringComparison.OrdinalIgnoreCase) || contatti.cognome.Equals(personaDaCercare, StringComparison.OrdinalIgnoreCase));
                        Console.WriteLine("Contatti trovati: ");
                        foreach(Contatto item in contattiTrovati)
                        {
                            Console.WriteLine($"Nome: {item.nome}, Cognome: {item.cognome}, Telefono: {item.telefono}, Email: {item.email}");
                        }
                        Console.Write("Vuoi fare altro? (Y = si    N = no) ");
                        break;
                    case 3:
                        Console.Write("Inserisci il nome del contatto da eliminare: ");
                        string nomeDaEliminare = Console.ReadLine();
                        contatti.RemoveAll(contatti => contatti.nome.Equals(nomeDaEliminare, StringComparison.OrdinalIgnoreCase));
                        Console.WriteLine(nomeDaEliminare + " è stato eliminato dalla rubrica. vuoi fare altro? (Y = si    N = no)");

                        break;
                    case 4:
                        foreach (Contatto item in contatti.OrderBy(item => item.cognome))
                        {
                            Console.WriteLine($"Nome:  {item.nome}, Cognome: {item.cognome}, Telefono: {item.telefono}, Email: {item.email}");
                        }
                        Console.Write("Vuoi fare altro? (Y = si    N = no) ");
                        break;
                    case 5:
                        StringBuilder update = new StringBuilder();
                        foreach (Contatto item in contatti)
                        {
                            update.AppendLine(item.nome + "," + item.cognome + "," + item.telefono + "," + item.email);
                        }
                        File.WriteAllText(path, update.ToString());
                        Console.WriteLine("Rubrica salvata con successo! Vuoi fare altro? (Y = si    N = no)");
                        break;
                    case 6:
                        again = false;
                        break;
                    default:
                        Console.WriteLine("Opzione non valida, riprova.");
                        break;
                }
                string risposta = Console.ReadLine();
                if (risposta == "N" || risposta == "n")
                {
                    again = false;
                }
                else if (risposta == "Y" || risposta == "y")
                {
                    StampaMessaggio();
                }
            } while (again);
            reader.Close();
        }
        static void StampaMessaggio()
        {
            Console.WriteLine("1. Aggiungi contatto");
            Console.WriteLine("2. Cerca contatto");
            Console.WriteLine("3. Elimina contatto:");
            Console.WriteLine("4. Visualizza tutti");
            Console.WriteLine("5. Salva rubrica");
            Console.WriteLine("6. Esci");
            Console.Write("Scegli un opzione: ");
        }
    }
}
