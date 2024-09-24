public class Media {
    public string Title;
    public int Reference_ID;
    public int Available_Copies;

    public Media(string title, int reference_ID, int available_Copies) {
        Title = title;
        Reference_ID = reference_ID;
        Available_Copies = available_Copies;
    }

    public virtual void AfficherInfos()
    {
        Console.WriteLine($"Titre: {Title}, Numéro de référence: {Reference_ID}, Nombre d'exemplaires disponibles: {Available_Copies}");
    }

}
