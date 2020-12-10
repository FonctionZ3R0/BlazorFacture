using System;
using System.Collections.Generic;
using System.Numerics;

namespace FacturationClient
{
    public class Manager
    {
        public List<Facture> listFactures;
        public double totalAPayer = 0;
        public double totalPaye = 0;
        public Manager(int nbFactures)
        {
            listFactures = new List<Facture>();
            string[] clients = new[]
            {
                "Bool", "Kool", "Dool", "Cool", "Mool", "Rool", "Pool", "Hool", "Wool", "Zool", "Fool"
            };
            
            for (int i = 0; i < nbFactures; i++)
            {
                var rng = new Random();
                string nomClient = clients[rng.Next(clients.Length)];
                DateTime dateEmission = DateTime.Now.AddDays(rng.Next(-90, 0));
                DateTime dateReglementAttendu = dateEmission.AddDays(rng.Next(0, 90));
                double montantDu = rng.Next(5432, 10000) + Math.Round(rng.NextDouble(), 2);
                double montantRegle = rng.Next(0, Convert.ToInt32(montantDu) / 10) * 10;
                listFactures.Add(new Facture(nomClient, i, dateEmission, dateReglementAttendu, montantDu,
                    montantRegle));
                totalAPayer += montantDu;
                totalPaye += montantRegle;
            }
        }
    }
}