namespace SantaListv2;

class Program
{
    static void Main(string[] args)
    {
        Functions functions = new Functions();
        // Step 1: Create a list of people
        List<Person> Kids = functions.PersonInfo();

        // Step 2: Check the morality of all the people on the list
        foreach (Person Kid in Kids)
        {
            if (Kid.ToiletPaperOutward)
            {
                Kid.NaughtyOrNiceScore += 10;
            }
            else
            {
                Kid.NaughtyOrNiceScore += -10;
            }

            if (Kid.WashesHands)
            {
                Kid.NaughtyOrNiceScore += 10;
            }
            else
            {
                Kid.NaughtyOrNiceScore += -10;
            }

            if (Kid.DonatesToCharity)
            {
                Kid.NaughtyOrNiceScore += 10;
            }
            else
            {
                Kid.NaughtyOrNiceScore += 0;
            }

            switch (Kid.CarModel)
            {
                case "Volkswagen Jetta":
                    Kid.NaughtyOrNiceScore += 5;
                    break;
                case "BMW Z4":
                    break;
                case "Kia Stinger":
                    Kid.NaughtyOrNiceScore -= 5;
                    break;
                case "Toyota Supra":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Kia Forte":
                    Kid.NaughtyOrNiceScore -= 5;
                    break;
                case "Jaguar XF":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
                case "Chevrolet Spark":
                    Kid.NaughtyOrNiceScore += 5;
                    break;
                case "Toyota Yaris":
                    Kid.NaughtyOrNiceScore -= 5;
                    break;
                case "Kia Optima":
                    Kid.NaughtyOrNiceScore -= 5;
                    break;
                case "Ford Fiesta":
                    Kid.NaughtyOrNiceScore += 5;
                    break;
                case "Ford Focus":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Chrysler 300":
                    break;
                case "Porsche Panamera":
                    Kid.NaughtyOrNiceScore -= 20;
                    break;
                case "Nissan Altima":
                    break;
                case "Chevrolet Cruze":
                    break;
                case "Mercedes - Benz E - Class":
                    Kid.NaughtyOrNiceScore -= 15;
                    break;
                case "Subaru BRZ":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Chevrolet Malibu":
                    Kid.NaughtyOrNiceScore += 5;
                    break;
                case "Volkswagen Golf":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Subaru Impreza":
                    Kid.NaughtyOrNiceScore += 5;
                    break;
                case "Nissan Maxima":
                    break;
                case "Hyundai Veloster":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
                case "Alfa Romeo Giulia":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Mazda MX-5 Miata":
                    Kid.NaughtyOrNiceScore += 5;
                    break;
                case "Toyota Camry":
                    break;
                case "Nissan 370Z":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Honda Fit":
                    break;
                case "Hyundai Sonata":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
                case "Volvo S60":
                    break;
                case "Dodge Charger":
                    Kid.NaughtyOrNiceScore += 15;
                    break;
                case "Audi A6":
                    Kid.NaughtyOrNiceScore += 5;
                    break;
                case "BMW 3 Series":
                    break;
                case "Mercedes-Benz C-Class":
                    Kid.NaughtyOrNiceScore -= 5;
                    break;
                case "Audi TT":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Ford Fusion":
                    break;
                case "Tesla Model 3":
                    Kid.NaughtyOrNiceScore -= 15;
                    break;
                case "BMW 5 Series":
                    Kid.NaughtyOrNiceScore -= 5;
                    break;
                case "Dodge Challenger":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Toyota Corolla":
                    break;
                case "Mercedes-Benz SLK":
                    Kid.NaughtyOrNiceScore -= 5;
                    break;
                case "Ford Mustang":
                    Kid.NaughtyOrNiceScore += 5;
                    break;
                case "Honda Accord":
                    Kid.NaughtyOrNiceScore += 5;
                    break;
            }

            switch (Kid.HomeAdress)
            {
                //Good neighbourhoods \/
                case "Kalfarveien":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Abels gate":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Absalon Beyers gate":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Allégaten":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Allehelgens gate":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Amalie Skrams vei":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Arbeidergaten":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Armauer Hansens vei":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Arne Garborgs gate":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Arnoldus Reimers' gate":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Asbjørnsens gate":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Astrups vei":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Bispengsgaten":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Bjerregårds gate":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Blaauws vei":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Bredsgården":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Breistølen":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Breiviksveien":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Bryggen":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "C. Sundts gate":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Christian Michelsens gate":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Christies gate":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Cort Piil-Smauet":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Damsgårdsveien":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Dreggsallmenningen":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Finnegårdsgaten":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Fortunen":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Hans Hauges gate":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Haugeveien":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Jonas Lies vei":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Kaigaten":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Kirkegaten":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Klosteret":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                case "Kong Oscars gate":
                    Kid.NaughtyOrNiceScore += 10;
                    break;
                //bad neighbourhoods \/
                case "Aad Gjelles gate":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
                case "Adolph Bergs vei":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
                case "Agnes Mowinckels gate":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
                case "Asylplassen":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
                case "Baglergaten":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
                case "Baneveien":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
                case "Bankgaten":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
                case "Bjørnsons gate":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
                case "Bontelabo":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
                case "Bradbenken":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
                case "Bredalsmarken":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
                case "Bøhmergaten":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
                case "Engen":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
                case "Fabrikkgaten":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
                case "Fjøsangerveien":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
                case "Hollendergaten":
                    Kid.NaughtyOrNiceScore -= 10;
                    break;
            }

            foreach (string genre in Kid.MusicGenres)
            {

                switch (genre)
                {
                    case "Hip Hop":
                        Kid.NaughtyOrNiceScore += 10;
                        break;
                    case "Folk":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "Dancehall":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "Swing":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "Blues":
                        Kid.NaughtyOrNiceScore -= 5;
                        break;
                    case "Grunge":
                        Kid.NaughtyOrNiceScore -= 5;
                        break;
                    case "Country":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "Flamenco":
                        Kid.NaughtyOrNiceScore += 10;
                        break;
                    case "Funk":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "Pop":
                        Kid.NaughtyOrNiceScore += 10;
                        break;
                    case "J-Pop":
                        Kid.NaughtyOrNiceScore += 10;
                        break;
                    case "Shoegaze":
                        Kid.NaughtyOrNiceScore -= 10;
                        break;
                    case "Opera":
                        Kid.NaughtyOrNiceScore -= 5;
                        break;
                    case "Synthpop":
                        Kid.NaughtyOrNiceScore -= 5;
                        break;
                    case "Emo":
                        Kid.NaughtyOrNiceScore -= 5;
                        break;
                    case "Classical":
                        Kid.NaughtyOrNiceScore += 10;
                        break;
                    case "Dubstep":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "Salsa":
                        Kid.NaughtyOrNiceScore += 10;
                        break;
                    case "Reggae":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "Reggaeton":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "Soul":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "Ska":
                        Kid.NaughtyOrNiceScore -= 10;
                        break;
                    case "Trance":
                        Kid.NaughtyOrNiceScore -= 10;
                        break;
                    case "Punk":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "R&B":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "Jazz":
                        Kid.NaughtyOrNiceScore += 10;
                        break;
                    case "Techno":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "Bluegrass":
                        Kid.NaughtyOrNiceScore -= 10;
                        break;
                    case "Calypso":
                        Kid.NaughtyOrNiceScore -= 5;
                        break;
                    case "World Music":
                        Kid.NaughtyOrNiceScore -= 10;
                        break;
                    case "Gospel":
                        Kid.NaughtyOrNiceScore += 10;
                        break;
                    case "Zouk":
                        Kid.NaughtyOrNiceScore -= 5;
                        break;
                    case "K-Pop":
                        Kid.NaughtyOrNiceScore += 15;
                        break;
                    case "Industrial":
                        Kid.NaughtyOrNiceScore -= 10;
                        break;
                    case "Merengue":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "Hardcore":
                        Kid.NaughtyOrNiceScore -= 5;
                        break;
                    case "New Wave":
                        Kid.NaughtyOrNiceScore -= 5;
                        break;
                    case "Electro":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "Indie":
                        Kid.NaughtyOrNiceScore += 15;
                        break;
                    case "Electronic":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "Latin":
                        Kid.NaughtyOrNiceScore += 10;
                        break;
                    case "House":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "Metal":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "Bossa Nova":
                        Kid.NaughtyOrNiceScore += 10;
                        break;
                    case "Disco":
                        Kid.NaughtyOrNiceScore += 10;
                        break;
                    case "Afrobeat":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "Post-Punk":
                        Kid.NaughtyOrNiceScore -= 5;
                        break;
                    case "Ambient":
                        Kid.NaughtyOrNiceScore += 5;
                        break;
                    case "Trip-Hop":
                        Kid.NaughtyOrNiceScore -= 5;
                        break;
                    case "Rock":
                        Kid.NaughtyOrNiceScore += 10;
                        break;
                }
            }
        }

        List<Person> NaughtyList = new List<Person> { };
        List<Person> NiceList = new List<Person> { };

        foreach (Person Kid in Kids)
        {
            // Console.WriteLine(a.NaughtyOrNiceScore);


            if (Kid.NaughtyOrNiceScore < 0)
            {
                NaughtyList.Add(Kid);
            }
            else
            {
                NiceList.Add(Kid);
            }
        }

    }
}
