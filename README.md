
MoodWcfService was a primary solution, so it is not functioning properly.
To run a program:
- CoreWebApi -> appsettings.json -> change AttachDbFilename to location, that the database (App_Data folder) is in
- Run CoreWebApi through IIS Express, do not close this project
- SharpProxy -> change InternalPort to 63772 -> run
- MoodFull -> RestClient -> change url to SharpProxy shown "Your IP Address" -> run

**Caution**: phone WIFI address must be the same, as the computer that the program is running on.

---------------------------------------------

# VEIKIMAS

1. Įsirašyti SharpProxy
2. Yra du solutions!!
3. **VISŲ PIRMA** - įsijungti Core Web Api --> appsettings.json --> pakeisti AttachDbFilename
(pagal location, kuriame yra projekto duomenų bazė. Ji yra projekto App_Data foldery)
4. Paleisti projekta Core Web Api per IIS Express. Galima iškart nutraukti projekto veikimą, bet
**NEIŠJUNKITE ŠIO PROJEKTO**
5. Įeiti SharpProxy, pakeisti InternalPort į 63772 (greičiausia - jei pas jus irgi šituo Port deployina)
6. Paleisti SharpProxy.
7. **ANTRA** - Nueiti į MoodFull projektą. RestClient --> url pakeisti į SharpProxy rodomą "Your IP Address".
Jei SharpProxy nustatytas External Port 5000 - tai taip ir palikti. Žinoma, pakeitus url turi likti ši dalis:
5000/api/user
8. Paleisti projektą. Man ant emuliatoriaus neveikia, geriausia prijungtus androidinį telefoną.
9. **ĮSPĖJIMAS** Telefono WIFI turi būti tas pats, kaip ir kompiuteryje, kuriame paleista programa.


Norint, kad pasileistu maps'ai, reikia pakeisti Google Api_Key.
Taip pat, norint, kad veiktu emociju detection, reikia pakeisti Azure Api_key
