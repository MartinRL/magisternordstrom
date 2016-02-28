using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new[] { "Alingsås", "Arboga", "Arvika", "Askersund", "Avesta", "Boden", "Bollnäs", "Borgholm", "Borlänge", "Borås", "Djursholm", "Eksjö", "Enköping", "Eskilstuna", "Eslöv", "Fagersta", "Falkenberg", "Falköping", "Falun", "Filipstad", "Flen", "Gränna", "Gävle", "Göteborg", "Hagfors", "Halmstad", "Haparanda", "Hedemora", "Helsingborg", "Hjo", "Hudiksvall", "Huskvarna", "Härnösand", "Hässleholm", "Höganäs", "Jönköping", "Kalmar", "Karlshamn", "Karlskoga", "Karlskrona", "Karlstad", "Katrineholm", "Kiruna", "Kramfors", "Kristianstad", "Kristinehamn", "Kumla", "Kungsbacka", "Kungälv", "Köping", "Laholm", "Landskrona", "Lidingö", "Lidköping", "Lindesberg", "Linköping", "Ljungby", "Ludvika", "Luleå", "Lund", "Lycksele", "Lysekil", "Malmö", "Mariefred", "Mariestad", "Marstrand", "Mjölby", "Motala", "Mölndal", "Nacka", "Nora", "Norrköping", "Norrtälje", "Nybro", "Nyköping", "Nynäshamn", "Nässjö", "Oskarshamn", "Oxelösund", "Piteå", "Ronneby", "Sala", "Sandviken", "Sigtuna", "Simrishamn", "Skanör-Falsterbo", "Skara", "Skellefteå", "Skänninge", "Skövde", "Sollefteå", "Solna", "Stockholm", "Strängnäs", "Strömstad", "Sundbyberg", "Sundsvall", "Säffle", "Säter", "Sävsjö", "Söderhamn", "Söderköping", "Södertälje", "Sölvesborg", "Tidaholm", "Torshälla", "Tranås", "Trelleborg", "Trollhättan", "Trosa", "Uddevalla", "Ulricehamn", "Umeå", "Uppsala", "Vadstena", "Varberg", "Vaxholm", "Vetlanda", "Vimmerby", "Visby", "Vänersborg", "Värnamo", "Västervik", "Västerås", "Växjö", "Ystad", "Åmål", "Ängelholm", "Örebro", "Öregrund", "Örnsköldsvik", "Östersund", "Östhammar" }.Select(_ => _.ToUpper();

            var matrix = new string[15, 15] { 
                { "S", "G", "V", "K", "U", "Ö", "Y", "T", "M", "V", "D", "J", "O", "E", "I" },
                { "C", "P", "B", "T", "Y", "I", "Ä", "S", "O", "M", "E", "S", "Z", "D", "K" },
                { "A", "A", "I", "Å", "F", "G", "Q", "W", "T", "E", "O", "O", "I", "K", "Ö" },
                { "S", "F", "N", "T", "A", "I", "R", "L", "A", "A", "K", "S", "Ö", "A", "I" },
                { "V", "A", "R", "B", "E", "R", "G", "D", "L", "H", "D", "T", "J", "R", "U" },
                { "I", "G", "X", "F", "K", "Å", "H", "K", "A", "Ö", "Å", "O", "E", "L", "A" },
                { "S", "D", "Ö", "I", "U", "A", "N", "O", "C", "F", "D", "C", "E", "S", "L" },
                { "B", "A", "M", "T", "M", "A", "L", "M", "Ö", "P", "T", "K", "O", "K", "V" },
                { "Y", "D", "E", "B", "E", "I", "K", "M", "N", "J", "Ö", "H", "F", "R", "Å" },
                { "S", "F", "A", "O", "H", "B", "J", "K", "A", "T", "L", "O", "I", "O", "P" },
                { "S", "A", "X", "Ä", "K", "Å", "O", "D", "F", "R", "R", "L", "U", "N", "D" },
                { "J", "L", "B", "O", "K", "U", "T", "R", "O", "S", "A", "M", "D", "A", "C" },
                { "J", "U", "M", "E", "Å", "Q", "A", "Z", "G", "C", "B", "I", "U", "Ä", "H" },
                { "T", "N", "S", "E", "G", "M", "V", "Z", "R", "J", "E", "C", "I", "P", "O" },
                { "A", "Y", "G", "J", "I", "D", "E", "Å", "V", "Z", "E", "K", "Ö", "F", "A" }
            };
            
             
        }
    }
}


