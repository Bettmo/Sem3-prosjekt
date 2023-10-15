namespace Nøsted.Models
{
    public class ChecklistController
    {
        //Legg til datafeltene fra skjemaet
        // Datafelt for sjekkliste mekanisk
        public int sjekklisteID { get; set; }
        public string clutch { get; set; }
        public string bremser { get; set; }
        public string lagerForTrommel { get; set; }
        public string pto { get; set; }
        public string kjedestrammer { get; set; }
        public string pinionLager { get; set; }
        public string kileKjedehjul { get; set; }
        
        // Datafelt for sjekkliste Hydraulisk
        public int sjekklisteID_FK { get; set; }
        public string sylinderLekkasje { get; set; }
        public string slangeSkade { get; set; }
        public string hydraullikBlokk { get; set; }
        public string oljeTank { get; set; }
        public string oljeGirboks { get; set; }
        public string ringsylinder { get; set; }
        public string bremseSylinder { get; set; }
        
        // Datafelt for sjekkliste elektrisk kommentar
        public int sjekklisteID_FK { get; set; }
        public string ledningsNett { get; set; }
        public string testRadio { get; set; }
        public string testeKnappekasse { get; set; }
        public string bar { get; set; }
        public string testVinsjKjørAlt { get; set; }
        public string trekkraftKN { get; set; }
        public string kommentar { get; set; }
    }
}
