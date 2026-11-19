namespace Boss_final;

/*
    CONSIGNES
    Vous développez le système de combat d'un RPG. Le héros affronte un boss final.

    Le boss possède 150 PV. Le héros possède une arme qui inflige 40 dégâts par attaque.

    Vous devez créer trois méthodes :

    1. CalculateWeaponDamage()
        - Reçoit la puissance de l'arme en paramètre.
        - Retourne les dégâts infligés (ici, la puissance de l'arme).
    2. CalculateRemainingHealth()
        - Reçoit les PV actuels du boss et les dégâts infligés.
        - Calcule les nouveaux PV du boss.
        - Retourne les nouveaux PV.
    3. DisplayBossStatus()
        - Reçoit les PV du boss.
        - Affiche son état :
        - Si ses PV sont supérieurs à 0 : "Le boss est toujours vivant !".
        - Sinon : "Félicitations ! Le boss est vaincu !".
    Dans Main() :
        1. Initialisez les PV du boss à 150.
        2. Calculez les dégâts de l'arme.
        3. Infligez les dégâts au boss.
        4. Affichez son état.
        5. Recommencez une deuxième attaque.
        6. Affichez à nouveau son état.
    BONUS :
        - Inspirez-vous de votre combat du cours de Logique & Algorithmes pour aller plus loin dans cet exercice
 */
class Program
{
    // Méthode 1 : calcule les dégâts
    static int CalculateWeaponDamage(int weaponPower)
    {
        return weaponPower; // besoin de rien de plus ici car il n'y a pas d'effets
    }

    // Méthode 2 : retire les PV du boss
    static int CalculateRemainingHealth(int bossHealth, int damage)
    {
        int remainingHealth = bossHealth - damage;

        if (remainingHealth < 0) // On s'assure de ne pas afficher un PV négatif
        {
            remainingHealth = 0; // Le nombre minimum de PV sera 0
        }

        return remainingHealth;
    }

    // Méthode 3 : affiche l'état du boss
    static void DisplayBossStatus(int bossHealth)
    {
        Console.WriteLine("PV du boss : " + bossHealth);

        if (bossHealth > 0)
        {
            Console.WriteLine("Le boss est toujours vivant !");
        }
        else
        {
            Console.WriteLine("Félicitations ! Le boss est vaincu !");
        }
    }
    
    static void Main(string[] args)
    {
        // Variables locales (différentes des paramètres de méthodes)
        int bossHealth = 150;
        int weaponPower = 40;

        // Première attaque
        int damage = CalculateWeaponDamage(weaponPower);
        bossHealth = CalculateRemainingHealth(bossHealth, damage);

        DisplayBossStatus(bossHealth);

        Console.WriteLine("----------------");

        // Deuxième attaque
        damage = CalculateWeaponDamage(weaponPower);
        bossHealth = CalculateRemainingHealth(bossHealth, damage);

        DisplayBossStatus(bossHealth);
    }
}