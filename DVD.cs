class DVD : Media {
    public double Durée; // en heures

    public DVD(string title, int reference_ID, int available_Copies, double duree)
        : base(title, reference_ID, available_Copies) {
        Durée = durée;
    }

    public override void AfficherInfos()
    {
        base.AfficherInfos();  // Affiche les informations de base
        Console.WriteLine($"Durée: {Duree} heures");
    }

}