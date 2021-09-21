using System;

namespace ConsoleAppProgObjet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

           Ordinateur monOrdi = new Ordinateur("Hp Notebook", 2988997, 800, "2.90GHz;6Go NVIDIA GTX 2070;4Go");
           Ordinateur tonOrdi = new Ordinateur("Macbook", 79197, 2000, "3.50GHz;4Go Intel;8Go");

            monOrdi.Decrire();
            Console.ReadKey(true);
            tonOrdi.Decrire();


            while (Console.ReadKey(true).Key != ConsoleKey.A)
            {
                Console.WriteLine("Appuyer sur 'A'");
            }
        }
    }

    
    interface IDescription
    {
        void Decrire()
        {

        }
    }



    //Ordinateur
    class Ordinateur : IDescription
    {
        public string nom { get; set; }
        public int reference { get; set; }
        public int prix { get; set; }
        public string caracteristiques { get; set; }

        //Constructeur
        public Ordinateur(string nom, int reference, int prix, string carac)
        {
            this.nom = nom;
            this.reference = reference;
            this.prix = prix;
            this.caracteristiques = carac; 
        }

        public virtual void Decrire()
        {
            Console.WriteLine(nom + " ( " + reference + " )");
            DecrireCaracteristiques();
            Console.WriteLine("Prix TTC :" + prix);
            Console.WriteLine("************************************************");
        }

        protected void DecrireCaracteristiques()
        {
            Console.WriteLine("*** Les caractétistiques de l'ordinateur ***");
            string[] carac = caracteristiques.Split(";");
            Console.WriteLine("CPU :"+carac[0]);
            Console.WriteLine("GPU :"+carac[1]);
            Console.WriteLine("RAM :"+carac[2]);
        }

    }
    

    //Ordinateur Portable
    class Portable : Ordinateur
    {
        string tailleEcran;

        public Portable(string nom, int reference, int prix, string carac, string taille) : base(nom, reference, prix, carac)
        {
            this.tailleEcran = taille;
        }

        public override void Decrire()
        {
            base.Decrire();
        }
    }
    
   
}
