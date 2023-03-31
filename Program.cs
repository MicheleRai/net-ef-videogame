using 
    (VideogameContext db = new VideogameContext())
{
    SoftwareHouse provasoftwareHouse = new() { Nome = "Ubisoft", Iva =11111111111, Citta = "Prova", Paese = "Prova" };
    db.Add(provasoftwareHouse);
    db.SaveChanges();
}

