using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeliIdeaGeneraattori
{
    public partial class Form1 : Form
    {
        //Lista satunnaisia elementtejä peli idean generoimiseen

        private readonly string[] genret = { "Toiminta", "Seikkailu", "Roolipeli", "Pulmapeli", "Strategia", "Kauhu", "Simulaatio" };
        private readonly string[] miljoot = { "Avaruus", "Keskiaikainen", "Post-apokalypsi", "Moderni kaupunki", "Fantasia maailma", "Kyberpunk dystopia" };
        private readonly string[] tavoitteet = { "Pelasta maailma", "Pakene labyrintista", "Löydä piillotetut aarteet", "Survive against all odds", "Ratkaise mysteeri", "Valloita territorio" };
        private readonly string[] pelaajat = { "Sankari", "Vihollinen", "Robotti", "Alien", "Etsivä", "Soturi", "Velho", "Kyberneettinen organismi" };
        private readonly string[] visuaalisetTyylit = { "Pixel art", "Realistinen 3D", "Sarjakuvamainen", "Retro", "Matala-poly" };
        private readonly string[] aanimaailmat = { "Synthwave", "Orkesterimusiikki", "Ambient", "Kauhuäänet" };
        private readonly string[] paaMekaniikat = { "Taistelu", "Tutkiminen", "Pulmanratkaisu", "Ajanhallinta", "Vuoropohjainen strategia" };
        private readonly string[] pelaajanKyvyt = {"Loikkaaminen", "Aikamatkustus", "Lentäminen",
        "Esineiden muokkaaminen", "Teleportaatio"};
        private readonly string[] pelaajanRoolit = {"Sankari", "Vakoilija", "Neuvottelija", "Tutkija", "Vallanpitäjä" };
        private readonly string[] erikoisominaisuudet = {"Esteiden luominen", "Mielikuvitukselliset aseet", "Muodonmuutos" };
        private readonly string[] hahmonKehitykset = {"Tasojen nousu", "Taitopuu", "Uudet kyvyt esineitä löytämällä" };
        private readonly string[] ryhmadynamiikat = {"Tiimipohjainen peli", "Yksin sankarina", "Kumppanit joita voi rekrytoida" };
        private readonly string[] paajuonenTeemat = {"Kosto", "Arvoituksen selvittäminen", "Taistelu oikeuden puolesta", "Menneisyyden kohtaaminen", "Selviytyminen" };
        private readonly string[] tavoitteenSyyt = {"Päähahmo haluaa pelastaa rakkaansa", "Päähahmo haluaa pysäyttää aikamatkustavan roiston", "Päähahmo haluaa löytää menneisyytensä mysteerin" };
        private readonly string[] juonenkaanteet = {"Tärkeän henkilön pettäminen", "Odottamaton liittolainen", "Todellisuus ei ole sitä miltä näyttää", "Identiteetikriisi" };
        private readonly string[] tunnelmat = {"Melankolinen", "Toiveikas", "Kauhistuttava", "Iloisen värikäs", "Synkkä ja mysteerinen" };
        private readonly string[] vihollistenRoolit = {"Kätyri", "Pomovastukset", "Näkymättömät ansat", "Aivoa vaativat palikkatehtävät" };
        private readonly string[] vihollistenMotivaatiot = {"Maailman hallitseminen", "Kaiken tuhoaminen", "Oma pelastuminen", "Resurssien hankkiminen" };
        private readonly string[] haasteet = {"Vaihteleva sää", "Vähenevät resurssit", "Luonnonkatastrofit", "Rajalliset liikkumismahdollisuudet" };
        private readonly string[] vaikeustasonTyypit = {"Perma-death", "Satunnaiset vihollis spawnit", "Rajalliset tallennuspaikat", "Souls-like", "Roguelike"};
        private readonly string[] pelitilat = {"Yhteisöpeli", "Kilpaileva moninpeli", "Yksinpeli", "Survival mode" };
        private readonly string[] sivutoiminnot = {"Korttipeli", "Kalastaminen", "Kilpa-ajo", "Base-building", "Crafting" };
        private readonly string[] loppuratkaisut = {"Hyvä loppu", "Paha loppu", "Neutraali loppu", "Täysin arvaamaton käänne", "Monta loppua" };
        private readonly string[] vaikuttavatPaatokset = {"Tarinalliset valinnat", "Uskollisuus eri hahmoille tai ryhmille", "Valinnat tehtävien aikana" };
        private readonly string[] vuorovaikutustavat = {"Hahmojen kanssa juttelu ja suhteiden rakentaminen", "Tarjouskauppa", "Taivuttelu", "Lahjonta", "Uhkailu", "Ryöstäminen", "Diplomatia" };

        private Random random= new Random();

        public Form1()
        {
            InitializeComponent();
        }


        private void GeneroiBT_Click(object sender, EventArgs e)
        {
            //Generoidaan satunnaiset elementit

            string genre = genret[random.Next(genret.Length)];
            string miljoo = miljoot[random.Next(miljoot.Length)];
            string tavoite = tavoitteet[random.Next(tavoitteet.Length)];
            string pelaaja = pelaajat[random.Next(pelaajat.Length)];
            string visuaalinenTyyli = visuaalisetTyylit[random.Next(visuaalisetTyylit.Length)];
            string aanimaailma = aanimaailmat[random.Next(aanimaailmat.Length)];
            string paaMekaniikka = paaMekaniikat[random.Next(paaMekaniikat.Length)];
            string pelaajanKyky = pelaajanKyvyt[random.Next(pelaajanKyvyt.Length)];
            string pelaajanRooli = pelaajanRoolit[random.Next(pelaajanRoolit.Length)];
            string erikoisominaisuus = erikoisominaisuudet[random.Next(erikoisominaisuudet.Length)];
            string hahmonKehitys = hahmonKehitykset[random.Next(hahmonKehitykset.Length)];
            string ryhmadynamiikka = ryhmadynamiikat[random.Next(ryhmadynamiikat.Length)];
            string paajuonenTeema = paajuonenTeemat[random.Next(paajuonenTeemat.Length)];
            string tavoitteenSyy = tavoitteenSyyt[random.Next(tavoitteenSyyt.Length)];
            string juonenkaanne = juonenkaanteet[random.Next(juonenkaanteet.Length)];
            string tunnelma = tunnelmat[random.Next(tunnelmat.Length)];
            string vihollistenRooli = vihollistenRoolit[random.Next(vihollistenRoolit.Length)];
            string vihollistenMotivaatio = vihollistenMotivaatiot[random.Next(vihollistenMotivaatiot.Length)];
            string haaste = haasteet[random.Next(haasteet.Length)];
            string vaikeustasonTyppi = vaikeustasonTyypit[random.Next(vaikeustasonTyypit.Length)];
            string pelitila = pelitilat[random.Next(pelitilat.Length)];
            string sivutoiminto = sivutoiminnot[random.Next(sivutoiminnot.Length)];
            string loppuratkaisu = loppuratkaisut[random.Next(loppuratkaisut.Length)];
            string vaikuttavaPaatos = vaikuttavatPaatokset[random.Next(vaikuttavatPaatokset.Length)];
            string vuorovaikutustapa = vuorovaikutustavat[random.Next(vuorovaikutustavat.Length)];

            //Rakennetaan pelin idea

            string idea = $"Genre: {genre} \r\n Miljöö: {miljoo}\r\nTavoite: {tavoite}\r\n Pelaaja: {pelaaja}\r\nVisuaalinen tyyli: {visuaalinenTyyli}\r\nÄänimaailma: {aanimaailma}\r\nPäämekaniikka: {paaMekaniikka}\r\nPelaajan kyky: {pelaajanKyky}\r\nPelaajan rooli: {pelaajanRooli}\r\nErikoisominaisuus: {erikoisominaisuus}\r\nHahmon kehitys: {hahmonKehitys}\r\nRyhmädynamiikka: {ryhmadynamiikka}\r\nPääjuonen teema: {paajuonenTeema}\r\nTavoitteen syy: {tavoitteenSyy}\r\nJuonenkäänne: {juonenkaanne}\r\nTunnelma: {tunnelma}\r\nVihollisten rooli: {vihollistenRooli}\r\nVihollisten motivaatio: {vihollistenMotivaatio}\r\nHaaste: {haaste}\r\nVaikeustason tyyppi: {vaikeustasonTyppi}\r\nPelitila: {pelitila}\r\nSivutoiminto: {sivutoiminto}\r\nLoppuratkaisu: {loppuratkaisu}\r\nVaikuttavat päätökset: {vaikuttavaPaatos}\r\nVuorovaikutustapa: {vuorovaikutustapa} ";

            // Näytetään idea tekstikentässä

            IdeaTB.Text = idea;
        }
    }
}
