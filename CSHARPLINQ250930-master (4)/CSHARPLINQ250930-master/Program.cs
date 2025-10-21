#region pet list

using System.ComponentModel.DataAnnotations;

List<Pet> pets =
[
    new()
    {
        Name = "Mindegy",
        Owner = "Varga Jázmin",
        Species = "Dog",
        Breed = "Vizsla",
        Born = DateTime.Parse("2010-03-21"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Kapor",
        Owner = "Szász Kristóf",
        Species = "Cat",
        Breed = "Persian",
        Born = DateTime.Parse("2025-05-04"),
        IsAlive = true,
        Legs = 3,
    },
    new()
    {
        Name = "Betti",
        Owner = "Szalonnás István",
        Species = "Dog",
        Breed = "Westie",
        Born = DateTime.Parse("2003-04-12"),
        IsAlive = false,
        Legs = 4,
    },
    new()
    {
        Name = "Szász",
        Owner = "Sajti Viktor",
        Species = "Dog",
        Breed = "Bishon havanese",
        Born = DateTime.Parse("2019-05-02"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Bogyó",
        Owner = "Nagy Bálint",
        Species = "Dog",
        Breed = "Chiwawa",
        Born = DateTime.Parse("2022-09-06"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Ferenc",
        Owner = "Kovács Ádám",
        Species = "Fish",
        Breed = "Sailfish",
        Born = DateTime.Parse("2022-05-01"),
        IsAlive = true,
        Legs = 0,
    },
    new()
    {
        Name = "Ferenc",
        Owner = "Késmárki Gábor",
        Species = "Spider",
        Breed = "Tarantulla",
        Born = DateTime.Parse("2025-09-30"),
        IsAlive = true,
        Legs = 8,
    },
    new()
    {
        Name = "Kígyó",
        Owner = "Herda Laura",
        Species = "Snake",
        Breed = "Corn snake",
        Born = DateTime.Parse("2025-09-24"),
        IsAlive = false,
        Legs = 0,
    },
    new()
    {
        Name = "Dániel",
        Owner = "Gaál Ámon",
        Species = "Dog",
        Breed = "Staffordshire terrier",
        Born = DateTime.Parse("2015-12-10"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Kutya",
        Owner = "Ács Dániel",
        Species = "Kangaroo",
        Breed = "African kangaroo",
        Born = DateTime.Parse("2016-08-17"),
        IsAlive = true,
        Legs = 1,
    },
    new()
    {
        Name = "Fifike",
        Owner = "Achukwu-Szirmai Patrick",
        Species = "Dog",
        Breed = "Dobberman",
        Born = DateTime.Parse("2017-08-17"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Puki",
        Owner = "Bárczi Dávid",
        Species = "Chinchilla",
        Breed = "Blue diamond",
        Born = DateTime.Parse("2024-02-10"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Vénusz",
        Owner = "Deák Márk",
        Species = "Dog",
        Breed = "Husky",
        Born = DateTime.Parse("2024-08-10"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Hádész",
        Owner = "Holzinger Vanessza",
        Species = "Dog",
        Breed = "Stuffy",
        Born = DateTime.Parse("2023-04-16"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Lucie",
        Owner = "Holzinger Vanessza",
        Species = "Cat",
        Breed = "Mixed breed",
        Born = DateTime.Parse("2019-10-06"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Béla",
        Owner = "Holzinger Vanessza",
        Species = "Horse",
        Breed = "Hungarian Sport Horse",
        Born = DateTime.Parse("1996-05-06"),
        IsAlive = false,
        Legs = 4,
    },
    new()
    {
        Name = "Kira",
        Owner = "Holzinger Vanessza",
        Species = "Dog",
        Breed = "Labrador",
        Born = DateTime.Parse("2022-03-16"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Nyafi",
        Owner = "Iványi Bence",
        Species = "Cat",
        Breed = "Housecat",
        Born = DateTime.Parse("2023-05-08"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Dobos",
        Owner = "Kovács Albert",
        Species = "Dog",
        Breed = "Pitbull terrier",
        Born = DateTime.Parse("2021-09-02"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Lucie",
        Owner = "Paksa László",
        Species = "Dog",
        Breed = "Fench bulldog",
        Born = DateTime.Parse("2019-11-01"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Akio",
        Owner = "Szőke Máté",
        Species = "Dog",
        Breed = "Shiba-inu",
        Born = DateTime.Parse("2018-12-10"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Cica",
        Owner = "Tanai Gábor",
        Species = "Cat",
        Breed = "Calico",
        Born = DateTime.Parse("2023-06-01"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Guszti",
        Owner = "Tanai Gábor",
        Species = "Cat",
        Breed = "Housecat",
        Born = DateTime.Parse("2024-07-01"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Drazsi",
        Owner = "Turai Flóra",
        Species = "Dog",
        Breed = "Pug",
        Born = DateTime.Parse("2019-01-11"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Bajúsz",
        Owner = "Holzinger Vanessza",
        Species = "Cat",
        Breed = "Bengalian",
        Born = DateTime.Parse("2022-12-04"),
        IsAlive = true,
        Legs = 3,
    },
    new()
    {
        Name = "Tücsi",
        Owner = "Achukwu-Szirmai Patrick",
        Species = "Dog",
        Breed = "Dachshound",
        Born = DateTime.Parse("2019-04-20"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Grabowsky",
        Owner = "Juhász Zoltán",
        Species = "Hamster",
        Breed = "Robarowski dwarf hamster",
        Born = DateTime.Parse("2020-05-02"),
        IsAlive = false,
        Legs = 4,
    },
    new()
    {
        Name = "Mr. Wick",
        Owner = "Juhász Zoltán",
        Species = "Hamster",
        Breed = "Dzungarian dwarf hamster",
        Born = DateTime.Parse("2023-05-20"),
        IsAlive = false,
        Legs = 4,
    },
    new()
    {
        Name = "Thomas Edison",
        Owner = "Juhász Zoltán",
        Species = "Dog",
        Breed = "Streetmix",
        Born = DateTime.Parse("2005-07-02"),
        IsAlive = false,
        Legs = 4,
    },
    new()
    {
        Name = "Tappancs",
        Owner = "Juhász Zoltán",
        Species = "Cat",
        Breed = "housecat",
        Born = DateTime.Parse("2000-12-04"),
        IsAlive = false,
        Legs = 4,
    },
    new()
    {
        Name = "Bella",
        Owner = "Barabás Zsombor",
        Species = "Dog",
        Breed = "German shepherd",
        Born = DateTime.Parse("2020-04-12"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Name = "Máté",
        Owner = "Chamie Mohamed",
        Species = "Rabbit",
        Breed = "Angora rabbit",
        Born = DateTime.Parse("2025-10-07"),
        IsAlive = false,
        Legs = 4,
    },
    new()
    {
        Name = "Borka",
        Owner = "Csiha Márk",
        Species = "Parrot",
        Breed = "Amazon parrot",
        Born = DateTime.Parse("2024-07-30"),
        IsAlive = false,
        Legs = 2,
    },
    new()
    {
        Name = "Bobby",
        Owner = "Engert Dániel",
        Species = "Dog",
        Breed = "Stafford shield terrier",
        Born = DateTime.Parse("2010-06-19"),
        IsAlive = false,
        Legs = 4,
    },
    new()
    {
        Owner = "Fábián Enikő Jázmin",
        Name = "Nyunyi",
        Species = "Rabbit",
        Breed = "Netherland dwarf rabbit",
        Born = DateTime.Parse("2023-09-15"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Owner = "Dobos Martin Zsolt",
        Name = "Dina",
        Species = "Dog",
        Breed = "Mixed breed",
        Born = DateTime.Parse("2016-04-10"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Owner = "Kardos András",
        Name = "Mia",
        Species = "Cat",
        Breed = "House cat",
        Born = DateTime.Parse("2025-04-11"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Owner = "Mogyorósi Gábor Zsolt",
        Name = "Tiara",
        Species = "Cat",
        Breed = "House cat",
        Born = DateTime.Parse("2020-04-21"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Owner = "Mogyorósi Gábor Zsolt",
        Name = "Tigris",
        Species = "Cat",
        Breed = "House cat",
        Born = DateTime.Parse("2020-04-21"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Owner = "Mogyorósi Gábor Zsolt",
        Name = "Lizzy",
        Species = "Dog",
        Breed = "Labrador",
        Born = DateTime.Parse("2018-01-12"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Owner = "Pádár Sándor Bendegúz",
        Name = "Mirci",
        Species = "Cat",
        Breed = "House cat",
        Born = DateTime.Parse("2024-11-01"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Owner = "Péter Dániel",
        Name = "Onyx",
        Species = "Dog",
        Breed = "Golden retriver",
        Born = DateTime.Parse("2011-09-11"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Owner = "Pető Tamás",
        Name = "Zsolti",
        Species = "Cat",
        Breed = "House cat",
        Born = DateTime.Parse("2025-10-06"),
        IsAlive = true,
        Legs = 3,
    },
    new()
    {
        Owner = "Tagscherer Balázs",
        Name = "Zeusz",
        Species = "Dog",
        Breed = "Mixed breed",
        Born = DateTime.Parse("2023-05-15"),
        IsAlive = true,
        Legs = 4,
    },
    new()
    {
        Owner = "Rácz Attila",
        Name = "Kodi",
        Species = "Cat",
        Breed = "House cat",
        Born = DateTime.Parse("2018-06-17"),
        IsAlive = true,
        Legs = 4,
    },
];
#endregion

#region progtetelek
// - sorozatszámítás - (összegzés) -> (átlagszámítás)
// - megszámlálás
// - szélsőérték meghatározás (max, min)

// - lineáris keresés
// - kiválasztás (linker csak túlcsordulás-ellenőrzés nélkül)
// - eldöntés (linker, csak bool returnnel)

// - kiválogatás
// - csoportosítás (szétválogatás)

// - unió   - .union()          / unionby()
// - metszet    - .intersect()  / .intersectby()
// - diferenciál    - .except() / exceptby()

// 'egyéb' nevezetes algoritmusok: 
// - projekció 


// - rendezés
// - distinkció


#endregion

Console.WriteLine($"count of pets: {pets.Count}");

//összegzés
// ?: kommunlatíven hány éven keresztül boldogítottak minket a kisállataink?
var osszEletkor = pets.Sum(p => p.Age);
Console.WriteLine($"az állatkák összéletkora: {osszEletkor:0.00} év");

//átlagszámítás
// ?: mennyi a kisállatok átlagéletkora?
var atlagElletkor = pets.Average(p => p.Age);
Console.WriteLine($"az állatok átlagéletkora: {atlagElletkor:0.0} év");

//megszámlálás
// ? hány macska van a listában?
var macskakSzama = pets.Count(p => p.Species == "Cat");
Console.WriteLine($"macskák száma: {macskakSzama} db");

//? hány halott kutya van a listában?
var halottKutyakSzama = pets.Count(p => !p.IsAlive && p.Species == "Dog");
Console.WriteLine($"{halottKutyakSzama} kutyus nincs már velünk :(");

//szélsőérték
// min/max ===> ÉRTÉKET ad vissza
// minby/maxby ===> az értékhez tartozó PÉLDÁNYT adja vissza

// ? mikor született a legöregebb allat
var elsoAllatSzulinapja = pets.Min(p => p.Born);
Console.WriteLine($"legöregebb allat szülinapja: {elsoAllatSzulinapja:D}");

// ? melyik állatnak van a legtöbb állat (-> példányt ad vissza)
var legtobbLabuAllat = pets.MaxBy(p => p.Legs);
Console.WriteLine($"legtöbb lábú állat: {legtobbLabuAllat}");

// ----------------------------------------------------------------------------------------------------

// HA van a <predicate>nek megfelelő találat, akkor visszaadja a listából az
// rendre az ELSŐ ennek megfelelő PÉLDÁNYT
// HA nincs, akkor 'Sequence contains no matching element' exceptiont dob

// ? melyik a listában az első olyan állat, ami nem [kutya, macska]?
var elsoNemKutyMacs = pets.First(p => p.Species != "Cat" && p.Species != "Dog");
Console.WriteLine($"az első 'különleges fajú' állat: {elsoNemKutyMacs}");

//// HA van a <predicate>nek megfelelő találat, akkor visszaadja a listából az
// ELSŐ ennek megfelelő PÉLDÁNYT
// HA nincs, akkor a kollekció elemei típusának megfelelően 'default' eredményt dob, ami:
// REFERENCE (class) típusok esetén null
// VALUE (struct) típusok esetén "definiált default"
// (ami ÁLTALÁBAN a típusnak megfelelő ZÉRÓ érték)
var elsoXenomorf = pets.FirstOrDefault(p => p.Species == "Xenomorf");
if (elsoXenomorf is null) Console.WriteLine("senkinek nincs xenomorfja");
else Console.WriteLine($"Az első xenomorf: {elsoXenomorf}");

//van még: .last(pred) és .lastordefault(pred)

//HA EGYETLEN EGY találat van, akkor visszaadja a <pred>nek megfelelő példányt
//HA TÖBB TALÁLAT is lenne, akkor 'Sequence contains more than one matching element' exc.
//HA NINCS egyetlen találat sem, akkor 'Sequence contains no matching element' exc.
var chamieAllata = pets.Single(p => p.Owner.Contains("Chamie"));
Console.WriteLine($"{chamieAllata.Owner}'s {chamieAllata.Species}: {chamieAllata}");

//HA EGYETLEN EGY találat van, akkor visszaadja a <pred>nek megfelelő példányt
//HA TÖBB TALÁLAT is lenne, akkor 'Sequence contains more than one matching element' exc.
//HA NINCS egyetlen találat sem, akkor típushoz tartozó default értéket ad vissza (nem exceptiont):
// reference (class) -> null
// value (struct) -> zéró
var egyetlenNemetjuhasz = pets.SingleOrDefault(p => p.Breed == "German shepherd");
Console.WriteLine($"az egyetlen németjuhász: {egyetlenNemetjuhasz}");

// ? van-e pók a kisállatok között (akár egy, akár több)
var vanPok = pets.Any(p => p.Species == "Spider");
Console.WriteLine($"{(vanPok ? "van" : "nincs")} pók");

var vane3LabuAllat = pets.Any(p => p.Legs == 3);
Console.WriteLine(vane3LabuAllat 
    ? "van háromlábú állat" 
    : "nincs háromlábú állat");

// ? MINDEN állatnak a kollekcióban van gazdája
var mindenkinekVanGazdaja = pets.All(p => p.Owner != null);
Console.WriteLine(mindenkinekVanGazdaja
    ? "mindenkinek van gazdája"
    : "van, akinek nincs gazdája");

var mindenkiLegalabbEgyEves = pets.All(p => p.Age >= 1);
Console.WriteLine(mindenkiLegalabbEgyEves
    ? "minden állat legalább egy esztendős"
    : "van olyan állat, ami még nincs egy esztendős");

// NEM LINQ, ua. mint az any()
var vanJZnekAllata = pets.Exists(p => p.Owner == "Juhász Zoltán");
Console.WriteLine(vanJZnekAllata ? "van JZnek állata" : "JZnek nincs állata");

// NEM LINQ, ua., mint a firstordefault()
var belaNevuAllat = pets.Find(p => p.Name == "Béla");
Console.WriteLine(belaNevuAllat is null
    ? "nincs Béla nefű állat"
    : $"van béla nevű állat: {belaNevuAllat}");

// indexof() -> nem linq, adott példány idexét adja vissza adott kollekcióban
// contains() -> nem linq, sub-sekvenciákat is lehet vele vizsgálni
// findindex() -> nem linq, "szó szerinti" megvalósítása a LinKer alg.

// ----------------------------------------------------------------------------------------------------

var kutyak = pets.Where(p => p.Species == "Dog");
Console.WriteLine("Kutyák: ");
foreach (var kutya in kutyak)
{
    Console.WriteLine(kutya);
}

var fajCsopik = pets.GroupBy(p => p.Species);
Console.WriteLine("Fajok szerinti csoportosítás: ");
foreach (var csoport in fajCsopik)
{
    Console.WriteLine($"\tÖsszes {csoport.Key}: ");
    foreach (var allat in csoport)
    {
        Console.WriteLine($"\t\t -- {allat.Name}");
    }
}

Console.WriteLine("Összesítő statok: ");
Console.WriteLine("\tÁllatok száma csoportonként:");

var nepesCsopik = fajCsopik.Where(g => g.Count() >= 5);
foreach (var grp in nepesCsopik)
{
    Console.WriteLine($"\t\t{grp.Key}s: {grp.Count()}");
}


//tudsz belőle dict-et csinálni
var fajDict = fajCsopik.ToDictionary(g => g.Key, g => g.Count());

Console.WriteLine(fajCsopik);

var fajok= pets.DistinctBy(p => p.Species);

//tulajdonosok listája: 
var tulajok = pets.Select(p => p.Owner);

//fajok listája (ismétlődés nélkül): 
var fajokk = pets.Select(p => p.Species).Distinct();

//fajok száma: 
Console.WriteLine($"Fajok száma: {fajok.Count()}");

var abcRendezes = pets.OrderBy(p => p.Name);
// collection-generic: .sort()