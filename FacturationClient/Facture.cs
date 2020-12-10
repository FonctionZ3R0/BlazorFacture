using System;
namespace FacturationClient
{
    public class Facture
    {
        public string nomClient { get; set; }

        public int numFacture { get; set; }
       
        public DateTime dateEmission { get; set; }
        
        public DateTime dateReglementAttendu { get; set; }
        
        public double montantDu { get; set; }
        
        public double montantRegle { get; set; }

        public Facture(string p_nomClient, int p_numFacture, DateTime p_dateEmission, DateTime p_dateReglementAttendu, double p_montantDu, double p_montantRegle)
        {
            nomClient = p_nomClient;
            numFacture = p_numFacture;
            dateEmission = p_dateEmission;
            dateReglementAttendu = p_dateReglementAttendu;
            montantDu = p_montantDu;
            montantRegle = p_montantRegle;
        }
    }
}