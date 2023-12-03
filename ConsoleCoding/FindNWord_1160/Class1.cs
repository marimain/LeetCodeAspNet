using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoding.FindNWord_1160
{
    internal class Class1
    {
        string[] words = { "jdimdfzbygjgdrsisgblztowvwzewvrwuizaihnctoonlykrbzncqvbzjahxvyswdzcbwaqliiyzbddtsxrwb", "ybdhccgznflezzvifoshbatwedohwwhyajylprerarbsjcll", "febacfxkrwnkyoyhykzbfuueohtkvqjkrmclmiinmpwhumaummpxjqmvqnvlwkmiizewfnqnmjqmnxacrhgxodyglvzyyii", "tcymwrytgfnbggzqptaqwzpkjhleisuwsfzhna", "rdvuvrrqerihadnurdfkzfiwtodnzcwvrmuwkyjhgkdjtnuwlclnhttidukyhfdzozix", "mjoryzsbvkqlmtmcmsjljloabfaliecpmmiumq", "iwzpczbknmqrankiypxjxthlzsvhchpqv", "dqpgxyspa", "igsvidvyonqyprvkoaphuvqaxcceefckypojgfdiyubagihkztnhindjcdpolt", "iamvwzvdbfonuurfdzcnvohqrpyxgmjvbyiyovvccsilkblgpojmwvhdsewldgzvdlnecfudjjkmgmil", "lbtjpakidwtavvtllcpekgcmqigmrfkvfjyzbxlpxtnklqrfoasnocjnlhzafcjqdjqgmuardsifyrlkvrndat", "tfqdhgvduounzgbdnipofenkqzqrlntcppwkk", "dwtuwpqugxvkjnhxvpxsdxyeurkldhxnpmicxmntiokhcclptbbbamzcrwachvzi", "pdnmdakvxnwdmibwqclesycgomztyowtjskvwiwuaumwubrmkli", "sxabmaciwtbbtwwawfhqisthjqxsxslsptcxqgsrzxiirxmzzmoulqmwzwatkrjqgpelkenulstuxwzjno", "enhtapuuyildahjyryubmjqdhbtfhjzhwppqbzriytu", "momfgjhyxzpsp", "hhdyxizwufxjewqvbforsauqgexpqgrhbmycwcaxbwldljuhclpyfawbhypinsfjepgded", "cgowwwhvlaziuptfsxqygxxnqxbregcwaodyklkkywpdtofrupmeeaeoemmpdwltdzbvebuzfumfdbdqu", "xspywgpzetvfdzeyterumsweldzsdarwshssaxlfgqqlckcyeealjqdfkjdncoivvgkmcvaod", "ubuubimfvxvplgikclwilovjdkns", "luzrzwfwzlunkwlvpjqpwckboxhgufsjlpmklxxtiuvlvaydkdvqumhiospabiemygntpfotocufttzzewkbxf", "mqqktykhjxtebccvpwttybgvkkxndvxfagdnjmbezlmdgw", "opcobbidwttpeisekgmowtgcozeinvfliqbkbrtkvwxdobavjyrknsadjijwybtbayfytxeotfp", "c", "cefqqjft", "ijavryhszfeevxvrcubkvpobxajzfjhnyffkdnucigmisvalwfngwahy", "pzfkcxeehzytxrtbdqqcoaccnqiynsjypfrcablnznvmthga", "tlekyalvnyxsvr", "jsahgkicszfcheyqafvflufycicegxclqpbmvmakjbhtuwhcxerxwspgzsrubfqblbhavlwfhx", "tvzrvrsnjetkoxbliawcvzzakpmhhvnjubczcpgobuqjqffsrdxtxjarzgsuryajuatcyfbroginvjhlauzbrkhssf", "dqbrdlmkhkrdzecilmfuavrphuxbqjo", "pmdpypebaobezmcfazewjbabjqjvrefyravwrvneyfpesbwnbbymuvovjvqgfwmzcsweifbpkuzicpjsj", "wfobqlvkmehlrh", "soormzqclvrrhftinorqqtfprxqufqsadalczqgbdnirkohqvzucsuunzjvbcfrryzztgy", "lfpvzygoenywdaddtsnrtmdhqnrkuyydwbwmzbwxzmoxwxvyttomlqdsekhyoaltxjhdtggwxrueelgh", "sikbegcpidcsnbierikpueovdqaxzis", "bchfnjcxqkfavrpotyghvhdzfsnigpgeuen", "igcpbhexbrhqgvzbjuvgehqrntbdfluouysupmtykobvkxzhumwxtntmbnyditvjmgoqtbiabkzfx", "xlgxysycbrskihoxiolefjhgdluugsuvvlhxlbqxzcqgqoxrmhmrylpfbarrplqgpvep", "oivjponqitutsacujnlmwotbeinwfygnzdzqet", "yktuffealtkznzvccxuzejpruspfldidkheondsmdbgwrabkmwgtbguayqhyiynfjfqgbpxoizlhottxeqbauj", "sxghynxeletecuqbafmqmlmiwlaenuujfipfkeylcyfjxkznpkc", "gxekcfwgn", "zitnbxgfpnzdoaahksuajugypfdlzwzadmksgtuqoevnqjkwoybabozgovuzlazwlopcuofwnqpkcpyupnh", "oydlvwonusmqypnlpwhdakzdoft", "kphotdvwvjypd", "cdcwreimmvstaytgnlwrdzumkilseqrorlsgzmmogjixszokypjalqmexhjesknsnpgjowypsno", "bbfbbepyutonbnmtbmmdrgxnhoifxluendcayelykgoglnrucegkhoczbajaobdggmusdbdllz", "tmelbseagubuvjjvpzkyvbxcyxzoxjvhcqwmesdwi", "twbedagexfuyyghuqxgwxmtbckchmiknghoaswufihzcmcdkyiqphjwpgpqsavoiiejfoqoucmvcahxmshu", "aqnipfzpclcsyuecagdfho", "cfcigrykqaeclkckntqkioexxvzvqfyirgqiwsbamtigxewdgpbhxsrwiofxzakvofqzbznbkfpfqpnns", "uoyzgkluftocnmbdrpyrmaywyyevbfcebzfxqljgigcgfmoeznqpkbmiwmziqlmdealiknlfzdwbadyjunth", "pniwsxvfxlsfhkhijuwcdvzahgzjmxdjpggcmynlfeitrggpgfudhfsswqaxapmkalrmiikrdcqyovqqyiasc", "hjoff", "zchyafrvstjxrpcrjtxrzqtgemtnbioizjvrsbmmwsqfcqtovk", "rqopixeyjdtwekhdilymtmbvpllrbcfkfojwyzgvhlhxvflywzqiiqlnwooudmwjtfikdgecxsbwxnmmyaxkqyxbqsgn", "jrjjoqkpqfjslcklltztyhkmrqmlmvjczidsswyhmyowxuunogxomhxtireakdfheffjaarcmonvxxuhvlnpujenrvjpsdrngsif", "oluqeooumhfdizvbmzzxznccypdfqeibvhhbbknqcvdryuiqzmheivglczcxcneypm", "odiyjnibfvnmojenjmtnawnnsatslheoqliyqtsmrxojxlsqep", "xodhotsxujcannmgvmszwnpvlyxrvfntk", "pal", "pfuaarkhepsjjtljpdhne", "cmravobrplecnohwhfcxbgsmkqkqjmdrpz", "rhwlfbsjnoileeuatpwpzxsqssfxbakasvvhrnfvsnji", "cprpqsoavnarqcyjhuxeeapjwkbrignbhgkufpdbentazdgfrjksrmbvcbwypcrh", "ouxsbfsvuihlhjcsiccibxvxtpwuzhrthhotbinvclelxhujtxqnpzoylzatzgdvawmfjwychqeopcrdjnejdtfkdign", "zhoel", "jwcdwcwlljltoiepktkflngdsqeagqwowkbopjzwbruhzntusrixinwvf", "amn", "zpcniceupkondvpyjbckasmevmoxquumalzrnhpxskxugik", "cvefdfpkcctzpipaodrygoaoesgvihhhthygs", "bkohexejlvylwkrykmmcgcf", "olpytsjqlkdpwi", "qsidlbvlccnjtyrupfxprlwhcynoyxlbrxjojkiqrsawbaumnzkdkzchommc", "ixnpbwnjtpqczoybczviqfbjtuxjdibzgispvxdnjppranzldirjcxut", "zlzvegbitlzahbmkectimwpbaletlxpcotygzvwridoiswxiuawtz", "fhptimdesuoqzjiblcwnhhbaxptzraksykvfpunxfufrwcmvqnwjocoiy", "aiyorgqnkvdopapcjpenkymhnynpkzyntylozbydnpibdrpbvcutpxudrcsizoyk", "nmuyeikwomlcripugwjypkfvbvizvrmndhsacmdocjjdhtnqvuxmgrcfeczuxsa", "geulhswpnmyweuswggltxsguxnnvecovqxvteiuadxgdksmjtitwcpzmbxicwvclkndttsduxb", "tbdazbskpejjkquorhfdafdvlgglefjhqguriqaefpvhcqscfhtvkimqvjzxtaf", "ldnnyerfedgsffdhpbmbwuubrzsjibafxqccryuljvusadrlfxqw", "meylutslakssulbpvfonrfmvugblinwzrfgopxafnwwdcuufjuaimxrbheehjndxbiohskmvjrmpcewvvvrbaqbkfffgbb", "ygjmeswiarqiwkpuzjsfnbabtvgapaoazzkuafcpuuavzmvvhcnwedpgbizznkygooedxjggbdkrgkcyaautpvwwnvlfwikyl", "mjgnewabmklmzwazyhcdoyqowpgrdcnuzwoha", "nljceveqjwgwmylmbgkawzjdvueoglyxdbpdyqpgwgtmixlkxphtltijcm", "maunpmlrxvreydzpzllevzlxpbkeeyrsskuhtklrnmpytaugdnuvgotmptgprsfcrcenxg", "wxqdzhmffyesnlbweaipjgjojsvvfmyyrsxjuqgyseuojmsemhgxalbbdiepwbizkf", "ricbkdxnkujtlgnuzcx", "gttdwdoclpkcejljedytqilnrpgsphfetbxztwihmhhspvyfdtbavl", "srmlsxsnohyy", "lpg", "qpmfbycwecpgnthstqwcdwrfxlykjteonfqvgqfxgyjmnqfh", "guojktcpspmbtsfucyze", "uhkpgnmkewkhymqyfzxbb", "qifzafbdvmjgfmzdotznlbzsllakihgzdpmwliwmmyoyovofyhxupehqjryccvzsejvnfebbyaxtwji", "xifotcwgywruiymsgmkamaaqnawvooilhqflxptbiewtzcufqvlldsxapunlbbzurwlegvspxhkjnivmeuxu", "ewpkblzobahkxvmaorqxotmlszkjlnbbqhgfeoymxntpsilzzmgknzkpgwanlajbagyxdaxvgg", "xuxovygmkcyukmtsfwquiw", "otvowenq", "thfd", "upypegljhttngfmnrwoqunnysvaauywjppaqlqayfcpajnirjgwjmaeyfpkexyfhdztctsctgfyoyi", "pypgyhubkosgpcsiucjvocobhfiayxjydpjakwpduaybk", "zskfzaqcegxmcxjyyraaaskmurewhpdgeccdiqdruevkipfynevvgdwpmevxolczrssveyf", "qazabogdtspviktvigfumcliotxzlfgqdmnwnejdyuiaxdrhjpzpodjmk", "qozbqbokeous", "gwlvoonxjrhvzyqmnlwfykqex", "uaumnvenxonkofoquxkbevxhinefttwiymaeecwzlknmzljzcldmmpekrnfdql", "xzrghwbgmljjbboonroxerqkbuygiouaylhkdauoagnizfndqzabdbycwa", "wrmcoohqyiwguwxntxlaxlrcambhvughnujvqxtvxuiyvvbgdsqukkdrprcxk", "kajvhekqzmmolchwsnhwsotawzndwpoxxcphjxvjhwyqhzffyilcvwin", "osnjdwvjwtqplvovigvmkkuvzvyrnqbfpliyhvtbquiyucvfxzrvupjsaxisiqvdvjuavclfmbeddvype", "aa", "hzvczfzpteogbzckschfxooyybkkyodaoncwlfjrrozjedbniwhmrxbxgvsknpjtntia", "mnsplhfonlxqrfaoiqbroqrtvjdurciceuyazjslbxkznbjsaaiaiumshqmcdjrzkzkxskoiacnlwuumchanvp", "y", "llusbfpxolpcuxqlxsxusxljtvzoaukhebnimpaczhdgtlpdzmmxvqi", "cxxpgjxrfajufcyljmtomctdloifssgmqpdxnvnojtbczsunjirzmpavidwgvcrwioubusmrprda", "elyrktioorsgpmdogctdzoyumidyhkrcxjpsnqcjzqacpzsockdmpbobd", "cwklazpkfcycsdfjmjryxlikfpcjnjvjwckghqzhgcyhrfbfetmbakpnzjuvgmfngqluuxqvgprdmcclrdwkazvjciecidp", "jxgoqngvvdqgfzdtnlppzlpyxissnjpbcfvvdlzztbzspiwfglqbmvvqnpiscxzdmclnervesecqyyuppzeqnfzpddjn", "itprgrhysrwmhhaawatgzcoifzidwsmbubyigwcewvfsxipilgmyjoabnhovsr", "sdvroatgoiowdqxcchbkxuabrrxqrwqwaamebflbubghhdujyvjtrqjhs", "lcizmwl", "zbycvvwywvprknqomewgnukldcvzehmailqnpabcehjrsespzmcchlfiutwqhlcgvwwzgftqnsmmlxdot", "ycfajupfdilekjptftutzfultpjrupvajbtphxuxjacorflgh", "voeqeuorsrbostmivapuxevtmilhzxpeswivyiqkflxgdwpdieptpvplailynqsakhfnoluw", "qhaqtselyauycemuspozlctffeurfclumidaildhczgorkrvydqcraxhstswypcjktjzyijgbmozwfk", "cifmzmjvtuwzrvszvlkrfbxdztjtwttqxvwtrrdflwraygcnncq", "tqwdkiowbbeobixyurrlgzejkvrgpatwdfbkmexu", "qmohzsrkypncpinlhthrrjgalqhemwdliueqrnqbjqk", "jmuafzdxuyawoopckcihbgibuieaipjjuvelngmdwyhkthoeslmatibnxkexgiasuemzbbagijhuekilhguanvsi", "mcfttopijlwyiqjfddidkbrrznxiggspgrzv", "wkmpshoyvpcavisaluywwuxwggyguwyrewlsdxuhomkcipelifkzyremrdqnxriaddpzpqzfvdwyiuhkiyxlekpskkzawv", "qhcgluzepldgtcsyfquniwdy", "sqoxryxxgzqsjclmuvqiqawuidtihogggxjfzkniqjpyjwatpmecziomfgdkis", "istjakvtyzzaelduexpmnthzwgkwnhqtfdblilypkxirpnlnqrsjffthjdtbfwhxueboquotzvccnexwcre", "lrydfbliheallvpxasjfjfzeehxkxrgabcofnwetcjueolpgexetfieksdkeopci", "tptyttbimmijjnbciadfkwspfofbufpjuxcxylcbfdzoiqtsybxehtrryakqyptjkkkcsiqboreoiovoekelnx", "zavzklwqyzokxnunkhjylukjqcsrvlkuxs", "rtqyhcfhucrqadultzlumazicdu", "ohobdcictit", "xfganyznjxztlenimrljgyifwypjvmcxmjpdwfgspiyoyjetbrtrtxktiobhnzts", "fuvsdvoviyyzqzxliebnxpawtmczyiylnzvbyfilmbbgjoseyxbqawi", "kqtwdwcgtbgzmzejvskhevbokzdvomkawvqmsfwdhbnqdxlgy", "eplegvqtvywmbqtndpdcbbylonvowepnneqlywrtnryudbqorjasivuwkszxzfwqdqozrbubjuovkxehkenmlorvavznwoxbbj", "qjlynqakaxhvmbtzaymetjsilvmxfxjnlspufjxffwksiuyztzklwzvocatawrewicebujfgpq", "mghamvubjtiuviceyccpejehmumtaeejraargsbvfxsgbhigjejuvreuvgbjtzbrzmsrsgjhblzqoz", "zzvkiqrtyfssalidbudmgpjadfnvewcjxxeizrrkv", "wrsegnaznxixzhyhdmslgcgslrcmyvclh", "fujynwgcgocsbkzuvvppknspbvnitwbxnaf", "lihsicgcjuablnfflwuwifcrfwiioafxxbbqwgzibnwhoxzhvmhbgjafvcumjgthiqiuacojuycejodzghucnpogjyykzitugkcr", "wibifkhjooviuxbpucnreszrshiyfgcfywfncxiaodriejwrkskkwlgwxmzkrzfz", "pgmogxujiwkgusbriztdkzkoirswmxwmjjeomcbzg", "xzoksdragbjecrmropprjbtglqcsxzxaxfthhlkrcshobyisrlv", "gfgfhiljcgckutrrectpweexqmqntccqekojlbxsnvmkiareesbazlgsmunbagbmurgwzmb", "kldgnhosnhqdfpplqbpujzcpozokvyopbasgvkcevcwsrxjpgaksxybqsofsxzsdeflphvzpzqioflitssplfheepdraeketdj", "lrkykfzbqohzghvriwmwrtgptfdgwoclaehxujswufkmmuebvtozbhrjtpcmrwufrsjupoedgqsubbbvlbtkosrfdthrxbcq", "cuvkc", "qomgdgmepyktyexunnhirbqnarfdf", "rmvppwtfmeteylqons", "vdiqiavnkoxxqazrphttqhlevygfylfiyjkbmk", "nbeawufkicbfhwdohjmhalwxvnexleiarewaklpyrleygvqftnmtwhpxcbiajearbckhydjstlvwfeywdwcu", "fnwwldvonsrbqyfwecjclbodmzrgydejnsbshzbzosptoyugmvizkupntxffjzyijcjvnxhuzez", "imqfboyfcmbzjduerhkitmpopdaroi", "cukchstrkftlgefvyzpsujetytoebujmhwkipdgizdkipjcpvzzchqqrmqylmcszvemjbzgketpkzbrxguanvjbpxok", "bvyuoyqyryyeviocouoxdckpotoaklhalkxppvxwvzaxwh", "hkjlnprhizooehppsjxbsrbaxyuszevcukvoqffczvonstjiinxtwgzngctnkpbrpeohbxemlcjjgdlcvtfdodpqavcxftmnczk", "twzzzushasnqjxzfdtizajegksbhljakizojgausnhkxdfrypiriwmrraqnrhloctrvukkqons", "bizlpbpvdkcbcavxogrkaxmzbsujecqphusdxlhprrfokhbkgeapghdclkfgutfhkckoozolsyequrgnrndybvofuzca", "uhlgrpshm", "fffblhiue", "uxfxwhhhzwubnpkshnetkvmokzsnalh", "xzbqhsjmkkxkpreqdrooiifvkrxquxwlpytwbmespaqdknxcwfhnjesuwdujghoxznrlxelmi", "ljbdlnpjvzbiywyjqmxdxbqiwqkkvqslfklugpzithhviczc", "kqhattassqwlrxhpzaytmazlyfgvbglxgiqnrrghdjoclhhleqqlwdeblsviwkciqehcjypozryajlngeqrloxufpuryncat", "kyptacgghycdhhnhmlndjaqsrtjudnhwixqvuamkaguagzacczyirfqarfuklvjf", "tsuinonhxpreonbxzaztfeffdcymrxngqeuthmzojldodqlhpxpremc", "bvejqokgmvsxfugorsldmalka", "fxlloyqelywmhiwdtxvtttddthfzbajrgeznmxxgmwzvtmnnwjebeylwjspxygveswxtzefrfhlyhyyambt", "wuhqhyxfpsoaoyssbjwjxqzhckfyfsvonlmyphloyoagoxycirdriaramwxsrswbxptxzvdjticaacwnx", "vtgnhypjamsfxyvnzghqrmntherndth", "fmavnsloegrtcibrbifuibqvjvusppgmprqmibm", "prfyttezajzqbcccrhqdevnazibcpznkxouwegpbbapxlrmhkfhoihv", "hoaerkgvqbhssdrujbrtmlvwbnhqx", "ozerhqqdwfwduyxrjmtxrevbdtgmwpbhkxqjsnlssmestosukzlglqdfi", "gthdnp", "nukyujeknoixksgludcsmxbbsrqjbpnbtvuawtbihdo", "xflmwpjo", "eb", "uujqhzyytjv", "jgowebswpjsggcahajdxzlratrocfghnplpkabnzitmhfhwspgshvpamgqpilgortzvzuoexbaxcalxsxlzsdejgjgihulwxoabq", "sytmzzwifklxsrpyldonjbqchisdjfhpmhzjea", "eithdxqoyza", "sqozuxpdhuaqttpwvyilgjtrtttlmeabuxacxhhjmxfpunzdmxeghuukyutlfkk", "njsirzxawbzktvdyrhxzjkqgnipmjffsabonsdmkinjwqhmwngwcravsctcuglkk", "dmbkpmbvcklftvucfzjfagowavptxbezhrnkrvnfhauhfrdnfnxuneznqnjlwxxyhfcxrq", "cwdnifexgdpqqecqwktngwzqtqvbcywdphfxfnzoavileuflvkcnzirqdkpulrvmgjrqjblwfjdqacmwzytcqrxrspmlleolt"}; 
        string chars = "owqugdlpqrnasodvbemfhuzctbibeboxgdklfyzyucomprzzoxwwxm";
        public Class1()
        {
            CountCharacters(words, chars);
        }
        public int CountCharacters(string[] words, string chars)
        {
            if(words.Count()==0){
                return 0;
            }
            if(chars.Count()==0){
                return 0;
            }
            List<string> ws = new List<string>();

           foreach(string w in words)
            {
                if (w.Length <= chars.Length)
                {
                    if (chrcnt(chars, w) == true)
                    {
                        ws.Add(w);
                    }
                }
            }


            char[] cs=chars.ToCharArray();
            

            int pos = -1;
            int curpos = -1;
            int wcnt = 0;
            int totalcnt = 0;
            for (int i = 0; i < ws.Count(); i++)
            {
                char[] chs = ws[i].ToCharArray();
                wcnt = 0;
                bool isok = false;
                int[] csp = Enumerable.Repeat(-1, cs.Length).ToArray();
                int idx = 0;
            }
            for(int j = 0; j < ws.Count; j++)
            {
                bool isok = chrcntw(ws[j], chars);
                if (isok == true)
                {
                    totalcnt = totalcnt + ws[j].Length;
                }
            }

            System.Diagnostics.Debug.WriteLine(totalcnt);
            return totalcnt;
            
        }
        private bool chrcnt(string s1, string s2) //s1 chars. s2 words
        {
            bool isok = true;
            char[] ar1 = s1.ToCharArray();
            Array.Sort(ar1);

            for(int i = 0; i < ar1.Count(); i++)
            {
                int ln1 = s1.Length;
                string s11 = s1.Replace(ar1[i].ToString(), "");
                int ln2 = s2.Length;
                string s22 = s2.Replace(ar1[i].ToString(), "");
                if ((ln1 - s11.Length) < (ln2 - s22.Length)){
                    isok = false;
                    break;
                }
                //	int cnt = animals.Count(s => s.StartsWith("a", StringComparison.CurrentCultureIgnoreCase));
            }

            return isok;
        }
        private bool chrcntw(string s1, string s2) // s1 words s2 chars
        {
            bool isok = true;
            char[] ar1 = s1.ToCharArray();
            Array.Sort(ar1);

            for (int i = 0; i < ar1.Count(); i++)
            {
                if (s2.IndexOf(ar1[i].ToString()) < 0)
                {
                    isok = false;
                    break;
                }
                else
                {
                    int ln1 = s1.Length;
                    string s11 = s1.Replace(ar1[i].ToString(), "");
                    int ln2 = s2.Length;
                    string s22 = s2.Replace(ar1[i].ToString(), "");
                    if ((ln1 - s11.Length) > (ln2 - s22.Length))
                    {
                        isok = false;
                        break;
                    }
                }
                //	int cnt = animals.Count(s => s.StartsWith("a", StringComparison.CurrentCultureIgnoreCase));
            }

            return isok;
        }
    }
}
