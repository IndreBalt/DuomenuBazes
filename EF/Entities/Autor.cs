using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entities
{
    /*
     ** Kas yra Entity klasės?
       - „Entity“ klasės yra C# klasės, kurios atspindi lenteles jūsų duomenų bazėje. 
       - Kiekvienas šios klasės objektas atitinka vieną įrašą lentelėje. 
       - Klasės pavadinimas atitinka lentelės pavadinimą, o klasės properčiai atitinka lentelės stulpelius.
     ** Entity klasės struktūra  
      Kiekviena „Entity“ klasė paprastai turi šiuos elementus:
       - Pirminis raktas (Primary Key): Tai unikalus identifikatorius, skirtas identifikuoti konkretų įrašą lentelėje.
       - Savybės (Properties): Savybės atitinka lentelės stulpelius. Kiekviena savybė atitinka vieną lentelės stulpelį.
       - Navigacijos savybės (Navigation Properties): Navigacijos savybės nurodo ryšius tarp skirtingų lentelių. (JOIN)
       - Nullable savybės: Jei lentelės stulpelis leidžia NULL reikšmes, tada savybė turėtų būti nullable ty prie tipo turi būti klaustukas pvz. int?.
       - Entity klasė turi turėti neparametrizuotą konstruktorių. Jei turite tik parametrizuotą konstruktorių, EF Core negalės automatiškai sukurti šios 
         klasės objektų be papildomos konfigūracijos, todėl praktikoje geriausia turėti neparametrizuotą konstruktorių.
       - Entity klasė gali turėti konstruktorių su parametrais, jei yra poreikis.
     ** Entity klasės anotacijos
      - [Key]: Nurodo, kad ši savybė yra pirminis raktas.
      - [DatabaseGenerated]: Nurodo, kaip generuoti pirminį raktą.
      - [Table]: Nurodo, kad ši klasė atitinka lentelę, kurios pavadinimas nurodomas anotacijos parametre. 
                 Klasės pavadinimas turėtu būti vienaskaita, o lentelės pavadinimas daugiskaita.
                 Jei [Table] anotacija nenurodyta, pagal nutylėjimą, klasės pavadinimas yra lentelės pavadinimas.
      - [Required]: Nurodo, kad ši savybė yra privaloma.
      - [ForeignKey]: Nurodo, kad ši savybė yra išorinis raktas.
      - [Column]: Nurodo stulpelio tipą ir ilgį.
    */

    [Table("Authors")]
    public class Autor
    {
        public Autor()
        {
        }

        public Autor(int bookId, string fullName)
        {
            BookId = bookId;
            FullName = fullName;
        }

        [Key] //nustatomas pirminis raktas DB
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // nustatomas autoincrement
        public int AuthorId { get; set; }
        [ForeignKey(nameof(Book))]
        public int BookId { get; set; }

        [Required] // nustatomas privalomas laukas DB
        public required string FullName { get; set; }
        public Book Book { get; set; }


    }
}

