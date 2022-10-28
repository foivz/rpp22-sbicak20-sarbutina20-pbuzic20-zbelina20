# ZMG Desktop

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Sebastijan Bičak | sbicak20@student.foi.hr | 0016150730 | sbicak20
Sebastian Arbutina | sarbutina20@student.foi.hr | 0016147707 | sarbutina20
Zvonimir Belina | zbelina20@student.foi.hr | 0016149673 | zbelina20
Patrik Bužić | pbuzic20@student.foi.hr | 0016146757 | puzic20

## Opis domene

ZMG je privatni obrt koji se bavi zaštitom metalne galanterije, od kud i naziv obrta.
ZMG radi tako da klijent donese zahrđali metal koji se zatim, važe. Temeljem kilaže robe izračunava se ukupna cijena. Metal se obrađuje cinčanjem, a cinčanje je nanošenje sloja cinka na površinu metala zbog zaštite od korozije.

Problem s kojim se poslodavac suočava je ručno izvođenje izdavanja računa pomoću Microsoft Excela, velika papirologija za praćenje transakcija. Ujedno je i otežano pregledavanje klijenata.

ZMG Desktop će biti buduće rješenje za navedene probleme privatnog obrta. Aplikacija će omogućiti lakši način rada, automatizirati će slanje poruke klijentima da je roba koja se obrađuje gotova, printanje i izadavanje računa preko aplikacije. ZMG Desktop će imati bazu podataka u kojoj su spremljeni računi i klijenti za koje privatni obrt radi. Obrađivanje podataka će se vršiti pomoće te baze podataka. Poslodavac će imati mogućnost pregledavanja obračuna kroz cijeli tjedan, nekoliko mjeseci ili godinu dana.

## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Login | Korisnik će se morati prijaviti kako bi pristupio aplikaciji. | Sebastian Arbutina
F02 | Izdavanje računa | Aplikacija će omogućiti poslodavcu izdavanje računa. Izdani račun će u stavkama računa sadržavati potrošeni materijal i usluge koje su provedene. Skeniranjem QR koda s radnog naloga, stavke će se automatski popuniti u računu i korisnik će imati mogućnost ručnog unosa stavki. | Sebastijan Bičak
F03 | Pregled računa | Aplikacija će omogućiti pregled svih računa i pregled detalja pojedinog računa. U pregledu će se moći pretraživati i sortirati račune. | Sebastijan Bičak
F04 | Pregled klijenata | Aplikacija će omogućiti prikaz svih klijenata npr. ime i prezime klijenta, adresa, broj telefona itd. | Patrik Bužić
F05 | Pregled obračuna | Aplikacija će omogućiti pregled obračuna za sve mjesece u godini. Računat će se stanje troška/zarade poslodavca. | Zvonimir Belina
F06 | Unos klijenta u bazu podataka| Aplikacija će omogućiti ručni unos klijenta u bazu podataka.  | Patrik Bužić
F07 | Brisanje klijenta iz baze podataka  | Aplikacija će omogućiti ručno brisanje klijenata iz baze podataka. | Sebastian Arbutina
F08 | Informiranje klijenata preko emaila | Aplikacija će, kada je roba gotova, poslati poruku klijentu preko emaila kako bi pokupljač za klijenta mogao preuzeti robu | Zvonimir Belina
F09 | Stanje materijala za cinčanje | Aplikacija će poslodavcu omogućiti provjeru stanja materijala kako bi bio znao koliko ima iskoristivog materijala za cinčanje. | Sebastian Arbutina
F010 | Automatsko naručivanje materijala | Aplikacija omogućava automatsko naručivanje materijala ukoliko stanje materijala dođe do određene razine, automatski će se poslati mail privatnom dobavljaču o potrebnim resursima. | Zvonimir Belina
F011 | Izračun isplativosti | Aplikacija će imati mogućnost da privatni obrt izračuna isplativost, tj. kolika je potrošnja materijala na mjesec te razlika između zarade i troška. | Patrik Bužić
F012 | Stvaranje PDF dokumentacije | Aplikacija će poslodavcu omogućiti automatsko generiranje računa u PDF-u koji će se poslati klijentu na određeni email. | Sebastijan Bičak

## Tehnologije i oprema
U našem projektu koristit ćemo .NET Framework. .NET Framework služi za izradu različitih aplikacija kao što su web stranice, desktop aplikacije i dr. Razvojno okruženje koje ćemo koristiti je Visual Studio 2022 od tvrtke Microsoft. Koristiti ćemo i MySQL bazu podataka.

