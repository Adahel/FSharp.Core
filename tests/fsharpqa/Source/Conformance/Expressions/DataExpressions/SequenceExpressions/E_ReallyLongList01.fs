// #Regression #Conformance #DataExpressions #Sequences 
#light

// Verify error with lists over 500 elements
//<Expects id="FS0742" status="error">This list expression exceeds the maximum size for list literals\. Use an array for larger literals and call Array\.ToList</Expects>

let names = [
            "Aaron";
            "Abbey";
            "Abbie";
            "Abby";
            "Abel";
            "Abigail";
            "Abraham";
            "Abram";
            "Adam";
            "Adan";
            "Addison";
            "Adolfo";
            "Adrain";
            "Adrian";
            "Adrian";
            "Adriana";
            "Adriane";
            "Adrianna";
            "Adrianne";
            "Adrienne";
            "Agustin";
            "Ahmad";
            "Ahmed";
            "Aileen";
            "Aimee";
            "Aisha";
            "Aja";
            "Akeem";
            "Al";
            "Alaina";
            "Alan";
            "Alana";
            "Alanna";
            "Albert";
            "Alberto";
            "Aldo";
            "Alec";
            "Alecia";
            "Alejandra";
            "Alejandro";
            "Alesha";
            "Alex";
            "Alexa";
            "Alexander";
            "Alexandra";
            "Alexandria";
            "Alexia";
            "Alexis";
            "Alexis";
            "Alfonso";
            "Alfred";
            "Alfredo";
            "Ali";
            "Ali";
            "Alice";
            "Alicia";
            "Alina";
            "Alisa";
            "Alisha";
            "Alison";
            "Alissa";
            "Allan";
            "Allen";
            "Allie";
            "Allison";
            "Allyson";
            "Alma";
            "Alonzo";
            "Alphonso";
            "Alton";
            "Alvaro";
            "Alvin";
            "Alycia";
            "Alyse";
            "Alysha";
            "Alysia";
            "Alyson";
            "Alyssa";
            "Amanda";
            "Amanda";
            "Amber";
            "Amelia";
            "Ami";
            "Amie";
            "Amir";
            "Amit";
            "Amos";
            "Amy";
            "Ana";
            "Anastasia";
            "Anderson";
            "Andre";
            "Andrea";
            "Andrea";
            "Andreas";
            "Andres";
            "Andrew";
            "Andrew";
            "Andria";
            "Andy";
            "Angel";
            "Angel";
            "Angela";
            "Angelia";
            "Angelica";
            "Angelina";
            "Angelique";
            "Angelo";
            "Angie";
            "Anita";
            "Ann";
            "Anna";
            "Anne";
            "Annemarie";
            "Annette";
            "Annie";
            "Annmarie";
            "Anthony";
            "Anthony";
            "Antione";
            "Antoine";
            "Antoinette";
            "Anton";
            "Antonia";
            "Antonio";
            "Antony";
            "Antwan";
            "Antwon";
            "April";
            "Araceli";
            "Archie";
            "Ari";
            "Ariana";
            "Arianna";
            "Aric";
            "Ariel";
            "Ariel";
            "Arielle";
            "Arlene";
            "Armand";
            "Armando";
            "Arnold";
            "Aron";
            "Arron";
            "Arthur";
            "Arturo";
            "Asa";
            "Ashely";
            "Ashlee";
            "Ashleigh";
            "Ashley";
            "Ashley";
            "Ashli";
            "Ashlie";
            "Ashly";
            "Ashlyn";
            "Ashton";
            "Ashton";
            "Asia";
            "Athena";
            "Aubrey";
            "Aubrey";
            "Audra";
            "Audrey";
            "August";
            "Aurora";
            "Austin";
            "Autumn";
            "Avery";
            "Baby";
            "Bailey";
            "Barbara";
            "Barrett";
            "Barry";
            "Bart";
            "Beatrice";
            "Beatriz";
            "Beau";
            "Becky";
            "Belinda";
            "Ben";
            "Benito";
            "Benjamin";
            "Bennett";
            "Bennie";
            "Benny";
            "Bernadette";
            "Bernard";
            "Bernardo";
            "Bertha";
            "Beth";
            "Bethany";
            "Betsy";
            "Betty";
            "Beverly";
            "Bianca";
            "Bill";
            "Billie";
            "Billy";
            "Blaine";
            "Blair";
            "Blair";
            "Blake";
            "Blanca";
            "Bo";
            "Bobbi";
            "Bobbie";
            "Bobby";
            "Bonnie";
            "Brad";
            "Braden";
            "Bradford";
            "Bradley";
            "Bradly";
            "Brady";
            "Brain";
            "Brandan";
            "Brandee";
            "Branden";
            "Brandi";
            "Brandie";
            "Brandin";
            "Brandon";
            "Brandon";
            "Brandt";
            "Brandy";
            "Brandyn";
            "Brannon";
            "Brant";
            "Braxton";
            "Breann";
            "Breanna";
            "Breanne";
            "Brenda";
            "Brendan";
            "Brenden";
            "Brendon";
            "Brenna";
            "Brennan";
            "Brent";
            "Brenton";
            "Bret";
            "Brett";
            "Brian";
            "Briana";
            "Brianna";
            "Brianne";
            "Brice";
            "Bridget";
            "Bridgett";
            "Bridgette";
            "Britany";
            "Britney";
            "Britni";
            "Brittaney";
            "Brittani";
            "Brittanie";
            "Brittany";
            "Brittney";
            "Brittni";
            "Brittny";
            "Britton";
            "Brock";
            "Broderick";
            "Brody";
            "Bronson";
            "Brook";
            "Brooke";
            "Brooks";
            "Bruce";
            "Bryan";
            "Bryant";
            "Bryce";
            "Brynn";
            "Bryon";
            "Bryson";
            "Buddy";
            "Byron";
            "Caitlin";
            "Caitlyn";
            "Cale";
            "Caleb";
            "Callie";
            "Calvin";
            "Cameron";
            "Cameron";
            "Camille";
            "Candace";
            "Candi";
            "Candice";
            "Candis";
            "Candy";
            "Cara";
            "Carey";
            "Carey";
            "Cari";
            "Carina";
            "Carissa";
            "Carl";
            "Carla";
            "Carley";
            "Carlo";
            "Carlos";
            "Carlton";
            "Carly";
            "Carmen";
            "Carol";
            "Carolina";
            "Caroline";
            "Carolyn";
            "Carrie";
            "Carson";
            "Carter";
            "Cary";
            "Caryn";
            "Casandra";
            "Casey";
            "Casey";
            "Casie";
            "Cassandra";
            "Cassidy";
            "Cassidy";
            "Cassie";
            "Cassondra";
            "Catherine";
            "Cathleen";
            "Cathy";
            "Catrina";
            "Cecelia";
            "Cecil";
            "Cecilia";
            "Cedric";
            "Cedrick";
            "Celeste";
            "Celia";
            "Celina";
            "Cesar";
            "Chad";
            "Chadd";
            "Chadwick";
            "Chaim";
            "Chana";
            "Chance";
            "Chandler";
            "Chandra";
            "Chanel";
            "Channing";
            "Chantal";
            "Chantel";
            "Chantelle";
            "Charissa";
            "Charity";
            "Charlene";
            "Charles";
            "Charlie";
            "Charlotte";
            "Charmaine";
            "Chase";
            "Chasity";
            "Chastity";
            "Chauncey";
            "Chaz";
            "Chelsea";
            "Chelsey";
            "Chelsie";
            "Cheri";
            "Cherie";
            "Cherish";
            "Cheryl";
            "Chester";
            "Chet";
            "Cheyenne";
            "Chiquita";
            "Chloe";
            "Chris";
            "Christa";
            "Christal";
            "Christen";
            "Christi";
            "Christian";
            "Christian";
            "Christie";
            "Christin";
            "Christina";
            "Christine";
            "Christop";
            "Christoper";
            "Christopher";
            "Christopher";
            "Christy";
            "Chrystal";
            "Ciara";
            "Ciera";
            "Cierra";
            "Cindy";
            "Claire";
            "Clara";
            "Clare";
            "Clarence";
            "Clarissa";
            "Clark";
            "Claude";
            "Claudia";
            "Clay";
            "Clayton";
            "Cleveland";
            "Cliff";
            "Clifford";
            "Clifton";
            "Clint";
            "Clinton";
            "Clyde";
            "Coby";
            "Cody";
            "Cody";
            "Colby";
            "Cole";
            "Coleman";
            "Colette";
            "Colin";
            "Colleen";
            "Collin";
            "Colt";
            "Colton";
            "Connie";
            "Connor";
            "Conor";
            "Conrad";
            "Constance";
            "Cooper";
            "Cora";
            "Corbin";
            "Cordell";
            "Cordero";
            "Corey";
            "Corey";
            "Cori";
            "Corina";
            "Corinne";
            "Cornelius";
            "Cornell";
            "Corrie";
            "Corrine";
            "Cortez";
            "Cortney";
            "Cortney";
            "Cory";
            "Cory";
            "Coty";
            "Courtney";
            "Courtney";
            "Coy";
            "Craig";
            "Cristal";
            "Cristian";
            "Cristin";
            "Cristina";
            "Cristobal";
            "Cristopher";
            "Cristy";
            "Cruz";
            "Crystal";
            "Cullen";
            "Curt";
            "Curtis";
            "Cynthia";
            "Cyrus";
            "Daisy";
            "Dakota";
            "Dale";
            "Dallas";
            "Dalton";
            "Damian";
            "Damien";
            "Damion";
            "Damon";
            "Dan";
            "Dana";
            "Dana";
            "Dandre";
            "Dane";
            "Danelle";
            "Dangelo";
            "Danial";
            "Danica";
            "Daniel";
            "Daniel";
            "Daniela";
            "Daniella";
            "Danielle";
            "Danny";
            "Dante";
            "Danyelle";
            "Daphne";
            "Dara";
            "Darcy";
            "Daren";
            "Darian";
            "Darin";
            "Dario";
            "Darius";
            "Darla";
            "Darlene";
            "Darnell";
            "Daron";
            "Darrel";
            "Darrell";
            "Darren";
            "Darrick";
            "Darrin";
            "Darrius";
            "Darron";
            "Darryl";
            "Darwin";
            "Daryl";
            "Dave";
            "David";
            "David";
            "Davin";
            "Davis";
            "Davon";
            "Dawn";
            "Dayna";
            "Dean";
            "Deana";
            "Deandre";
            "Deangelo";
            "Deanna";
            "Debbie";
            "Deborah";
            "Debra";
            "Dedrick";
            "Deena";
            "Deidra";
            "Deidre";
            "Deirdre";
            "Dejuan";
            "Delbert";
            "Delia";
            "Delilah";
            "Demarco";
            "Demarcus";
            "Demario";
            "Demetria";
            "Demetrius";
            "Dena";
            "Denis";
            "Denise";
            "Dennis";
            "Denny";
            "Denver";
            "Deon";
            "Deonte";
            "Dereck";
            "Derek";
            "Deric";
            "Derick";
            "Derik";
            "Deron";
            "Derrell";
            "Derrick";
            "Deshawn";
            "Desirae";
            "Desiree";
            "Desmond";
            "Destiny";
            "Devan";
            "Deven";
            "Devin";
            "Devin";
            "Devon";
            "Devon";
            "Dewayne";
            "Dewey";
            "Dexter";
            "Diamond";
            "Diana";
            "Diane";
            "Dianna";
            "Diego";
            "Dillon";
            "Dina";
            "Dion";
            "Dirk";
            "Dolores";
            "Domingo";
            "Dominic";
            "Dominick";
            "Dominique";
            "Dominique";
            "Dominque";
            "Domonique";
            "Don";
            "Donald";
            "Donavan";
            "Donna";
            "Donnell";
            "Donnie";
            "Donny";
            "Donovan";
            "Donta";
            "Dontae";
            "Donte";
            "Dora";
            "Dorian";
            "Doris";
            "Dorothy";
            "Douglas";
            "Drake";
            "Drew";
            "Duane";
            "Duncan";
            "Dustin";
            "Dusty";
            "Dwayne";
            "Dwight";
            "Dylan";
            "Earl";
            "Earnest";
            "Eboni";
            "Ebony";
            "Eddie";
            "Eddy";
            "Edgar";
            "Edgardo";
            "Edith";
            "Edmond";
            "Edmund";
            "Edna";
            "Eduardo";
            "Edward";
            "Edwardo";
            "Edwin";
            "Efrain";
            "Efren";
            "Eileen";
            "Elaina";
            "Elaine";
            "Eleanor";
            "Elena";
            "Eli";
            "Elias";
            "Eliezer";
            "Elijah";
            "Elisa";
            "Elisabeth";
            "Elise";
            "Eliseo";
            "Elisha";
            "Elisha";
            "Elissa";
            "Eliza";
            "Elizabeth";
            "Elizabeth";
            "Ellen";
            "Elliot";
            "Elliott";
            "Ellis";
            "Elmer";
            "Eloy";
            "Elsa";
            "Elton";
            "Elvin";
            "Elvis";
            "Elyse";
            "Emanuel";
            "Emilee";
            "Emilie";
            "Emilio";
            "Emily";
            "Emma";
            "Emmanuel";
            "Emmett";
            "Enrique";
            "Eric";
            "Erica";
            "Erich";
            "Erick";
            "Ericka";
            "Erik";
            "Erika";
            "Erin";
            "Erin";
            "Ernest";
            "Ernesto";
            "Ernie";
            "Errol";
            "Ervin";
            "Erwin";
            "Esmeralda";
            "Esteban";
            "Estevan";
            "Esther";
            "Ethan";
            "Eugene";
            "Eunice";
            "Eva";
            "Evan";
            "Evelyn";
            "Everett";
            "Ezekiel";
            "Ezequiel";
            "Ezra";
            "Fabian";
            "Faith";
            "Fallon";
            "Fatima";
            "Federico";
            "Felecia";
            "Felicia";
            "Felipe";
            "Felisha";
            "Felix";
            "Fernando";
            "Fidel";
            "Floyd";
            "Forrest";
            "Frances";
            "Francesca";
            "Francesco";
            "Francine";
            "Francis";
            "Francisco";
            "Frank";
            "Frankie";
            "Franklin";
            "Fred";
            "Freddie";
            "Freddy";
            "Frederick";
            "Fredrick";
            "Gabriel";
            "Gabriela";
            "Gabriella";
            "Gabrielle";
            "Gail";
            "Galen";
            "Garett";
            "Garret";
            "Garrett";
            "Garrick";
            "Garry";
            "Gary";
            "Gavin";
            "Gena";
            "Genaro";
            "Gene";
            "Geneva";
            "Genevieve";
            "Geoffrey";
            "George";
            "Georgia";
            "Georgina";
            "Gerald";
            "Gerard";
            "Gerardo";
            "German";
            "Gilbert";
            "Gilberto";
            "Gillian";
            "Gina";
            "Ginger";
            "Gino";
            "Giovanni";
            "Giselle";
            "Giuseppe";
            "Gladys";
            "Glen";
            "Glenda";
            "Glenn";
            "Gloria";
            "Gonzalo";
            "Gordon";
            "Grace";
            "Graciela";
            "Grady";
            "Graham";
            "Grant";
            "Grayson";
            "Greg";
            "Gregg";
            "Greggory";
            "Gregorio";
            "Gregory";
            "Gretchen";
            "Griffin";
            "Griselda";
            "Guadalupe";
            "Guadalupe";
            "Guillermo";
            "Gustavo";
            "Guy";
            "Gwendolyn";
            "Hailey";
            "Haley";
            "Hallie";
            "Hank";
            "Hanna";
            "Hannah";
            "Hans";
            "Harley";
            "Harold";
            "Harrison";
            "Harry";
            "Harvey";
            "Hassan";
            "Hayden";
            "Hayley";
            "Heath";
            "Heather";
            "Hector";
            "Heidi";
            "Helen";
            "Helena";
            "Henry";
            "Herbert";
            "Heriberto";
            "Herman";
            "Hilary";
            "Hilda";
            "Hillary";
            "Holli";
            "Hollie";
            "Holly";
            "Hope";
            "Horace";
            "Houston";
            "Howard";
            "Hubert";
            "Hugh";
            "Hugo";
            "Humberto";
            "Hunter";
            "Ian";
            "Iesha";
            "Ignacio";
            "India";
            "Ingrid";
            "Ira";
            "Irene";
            "Iris";
            "Irma";
            "Irvin";
            "Irving";
            "Isaac";
            "Isabel";
            "Isaiah";
            "Isaias";
            "Isiah";
            "Isidro";
            "Ismael";
            "Israel";
            "Issac";
            "Ivan";
            "Ivy";
            "Jabari";
            "Jace";
            "Jack";
            "Jackie";
            "Jackie";
            "Jacklyn";
            "Jackson";
            "Jaclyn";
            "Jacob";
            "Jacqueline";
            "Jacquelyn";
            "Jacques";
            "Jada";
            "Jade";
            "Jade";
            "Jaime";
            "Jaime";
            "Jaimie";
            "Jairo";
            "Jake";
            "Jakob";
            "Jaleesa";
            "Jalisa";
            "Jamaal";
            "Jamal";
            "Jamar";
            "Jamel";
            "James";
            "James";
            "Jameson";
            "Jamey";
            "Jami";
            "Jamie";
            "Jamie";
            "Jamil";
            "Jamila";
            "Jamison";
            "Jan";
            "Jana";
            "Janae";
            "Janay";
            "Jane";
            "Janel";
            "Janell";
            "Janelle";
            "Janessa";
            "Janet";
            "Janette";
            "Janice";
            "Janie";
            "Janine";
            "Janna";
            "Jarad";
            "Jared";
            "Jarod";
            "Jaron";
            "Jarred";
            "Jarrell";
            "Jarret";
            "Jarrett";
            "Jarrod";
            "Jarvis";
            "Jasen";
            "Jasmin";
            "Jasmine";
            "Jason";
            "Jason";
            "Jasper";
            "Javier";
            "Javon";
            "Jay";
            "Jayme";
            "Jayme";
            "Jayson";
            "Jazmin";
            "Jazmine";
            "Jean";
            "Jean";
            "Jeana";
            "Jeanette";
            "Jeanine";
            "Jeanna";
            "Jeanne";
            "Jeannette";
            "Jeannie";
            "Jed";
            "Jedediah";
            "Jedidiah";
            "Jeff";
            "Jefferson";
            "Jeffery";
            "Jeffrey";
            "Jeffry";
            "Jena";
            "Jenelle";
            "Jenifer";
            "Jenna";
            "Jenni";
            "Jennie";
            "Jennifer";
            "Jennifer";
            "Jenny";
            "Jerad";
            "Jerald";
            "Jeramie";
            "Jeramy";
            "Jered";
            "Jerel";
            "Jereme";
            "Jeremey";
            "Jeremiah";
            "Jeremie";
            "Jeremy";
            "Jeri";
            "Jermaine";
            "Jermey";
            "Jerod";
            "Jerome";
            "Jeromy";
            "Jerrell";
            "Jerrica";
            "Jerrod";
            "Jerry";
            "Jesica";
            "Jess";
            "Jesse";
            "Jesse";
            "Jessi";
            "Jessica";
            "Jessica";
            "Jessie";
            "Jessie";
            "Jessika";
            "Jessy";
            "Jesus";
            "Jill";
            "Jillian";
            "Jim";
            "Jimmie";
            "Jimmy";
            "Jo";
            "Joan";
            "Joann";
            "Joanna";
            "Joanne";
            "Joaquin";
            "Jocelyn";
            "Jodi";
            "Jodie";
            "Jody";
            "Jody";
            "Joe";
            "Joel";
            "Joelle";
            "Joesph";
            "Joey";
            "Johanna";
            "Johathan";
            "John";
            "John";
            "Johnathan";
            "Johnathon";
            "Johnna";
            "Johnnie";
            "Johnny";
            "Johnpaul";
            "Jolene";
            "Jon";
            "Jonah";
            "Jonas";
            "Jonathan";
            "Jonathan";
            "Jonathon";
            "Joni";
            "Jordan";
            "Jordan";
            "Jordon";
            "Jorge";
            "Jory";
            "Jose";
            "Josef";
            "Joseph";
            "Joseph";
            "Josephine";
            "Josh";
            "Joshua";
            "Joshua";
            "Josiah";
            "Josie";
            "Josue";
            "Jovan";
            "Joy";
            "Joyce";
            "Juan";
            "Juana";
            "Juanita";
            "Judith";
            "Judson";
            "Judy";
            "Julia";
            "Julian";
            "Juliana";
            "Julianna";
            "Julianne";
            "Julie";
            "Juliet";
            "Julio";
            "Julius";
            "June";
            "Junior";
            "Justen";
            "Justin";
            "Justin";
            "Justina";
            "Justine";
            "Justine";
            "Juston";
            "Kacey";
            "Kaci";
            "Kacie";
            "Kacy";
            "Kai";
            "Kaila";
            "Kaitlin";
            "Kaitlyn";
            "Kala";
            "Kaleb";
            "Kaleigh";
            "Kaley";
            "Kali";
            "Kameron";
            "Kami";
            "Kandace";
            "Kandice";
            "Kara";
            "Kareem";
            "Karen";
            "Kari";
            "Karin";
            "Karina";
            "Karissa";
            "Karl";
            "Karla";
            "Karrie";
            "Kasey";
            "Kasey";
            "Kassandra";
            "Kassie";
            "Kate";
            "Katelin";
            "Katelyn";
            "Katelynn";
            "Katharine";
            "Katherine";
            "Katheryn";
            "Kathleen";
            "Kathrine";
            "Kathryn";
            "Kathy";
            "Kati";
            "Katie";
            "Katlyn";
            "Katrina";
            "Katy";
            "Kayla";
            "Kaylee";
            "Kayleigh";
            "Keaton";
            "Keegan";
            "Keely";
            "Keenan";
            "Keisha";
            "Keith";
            "Kellen";
            "Kelley";
            "Kelli";
            "Kellie";
            "Kelly";
            "Kelly";
            "Kelsey";
            "Kelsey";
            "Kelsie";
            "Kelvin";
            "Ken";
            "Kendall";
            "Kendall";
            "Kendra";
            "Kendrick";
            "Kenneth";
            "Kenny";
            "Kent";
            "Kenton";
            "Kenya";
            "Keon";
            "Keri";
            "Kerri";
            "Kerrie";
            "Kerry";
            ]
            

exit 1
