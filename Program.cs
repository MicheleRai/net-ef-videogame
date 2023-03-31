using net_ef_videogame;


bool esegui = true;
var nl = Environment.NewLine;
var linea = $"/////////////";
var context = new VideogameContext();

while (esegui)
{
    Console.WriteLine(
        $"Benvenuti nel gestore videogames: {nl}" +
        $"Prego scegliere un comando: {nl}" +
        $"aggiungi ->  Aggiungi gioco o software house alla lista.{nl}" +
        $"cancella -> Elimina gioco dalla lista.{nl}" +
        $"filtra -> Ricerca giochi per nome.{nl}" +
        $"cerca -> Cerca gioco o lista giochi di una software house per ID. {nl}" +
        
        $"esci -> Chiudi il programma.");

    Console.Write($"Digita il comando -> ");
    string comando = Console.ReadLine() ?? "";
    comando = comando.Replace(" ", "");
    comando = comando.ToLower();

    string cmd = "";
    cmd = cmd.Replace(" ", "");
    cmd = cmd.ToLower();

    switch (comando)
    {

        case "filtra":
            Console.Write(
            $"{linea}{nl}" +
            $"Inserisci nome gioco: ");
            cmd = Console.ReadLine() ?? "";

            var vgList = context.Videogames.Where(v => v.Nome.Contains(cmd)).ToList();

            Console.WriteLine(linea);
            foreach (var v in vgList)
            {
                Console.WriteLine(v);
                Console.WriteLine(linea);
            }

            break;


        case "cerca":
            Console.WriteLine("Cosa vuoi cercare? (videogame / software house)");
            cmd = Console.ReadLine() ?? "";
            if (cmd == "videogame")
            {
                Console.Write("Inserisci ID gioco: ");
                var idSearch = long.Parse(Console.ReadLine() ?? "");
                var vg = context.Videogames.Where(v => v.Id == idSearch).FirstOrDefault();
                Console.WriteLine(vg);
            }
            else if (cmd == "software house")
            {
                Console.Write("Inserisci ID software house: ");
                var idHouse = long.Parse(Console.ReadLine() ?? "");
                var vg = context.Videogames.Where(v => v.SoftwareHouseId == idHouse).ToList();
                Console.WriteLine(linea);
                foreach (var v in vg)
                {
                    Console.WriteLine(v);
                    Console.WriteLine(linea);
                }
            }

            break;

        case "aggiungi":
            Console.WriteLine("Cosa vuoi aggiungere? (videogame / software house)");
            cmd = Console.ReadLine() ?? "";
            if (cmd == "videogame")
            {
                var vg = new Videogame();

                Console.Write(
                $"{linea}{nl}" +
                $"Inserisci nome gioco: ");
                vg.Nome = Console.ReadLine() ?? "";

                Console.Write($"Inserisci descrizione gioco: ");
                vg.Trama = Console.ReadLine() ?? "";

                Console.Write("Inserisci Id della software house: ");
                vg.SoftwareHouseId = Convert.ToInt64(Console.ReadLine());
                vg.DataUscita = DateTime.Now;

                context.Videogames.Add(vg);
                context.SaveChanges();

            }
            else if (cmd == "software house")
            {
                var sh = new SoftwareHouse();

                Console.Write("Inserisci nome: ");
                sh.Nome = Console.ReadLine() ?? "";

                Console.Write("Inserisci nazione: ");
                sh.Paese = Console.ReadLine() ?? "";

                Console.Write("Inserisci cittá: ");
                sh.Citta = Console.ReadLine() ?? "";

                Console.Write("Inserisci partita iva: ");
                sh.Iva = Convert.ToInt64(Console.ReadLine());

                context.SoftwareHouse.Add(sh);
                context.SaveChanges();
            }
            Console.WriteLine(linea);
            break;


        case "cancella":
            Console.Write(
            $"{linea}{nl}" +
            $"Inserisci ID gioco: ");
            long id = Convert.ToInt64(Console.ReadLine()?? "");

            context.Remove(context.Videogames.Where(v => v.Id == id).FirstOrDefault());
            context.SaveChanges();
            Console.WriteLine(linea);
            break;


        case "esci":
            esegui = false;
            break;

        default:
            Console.WriteLine(
                $"{linea}{nl}" +
                $"Comando '{cmd}' non riconosciuto. {nl}" +
                $"{linea}{nl}");
            break;
    }

}

