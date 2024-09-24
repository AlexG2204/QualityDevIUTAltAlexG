class Livre : Media {
    public string Author;
    public string Description;

    public DVD(string title, int reference_ID, int available_Copies, string author, string description)
        : base(title, reference_ID, available_Copies) {
        Author = author;
        Description = description;
    }

    public override void AfficherInfos()
    {
        base.AfficherInfos();  // Affiche les informations de base
        Console.WriteLine($"Auteur: {Auteur}");
    }

}