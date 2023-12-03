using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoding.FindNWord_1160
{
    internal class Class2
    {
        string[] words = { "jdimdfzbygjgdrsisgblztowvwzewvrwuizaihnctoonlykrbzncqvbzjahxvyswdzcbwaqliiyzbddtsxrwb", "ybdhccgznflezzvifoshbatwedohwwhyajylprerarbsjcll", "febacfxkrwnkyoyhykzbfuueohtkvqjkrmclmiinmpwhumaummpxjqmvqnvlwkmiizewfnqnmjqmnxacrhgxodyglvzyyii", "tcymwrytgfnbggzqptaqwzpkjhleisuwsfzhna", "rdvuvrrqerihadnurdfkzfiwtodnzcwvrmuwkyjhgkdjtnuwlclnhttidukyhfdzozix", "mjoryzsbvkqlmtmcmsjljloabfaliecpmmiumq", "iwzpczbknmqrankiypxjxthlzsvhchpqv", "dqpgxyspa", "igsvidvyonqyprvkoaphuvqaxcceefckypojgfdiyubagihkztnhindjcdpolt", "iamvwzvdbfonuurfdzcnvohqrpyxgmjvbyiyovvccsilkblgpojmwvhdsewldgzvdlnecfudjjkmgmil", "lbtjpakidwtavvtllcpekgcmqigmrfkvfjyzbxlpxtnklqrfoasnocjnlhzafcjqdjqgmuardsifyrlkvrndat", "tfqdhgvduounzgbdnipofenkqzqrlntcppwkk", "dwtuwpqugxvkjnhxvpxsdxyeurkldhxnpmicxmntiokhcclptbbbamzcrwachvzi", "pdnmdakvxnwdmibwqclesycgomztyowtjskvwiwuaumwubrmkli", "sxabmaciwtbbtwwawfhqisthjqxsxslsptcxqgsrzxiirxmzzmoulqmwzwatkrjqgpelkenulstuxwzjno", "enhtapuuyildahjyryubmjqdhbtfhjzhwppqbzriytu", "momfgjhyxzpsp", "hhdyxizwufxjewqvbforsauqgexpqgrhbmycwcaxbwldljuhclpyfawbhypinsfjepgded", "cgowwwhvlaziuptfsxqygxxnqxbregcwaodyklkkywpdtofrupmeeaeoemmpdwltdzbvebuzfumfdbdqu", "xspywgpzetvfdzeyterumsweldzsdarwshssaxlfgqqlckcyeealjqdfkjdncoivvgkmcvaod", "ubuubimfvxvplgikclwilovjdkns", "luzrzwfwzlunkwlvpjqpwckboxhgufsjlpmklxxtiuvlvaydkdvqumhiospabiemygntpfotocufttzzewkbxf", "mqqktykhjxtebccvpwttybgvkkxndvxfagdnjmbezlmdgw", "opcobbidwttpeisekgmowtgcozeinvfliqbkbrtkvwxdobavjyrknsadjijwybtbayfytxeotfp", "c", "cefqqjft", "ijavryhszfeevxvrcubkvpobxajzfjhnyffkdnucigmisvalwfngwahy", "pzfkcxeehzytxrtbdqqcoaccnqiynsjypfrcablnznvmthga", "tlekyalvnyxsvr", "jsahgkicszfcheyqafvflufycicegxclqpbmvmakjbhtuwhcxerxwspgzsrubfqblbhavlwfhx", "tvzrvrsnjetkoxbliawcvzzakpmhhvnjubczcpgobuqjqffsrdxtxjarzgsuryajuatcyfbroginvjhlauzbrkhssf", "dqbrdlmkhkrdzecilmfuavrphuxbqjo", "pmdpypebaobezmcfazewjbabjqjvrefyravwrvneyfpesbwnbbymuvovjvqgfwmzcsweifbpkuzicpjsj", "wfobqlvkmehlrh", "soormzqclvrrhftinorqqtfprxqufqsadalczqgbdnirkohqvzucsuunzjvbcfrryzztgy", "lfpvzygoenywdaddtsnrtmdhqnrkuyydwbwmzbwxzmoxwxvyttomlqdsekhyoaltxjhdtggwxrueelgh", "sikbegcpidcsnbierikpueovdqaxzis", "bchfnjcxqkfavrpotyghvhdzfsnigpgeuen", "igcpbhexbrhqgvzbjuvgehqrntbdfluouysupmtykobvkxzhumwxtntmbnyditvjmgoqtbiabkzfx", "xlgxysycbrskihoxiolefjhgdluugsuvvlhxlbqxzcqgqoxrmhmrylpfbarrplqgpvep", "oivjponqitutsacujnlmwotbeinwfygnzdzqet", "yktuffealtkznzvccxuzejpruspfldidkheondsmdbgwrabkmwgtbguayqhyiynfjfqgbpxoizlhottxeqbauj", "sxghynxeletecuqbafmqmlmiwlaenuujfipfkeylcyfjxkznpkc", "gxekcfwgn", "zitnbxgfpnzdoaahksuajugypfdlzwzadmksgtuqoevnqjkwoybabozgovuzlazwlopcuofwnqpkcpyupnh", "oydlvwonusmqypnlpwhdakzdoft", "kphotdvwvjypd", "cdcwreimmvstaytgnlwrdzumkilseqrorlsgzmmogjixszokypjalqmexhjesknsnpgjowypsno", "bbfbbepyutonbnmtbmmdrgxnhoifxluendcayelykgoglnrucegkhoczbajaobdggmusdbdllz", "tmelbseagubuvjjvpzkyvbxcyxzoxjvhcqwmesdwi", "twbedagexfuyyghuqxgwxmtbckchmiknghoaswufihzcmcdkyiqphjwpgpqsavoiiejfoqoucmvcahxmshu", "aqnipfzpclcsyuecagdfho", "cfcigrykqaeclkckntqkioexxvzvqfyirgqiwsbamtigxewdgpbhxsrwiofxzakvofqzbznbkfpfqpnns", "uoyzgkluftocnmbdrpyrmaywyyevbfcebzfxqljgigcgfmoeznqpkbmiwmziqlmdealiknlfzdwbadyjunth", "pniwsxvfxlsfhkhijuwcdvzahgzjmxdjpggcmynlfeitrggpgfudhfsswqaxapmkalrmiikrdcqyovqqyiasc", "hjoff", "zchyafrvstjxrpcrjtxrzqtgemtnbioizjvrsbmmwsqfcqtovk", "rqopixeyjdtwekhdilymtmbvpllrbcfkfojwyzgvhlhxvflywzqiiqlnwooudmwjtfikdgecxsbwxnmmyaxkqyxbqsgn", "jrjjoqkpqfjslcklltztyhkmrqmlmvjczidsswyhmyowxuunogxomhxtireakdfheffjaarcmonvxxuhvlnpujenrvjpsdrngsif", "oluqeooumhfdizvbmzzxznccypdfqeibvhhbbknqcvdryuiqzmheivglczcxcneypm", "odiyjnibfvnmojenjmtnawnnsatslheoqliyqtsmrxojxlsqep", "xodhotsxujcannmgvmszwnpvlyxrvfntk", "pal", "pfuaarkhepsjjtljpdhne", "cmravobrplecnohwhfcxbgsmkqkqjmdrpz", "rhwlfbsjnoileeuatpwpzxsqssfxbakasvvhrnfvsnji", "cprpqsoavnarqcyjhuxeeapjwkbrignbhgkufpdbentazdgfrjksrmbvcbwypcrh", "ouxsbfsvuihlhjcsiccibxvxtpwuzhrthhotbinvclelxhujtxqnpzoylzatzgdvawmfjwychqeopcrdjnejdtfkdign", "zhoel", "jwcdwcwlljltoiepktkflngdsqeagqwowkbopjzwbruhzntusrixinwvf", "amn", "zpcniceupkondvpyjbckasmevmoxquumalzrnhpxskxugik", "cvefdfpkcctzpipaodrygoaoesgvihhhthygs", "bkohexejlvylwkrykmmcgcf", "olpytsjqlkdpwi", "qsidlbvlccnjtyrupfxprlwhcynoyxlbrxjojkiqrsawbaumnzkdkzchommc", "ixnpbwnjtpqczoybczviqfbjtuxjdibzgispvxdnjppranzldirjcxut", "zlzvegbitlzahbmkectimwpbaletlxpcotygzvwridoiswxiuawtz", "fhptimdesuoqzjiblcwnhhbaxptzraksykvfpunxfufrwcmvqnwjocoiy", "aiyorgqnkvdopapcjpenkymhnynpkzyntylozbydnpibdrpbvcutpxudrcsizoyk", "nmuyeikwomlcripugwjypkfvbvizvrmndhsacmdocjjdhtnqvuxmgrcfeczuxsa", "geulhswpnmyweuswggltxsguxnnvecovqxvteiuadxgdksmjtitwcpzmbxicwvclkndttsduxb", "tbdazbskpejjkquorhfdafdvlgglefjhqguriqaefpvhcqscfhtvkimqvjzxtaf", "ldnnyerfedgsffdhpbmbwuubrzsjibafxqccryuljvusadrlfxqw", "meylutslakssulbpvfonrfmvugblinwzrfgopxafnwwdcuufjuaimxrbheehjndxbiohskmvjrmpcewvvvrbaqbkfffgbb", "ygjmeswiarqiwkpuzjsfnbabtvgapaoazzkuafcpuuavzmvvhcnwedpgbizznkygooedxjggbdkrgkcyaautpvwwnvlfwikyl", "mjgnewabmklmzwazyhcdoyqowpgrdcnuzwoha", "nljceveqjwgwmylmbgkawzjdvueoglyxdbpdyqpgwgtmixlkxphtltijcm", "maunpmlrxvreydzpzllevzlxpbkeeyrsskuhtklrnmpytaugdnuvgotmptgprsfcrcenxg", "wxqdzhmffyesnlbweaipjgjojsvvfmyyrsxjuqgyseuojmsemhgxalbbdiepwbizkf", "ricbkdxnkujtlgnuzcx", "gttdwdoclpkcejljedytqilnrpgsphfetbxztwihmhhspvyfdtbavl", "srmlsxsnohyy", "lpg", "qpmfbycwecpgnthstqwcdwrfxlykjteonfqvgqfxgyjmnqfh", "guojktcpspmbtsfucyze", "uhkpgnmkewkhymqyfzxbb", "qifzafbdvmjgfmzdotznlbzsllakihgzdpmwliwmmyoyovofyhxupehqjryccvzsejvnfebbyaxtwji", "xifotcwgywruiymsgmkamaaqnawvooilhqflxptbiewtzcufqvlldsxapunlbbzurwlegvspxhkjnivmeuxu", "ewpkblzobahkxvmaorqxotmlszkjlnbbqhgfeoymxntpsilzzmgknzkpgwanlajbagyxdaxvgg", "xuxovygmkcyukmtsfwquiw", "otvowenq", "thfd", "upypegljhttngfmnrwoqunnysvaauywjppaqlqayfcpajnirjgwjmaeyfpkexyfhdztctsctgfyoyi", "pypgyhubkosgpcsiucjvocobhfiayxjydpjakwpduaybk", "zskfzaqcegxmcxjyyraaaskmurewhpdgeccdiqdruevkipfynevvgdwpmevxolczrssveyf", "qazabogdtspviktvigfumcliotxzlfgqdmnwnejdyuiaxdrhjpzpodjmk", "qozbqbokeous", "gwlvoonxjrhvzyqmnlwfykqex", "uaumnvenxonkofoquxkbevxhinefttwiymaeecwzlknmzljzcldmmpekrnfdql", "xzrghwbgmljjbboonroxerqkbuygiouaylhkdauoagnizfndqzabdbycwa", "wrmcoohqyiwguwxntxlaxlrcambhvughnujvqxtvxuiyvvbgdsqukkdrprcxk", "kajvhekqzmmolchwsnhwsotawzndwpoxxcphjxvjhwyqhzffyilcvwin", "osnjdwvjwtqplvovigvmkkuvzvyrnqbfpliyhvtbquiyucvfxzrvupjsaxisiqvdvjuavclfmbeddvype", "aa", "hzvczfzpteogbzckschfxooyybkkyodaoncwlfjrrozjedbniwhmrxbxgvsknpjtntia", "mnsplhfonlxqrfaoiqbroqrtvjdurciceuyazjslbxkznbjsaaiaiumshqmcdjrzkzkxskoiacnlwuumchanvp", "y", "llusbfpxolpcuxqlxsxusxljtvzoaukhebnimpaczhdgtlpdzmmxvqi", "cxxpgjxrfajufcyljmtomctdloifssgmqpdxnvnojtbczsunjirzmpavidwgvcrwioubusmrprda", "elyrktioorsgpmdogctdzoyumidyhkrcxjpsnqcjzqacpzsockdmpbobd", "cwklazpkfcycsdfjmjryxlikfpcjnjvjwckghqzhgcyhrfbfetmbakpnzjuvgmfngqluuxqvgprdmcclrdwkazvjciecidp", "jxgoqngvvdqgfzdtnlppzlpyxissnjpbcfvvdlzztbzspiwfglqbmvvqnpiscxzdmclnervesecqyyuppzeqnfzpddjn", "itprgrhysrwmhhaawatgzcoifzidwsmbubyigwcewvfsxipilgmyjoabnhovsr", "sdvroatgoiowdqxcchbkxuabrrxqrwqwaamebflbubghhdujyvjtrqjhs", "lcizmwl", "zbycvvwywvprknqomewgnukldcvzehmailqnpabcehjrsespzmcchlfiutwqhlcgvwwzgftqnsmmlxdot", "ycfajupfdilekjptftutzfultpjrupvajbtphxuxjacorflgh", "voeqeuorsrbostmivapuxevtmilhzxpeswivyiqkflxgdwpdieptpvplailynqsakhfnoluw", "qhaqtselyauycemuspozlctffeurfclumidaildhczgorkrvydqcraxhstswypcjktjzyijgbmozwfk", "cifmzmjvtuwzrvszvlkrfbxdztjtwttqxvwtrrdflwraygcnncq", "tqwdkiowbbeobixyurrlgzejkvrgpatwdfbkmexu", "qmohzsrkypncpinlhthrrjgalqhemwdliueqrnqbjqk", "jmuafzdxuyawoopckcihbgibuieaipjjuvelngmdwyhkthoeslmatibnxkexgiasuemzbbagijhuekilhguanvsi", "mcfttopijlwyiqjfddidkbrrznxiggspgrzv", "wkmpshoyvpcavisaluywwuxwggyguwyrewlsdxuhomkcipelifkzyremrdqnxriaddpzpqzfvdwyiuhkiyxlekpskkzawv", "qhcgluzepldgtcsyfquniwdy", "sqoxryxxgzqsjclmuvqiqawuidtihogggxjfzkniqjpyjwatpmecziomfgdkis", "istjakvtyzzaelduexpmnthzwgkwnhqtfdblilypkxirpnlnqrsjffthjdtbfwhxueboquotzvccnexwcre", "lrydfbliheallvpxasjfjfzeehxkxrgabcofnwetcjueolpgexetfieksdkeopci", "tptyttbimmijjnbciadfkwspfofbufpjuxcxylcbfdzoiqtsybxehtrryakqyptjkkkcsiqboreoiovoekelnx", "zavzklwqyzokxnunkhjylukjqcsrvlkuxs", "rtqyhcfhucrqadultzlumazicdu", "ohobdcictit", "xfganyznjxztlenimrljgyifwypjvmcxmjpdwfgspiyoyjetbrtrtxktiobhnzts", "fuvsdvoviyyzqzxliebnxpawtmczyiylnzvbyfilmbbgjoseyxbqawi", "kqtwdwcgtbgzmzejvskhevbokzdvomkawvqmsfwdhbnqdxlgy", "eplegvqtvywmbqtndpdcbbylonvowepnneqlywrtnryudbqorjasivuwkszxzfwqdqozrbubjuovkxehkenmlorvavznwoxbbj", "qjlynqakaxhvmbtzaymetjsilvmxfxjnlspufjxffwksiuyztzklwzvocatawrewicebujfgpq", "mghamvubjtiuviceyccpejehmumtaeejraargsbvfxsgbhigjejuvreuvgbjtzbrzmsrsgjhblzqoz", "zzvkiqrtyfssalidbudmgpjadfnvewcjxxeizrrkv", "wrsegnaznxixzhyhdmslgcgslrcmyvclh", "fujynwgcgocsbkzuvvppknspbvnitwbxnaf", "lihsicgcjuablnfflwuwifcrfwiioafxxbbqwgzibnwhoxzhvmhbgjafvcumjgthiqiuacojuycejodzghucnpogjyykzitugkcr", "wibifkhjooviuxbpucnreszrshiyfgcfywfncxiaodriejwrkskkwlgwxmzkrzfz", "pgmogxujiwkgusbriztdkzkoirswmxwmjjeomcbzg", "xzoksdragbjecrmropprjbtglqcsxzxaxfthhlkrcshobyisrlv", "gfgfhiljcgckutrrectpweexqmqntccqekojlbxsnvmkiareesbazlgsmunbagbmurgwzmb", "kldgnhosnhqdfpplqbpujzcpozokvyopbasgvkcevcwsrxjpgaksxybqsofsxzsdeflphvzpzqioflitssplfheepdraeketdj", "lrkykfzbqohzghvriwmwrtgptfdgwoclaehxujswufkmmuebvtozbhrjtpcmrwufrsjupoedgqsubbbvlbtkosrfdthrxbcq", "cuvkc", "qomgdgmepyktyexunnhirbqnarfdf", "rmvppwtfmeteylqons", "vdiqiavnkoxxqazrphttqhlevygfylfiyjkbmk", "nbeawufkicbfhwdohjmhalwxvnexleiarewaklpyrleygvqftnmtwhpxcbiajearbckhydjstlvwfeywdwcu", "fnwwldvonsrbqyfwecjclbodmzrgydejnsbshzbzosptoyugmvizkupntxffjzyijcjvnxhuzez", "imqfboyfcmbzjduerhkitmpopdaroi", "cukchstrkftlgefvyzpsujetytoebujmhwkipdgizdkipjcpvzzchqqrmqylmcszvemjbzgketpkzbrxguanvjbpxok", "bvyuoyqyryyeviocouoxdckpotoaklhalkxppvxwvzaxwh", "hkjlnprhizooehppsjxbsrbaxyuszevcukvoqffczvonstjiinxtwgzngctnkpbrpeohbxemlcjjgdlcvtfdodpqavcxftmnczk", "twzzzushasnqjxzfdtizajegksbhljakizojgausnhkxdfrypiriwmrraqnrhloctrvukkqons", "bizlpbpvdkcbcavxogrkaxmzbsujecqphusdxlhprrfokhbkgeapghdclkfgutfhkckoozolsyequrgnrndybvofuzca", "uhlgrpshm", "fffblhiue", "uxfxwhhhzwubnpkshnetkvmokzsnalh", "xzbqhsjmkkxkpreqdrooiifvkrxquxwlpytwbmespaqdknxcwfhnjesuwdujghoxznrlxelmi", "ljbdlnpjvzbiywyjqmxdxbqiwqkkvqslfklugpzithhviczc", "kqhattassqwlrxhpzaytmazlyfgvbglxgiqnrrghdjoclhhleqqlwdeblsviwkciqehcjypozryajlngeqrloxufpuryncat", "kyptacgghycdhhnhmlndjaqsrtjudnhwixqvuamkaguagzacczyirfqarfuklvjf", "tsuinonhxpreonbxzaztfeffdcymrxngqeuthmzojldodqlhpxpremc", "bvejqokgmvsxfugorsldmalka", "fxlloyqelywmhiwdtxvtttddthfzbajrgeznmxxgmwzvtmnnwjebeylwjspxygveswxtzefrfhlyhyyambt", "wuhqhyxfpsoaoyssbjwjxqzhckfyfsvonlmyphloyoagoxycirdriaramwxsrswbxptxzvdjticaacwnx", "vtgnhypjamsfxyvnzghqrmntherndth", "fmavnsloegrtcibrbifuibqvjvusppgmprqmibm", "prfyttezajzqbcccrhqdevnazibcpznkxouwegpbbapxlrmhkfhoihv", "hoaerkgvqbhssdrujbrtmlvwbnhqx", "ozerhqqdwfwduyxrjmtxrevbdtgmwpbhkxqjsnlssmestosukzlglqdfi", "gthdnp", "nukyujeknoixksgludcsmxbbsrqjbpnbtvuawtbihdo", "xflmwpjo", "eb", "uujqhzyytjv", "jgowebswpjsggcahajdxzlratrocfghnplpkabnzitmhfhwspgshvpamgqpilgortzvzuoexbaxcalxsxlzsdejgjgihulwxoabq", "sytmzzwifklxsrpyldonjbqchisdjfhpmhzjea", "eithdxqoyza", "sqozuxpdhuaqttpwvyilgjtrtttlmeabuxacxhhjmxfpunzdmxeghuukyutlfkk", "njsirzxawbzktvdyrhxzjkqgnipmjffsabonsdmkinjwqhmwngwcravsctcuglkk", "dmbkpmbvcklftvucfzjfagowavptxbezhrnkrvnfhauhfrdnfnxuneznqnjlwxxyhfcxrq", "cwdnifexgdpqqecqwktngwzqtqvbcywdphfxfnzoavileuflvkcnzirqdkpulrvmgjrqjblwfjdqacmwzytcqrxrspmlleolt" };
        string chars = "owqugdlpqrnasodvbemfhuzctbibeboxgdklfyzyucomprzzoxwwxm";
        public Class2()
        {
            CountCharacters(words, chars);
        }
        public int CountCharacters(string[] words, string chars)
        {
            if (words.Count() == 0)
            {
                return 0;
            }
            if (chars.Count() == 0)
            {
                return 0;
            }

            List<string> ws = new List<string>();
            Dictionary<char, int> dict = chrcnt(chars);
            Dictionary<char, int> d = new Dictionary<char, int>();
            int totalcnt = 0;
            //char maxch = dict.ElementAt(dict.Count-1).Key;

            foreach (string w in words)
            {
                if (w.Length <= chars.Length)
                {
                    //char[] chs = w.ToCharArray();
                    //char maxch2 = chs[chs.Length-1];
                    bool isok = true;
                    foreach (char k in w)
                    {
                        if (dict.ContainsKey(k) == true)
                        {
                            int ln1 = w.Length;
                            string s1 = w.Replace(k.ToString(), "");

                            if (dict[k] < (ln1 - s1.Length))
                            {
                                isok = false;
                                break;
                            }
                        }
                        else
                        {
                            isok = false;
                            break;
                        }
                    }
                    if (isok == true)
                    {
                        totalcnt = totalcnt + w.Length;
                    }

                }
            }
            return totalcnt;

        } 
        private Dictionary<char, int> chrcnt(string s) //s chars
        {
            char[] ar = s.ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            Array.Sort(ar);
            char cc;
            foreach (char c in ar)
            {
                cc = c;
                int ln1 = s.Length;
                string s1 = s.Replace(c.ToString(), "");
                if (dict.ContainsKey(cc) == false)
                {
                    dict.Add(c, ln1 - s1.Length);
                }
            }
            return dict;
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
