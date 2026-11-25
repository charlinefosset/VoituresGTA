namespace VoituresGTA;
/*
    CONSIGNES
    1. Déclarer un tableau contenant cinq véhicules :
        - Banshee
        - Zentorno
        - Sultan
        - Sanchez
        - Buzzard
    2. Afficher tous les véhicules du garage avec une boucle for.
    3. Demander au joueur de saisir le numéro du véhicule qu'il souhaite remplacer (de 1 à 5).
    4. Demander le nom du nouveau véhicule.
    5. Remplacer l'ancien véhicule par le nouveau dans le tableau.
    6. Afficher le contenu actualisé du garage.
*/
class Program
{
    static void Main(string[] args)
    {
        string[] vehicles = { "Banshee", "Zentoro", "Sultan", "Sanchez", "Buzzard" };
        for (int tableau = 0; tableau < vehicles.Length; tableau++)
        {
            Console.WriteLine((tableau+1).ToString + ". " + (vehicles[tableau]));
        }
        Console.WriteLine("Choisissez un véhicule à remplacer(1 à 5)");
       int cartoreplace = Convert.ToInt32(Console.ReadLine()) ;
        
        Console.Write("\n> Quel sera le nom du nouveau véhicule?");
        String newCar = Console.ReadLine();

        vehicles[cartoreplace - 1] = newCar;
            
        Console.WriteLine("Véchicules dans le garage : ");    
        for (int tableau = 0; tableau < vehicles.Length; tableau++)
        {
            Console.WriteLine(vehicles[tableau]);
        }
    }
}